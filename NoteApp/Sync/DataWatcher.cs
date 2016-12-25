using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NoteApp.Sync
{
    public class RemoteRecords
    {
        public List<Note> notes { get; set; }
        public List<Notebook> books { get; set; }
    }
    
    public class DataWatcher 
    {
        private double interval = 2000;
        private Timer timer;
        private INoteAppService service;
        private int userId;
        public event EventHandler<RemoteRecords> DataAvailable;
        private SyncService.AppMode mode;

        public DataWatcher(INoteAppService service, User user)
        {
            timer  = new Timer(interval);
            timer.Elapsed += (sender, args) => elapsedHandler(sender, args);
            this.service = service;
            userId = user.Id;
        }

        private void elapsedHandler(object sender, ElapsedEventArgs args)
        {
            if (mode == SyncService.AppMode.Offline)
            {
                Console.WriteLine("offline mode, data watcher returning");
                return;
            }
            Console.WriteLine("Timer elapsed begining to look for remote db changes");
            var result = getModified(DateTime.Now.Ticks);
            if (this.DataAvailable != null && result != null)
            {
                Console.WriteLine("No new records not notifying UI");
                this.DataAvailable(this, result);
            }
        }

        public RemoteRecords getModified(long ticks)
        {
            var remoteRecords = new RemoteRecords();
            remoteRecords.books = service.bookService.getModified(ticks, userId).Select<Notebook, Notebook>((b) => PrimaryKeyTranslator.translate(b)).ToList<Notebook>(); ;
            remoteRecords.notes = service.noteService.getModified(ticks, userId).Select<Note, Note>((b) => PrimaryKeyTranslator.translate(b)).ToList<Note>(); ; ;
            return remoteRecords;
        }

        public void Stop() 
        {            
            timer.Stop();            
        }

        public void Start()
        {
            timer.Start();
        }

        public void Close()
        {
            timer.Close();            
        }

        public void setAppMode(SyncService.AppMode mode)
        {
            this.mode = mode;
        }
    }
}
