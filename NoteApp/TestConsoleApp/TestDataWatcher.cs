using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class TestDataWatcher
    {
        public static void testDataWatcher()
        {
            DataWatcher watcher = new DataWatcher(new NoteAppService(), new User() { Id = 1, mail = "raj", name = "John Smith" }, 50000);
            watcher.Start();
            watcher.DataAvailable += watcher_DataAvailable;
            watcher.SyncFired += watcher_SyncFired;
            watcher.Start();
        }

        static void watcher_SyncFired(object sender, long ticks)
        {
            Console.Write("Sync fired at : " + new DateTime(ticks));
        }

        static void watcher_DataAvailable(object sender, RemoteRecords e)
        {
            Console.Write("Sync completed...");
            Console.WriteLine("Books");
            foreach (var book in e.books)
            {
                Console.WriteLine("Book name : " + book.name);
            }

            foreach (var note in e.notes)
            {
                Console.WriteLine("Note : " + note.title);
            }
        }
    }
}
