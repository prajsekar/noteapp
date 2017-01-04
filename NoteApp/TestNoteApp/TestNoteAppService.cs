using FakeItEasy;
using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Core.Persistence;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestNoteApp.Service
{
    [SetUpFixture]
    public class SetupDataStoreFactory
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var fakeRepo = A.Fake<IRepository>();
            var fakeRepoFactory = A.Fake<IDataStoreFactory>();
            A.CallTo(() => fakeRepoFactory.getRepository())
                                         .Returns(fakeRepo);
            DataStoreFactory.Instance.register("localDB", fakeRepoFactory);            
            NoteAppService.RepositoryKey = "localDB";
            TestContext.FakeRepo = fakeRepo;
            TestContext.Service = new NoteAppService();
            Trace.Write("Created fakes..");
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

    }

    [TestFixture]
    public class TestNoteAppService
    {
        [Test]
        public void Test_NoteAppService_addBook()
        {
            TestContext.Service.bookService.add(new Notebook() { name = "test", Id = 1, UserId = 3 });
            A.CallTo(() => TestContext.FakeRepo.add(A<Notebook>.Ignored))
                .MustHaveHappened();
        }
        
        [Test]
        public void Test_NoteAppService_updateBook()
        {
            TestContext.Service.bookService.update(new Notebook() { name = "test", Id = 1, UserId = 3 });
            A.CallTo(() => TestContext.FakeRepo.update(A<Notebook>.Ignored, A<Expression<Func<Notebook, object>>[]>.Ignored))                
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_getBook()
        {
            TestContext.Service.bookService.get(3);
            A.CallTo(() => TestContext.FakeRepo.get<Notebook, int>(A<int>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_deleteBook()
        {
            TestContext.Service.bookService.delete(3);
            A.CallTo(() => TestContext.FakeRepo.delete<Notebook, int>(A<int>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_addNote()
        {
            TestContext.Service.noteService.add(new Note() { title = "Title1" });
            A.CallTo(() => TestContext.FakeRepo.add(A<Note>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_updateNote()
        {
            TestContext.Service.noteService.update(new Note() { title = "Title1" });
            A.CallTo(() => TestContext.FakeRepo.update(A<Note>.Ignored, A<Expression<Func<Note, object>>[]>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_getNote()
        {
            TestContext.Service.noteService.get(3);
            A.CallTo(() => TestContext.FakeRepo.get<Note, int>(A<int>.Ignored))
                .MustHaveHappened();
        }

        [Test]
        public void Test_NoteAppService_deleteNote()
        {
            TestContext.Service.noteService.delete(3);
            A.CallTo(() => TestContext.FakeRepo.delete<Note, int>(A<int>.Ignored))
                .MustHaveHappened();
        }
    }
}
