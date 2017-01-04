using FakeItEasy;
using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Core.Persistence;
using NoteApp.Sync;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestNoteApp.Sync
{
    [SetUpFixture]
    class SetupDataStoreFactory
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var fakeRepo = A.Fake<IRepository>();
            var fakeRepoFactory = A.Fake<IDataStoreFactory>();
            A.CallTo(() => fakeRepoFactory.getRepository())
                                         .Returns(fakeRepo);
            DataStoreFactory.Instance.register("_localDB", fakeRepoFactory);            
            NoteAppService.RepositoryKey = "_localDB";
            var fakeRemoteService = A.Fake<INoteAppService>();
            
            TestContext.FakeRemoteService = fakeRemoteService;
            TestContext.FakeRepo = fakeRepo;
            
            TestContext.Service = new SyncService("_localDB", fakeRemoteService, new User() { Id = 2 }, SyncService.SyncMode.TwoWay);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
        }
    }

    public class TestContext
    {
        public static IRepository FakeRepo { get; set; }
        public static INoteAppService Service { get; set; }
        public static INoteAppService FakeRemoteService { get; set; }

    }

    [TestFixture]
    public class TestSyncService
    {
        [Test]
        public void Test_NoteApp_SyncService_addBook()
        {
            TestContext.Service.bookService.add(new Notebook() { name = "test", Id = "3test", UserId = 3 });
            A.CallTo(() => TestContext.FakeRepo.add(A<Notebook>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.bookService.add(A<Notebook>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_updateBook()
        {
            TestContext.Service.bookService.update(new Notebook() { name = "test", Id = "3test", UserId = 3 });
            A.CallTo(() => TestContext.FakeRepo.update(A<Notebook>.Ignored, A<Expression<Func<Notebook, object>>[]>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.bookService.update(A<Notebook>.Ignored))
               .MustNotHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_getBook()
        {
            TestContext.Service.bookService.get("3");
            A.CallTo(() => TestContext.FakeRepo.get<Notebook, String>(A<String>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.bookService.get(A<String>.Ignored))
               .MustNotHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_deleteBook()
        {
            TestContext.Service.bookService.delete("3");
            A.CallTo(() => TestContext.FakeRepo.delete<Notebook, String>(A<String>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.bookService.delete(A<String>.Ignored))
               .MustHaveHappened();
        }

        [Test]
        public void Test_NoteApp_SyncService_addNote()
        {
            TestContext.Service.noteService.add(new Note() { title = "Title1" });
            A.CallTo(() => TestContext.FakeRepo.add(A<Note>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.noteService.add(A<Note>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_updateNote()
        {
            TestContext.Service.noteService.update(new Note() { title = "Title1" });
            A.CallTo(() => TestContext.FakeRepo.update(A<Note>.Ignored, A<Expression<Func<Note, object>>[]>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.noteService.update(A<Note>.Ignored))
               .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_getNote()
        {
            TestContext.Service.noteService.get("3");
            A.CallTo(() => TestContext.FakeRepo.get<Note, String>(A<String>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.noteService.get(A<String>.Ignored))
               .MustNotHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_deleteNote()
        {
            TestContext.Service.noteService.delete("3");
            A.CallTo(() => TestContext.FakeRepo.delete<Note, String>(A<String>.Ignored))
                .MustHaveHappened();
            A.CallTo(() => TestContext.FakeRemoteService.noteService.delete(A<String>.Ignored))
               .MustHaveHappened();
        }

    }
}
