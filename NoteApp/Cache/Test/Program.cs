using Cache.Entity;
using Cache.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("TestDir", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            NoteService.addUser(new User() { mail = "raj", name = "rajasekarnew" });            

            using (IRepository repository = DataStoreFactory.getRepository())
            {
                Console.WriteLine("Created new NoteBook");
                var book = repository.add<Notebook>(new Notebook() { UserId = 1, name = "Note2" });
                Console.WriteLine("Created new Note");
                var noteSaved = repository.add<Note>(new Note() { NotebookId = 1, title = "Title1", content = "Content 2" });
                var notes = NoteService.findNotes("Title");
                foreach (var note in notes)
                {
                    Console.WriteLine(note.title);
                    Console.WriteLine(new DateTime(note.updated));
                }

                var modifiednotes = NoteService.getNotesModified(DateTime.Parse(@"12/22/2016 12:14:10 AM").Ticks);
                foreach (var note in modifiednotes)
                {
                    Console.WriteLine(note.Id);
                }

                repository.add<StoreInfo>(new StoreInfo() { lastOffline = DateTime.Now.Ticks, lastSynced = DateTime.Now.Ticks });



            }
            Console.WriteLine("Test,,,");
            Console.ReadLine();
        }
    }
}
