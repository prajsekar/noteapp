using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Application;
using NoteApp.Sync;

namespace NoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteApplication.bootstrapWinClient();
            AppDomain.CurrentDomain.SetData("TestDir", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            NoteAppService noteService = new NoteAppService();
            User dbUser = noteService.userService.validate(new User() { mail = "raj", name = "rajasekarnew" });
            Console.WriteLine("Db User read.. {0}", dbUser.Id);

            var result = new DataWatcher(noteService, dbUser).getModified(DateTime.Parse(@"12/22/2016 12:14:10 AM").Ticks);
            foreach (var wEvent in result)
            {
                Console.WriteLine("Changetype : {0} notebook Name : {1}", wEvent.changeType, wEvent.record.name);
            }
            //using (IRepository repository = Appnote.Core.Persistence.DataStoreFactory.Instance.getRepository())
            //{
            //    Console.WriteLine("Created new NoteBook");
            //    var book = repository.add<Notebook>(new Notebook() { name = "Note212", UserId = dbUser.Id });
            //    //book.User = dbUser;
            //    //repository.update<Notebook>(book, b => b.User);
            //    Console.WriteLine("Created new Note");
            //    var noteSaved = repository.add<Note>(new Note() { NotebookId = book.Id, title = "Title1", content = "Content 2" });
            //    var notes = noteService.noteService.search("Title");
            //    foreach (var note in notes)
            //    {
            //        Console.WriteLine(note.title);
            //        Console.WriteLine(new DateTime(note.updated));
            //    }

            //    var modifiednotes = noteService.noteService.getModified(DateTime.Parse(@"12/22/2016 12:14:10 AM").Ticks, dbUser.Id);
            //    foreach (var note in modifiednotes)
            //    {
            //        Console.WriteLine(note.Id);
            //    }

            //    repository.add<StoreInfo>(new StoreInfo() { lastOffline = DateTime.Now.Ticks, lastSynced = DateTime.Now.Ticks });

            //    var time = DateTime.Now.Ticks;
            //    var noteList = new List<Note>();
            //    for (var i = 0; i < 5; i++)
            //    {
            //        var newBook = new Notebook() { name = "Book1" + i, UserId = dbUser.Id };
            //        newBook = noteService.bookService.add(newBook);

            //        var newNote = new Note()
            //          {
            //              created = DateTime.Now.Ticks + i,
            //              title = "Note" + i,
            //              content = "Content" + i,
            //              NotebookId = newBook.Id
            //          };
            //        newNote = noteService.noteService.add(newNote);
            //    }

            //    var result = noteService.bookService.getAll(dbUser);
            //    foreach (var note in result)
            //    {
            //        Console.WriteLine("Note name : {0} ", note.name);
            //    }

            //}
            Console.WriteLine("Test,,,");
            Console.ReadLine();
        }
    }
}
