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
        public double interval {get; set;}
        private Timer timer;
        private INoteAppService service;
        private int userId;
        public event EventHandler<RemoteRecords> DataAvailable;
        public event EventHandler<long> SyncFired;
        private SyncService.AppMode mode;
        private DateTime syncStartTime;        


        public DataWatcher(INoteAppService service, User user)
        {
            init(service, user, 5000);
        }

        public DataWatcher(INoteAppService service, User user, double interval)
        {
            init(service, user, interval);
        }

        private void init(INoteAppService service, User user, double interval)
        {
            this.interval = interval;
            timer = new Timer(interval);
            timer.Elapsed += (sender, args) => elapsedHandler(sender, args);
            this.service = service;
            if (user != null)
            {
                userId = user.Id;
            }
        }

        public void setUser(User user)
        {
            if (user != null)
            {
                userId = user.Id;
            }
        }

        private void elapsedHandler(object sender, ElapsedEventArgs args)
        {
            var ticks = syncStartTime.Ticks;
            //Set next sync time
            syncStartTime = DateTime.Now;            
            if (this.SyncFired != null)
            {
                this.SyncFired(this, ticks);
            }
            if (mode == SyncService.AppMode.Offline)
            {
                Console.WriteLine("offline mode, data watcher returning");
                return;
            }
            Console.WriteLine("Timer elapsed begining to look for remote db changes");
            var result = getModified(ticks);
            if (this.DataAvailable != null && result != null)
            {
                this.DataAvailable(this, result);
            }
            else
            {
                Console.WriteLine("No new records not notifying UI");
            }

        }

        public RemoteRecords getModified(long ticks)
        {
            Console.WriteLine("Reading db...");
            var remoteRecords = new RemoteRecords();
            remoteRecords.books = service.bookService.getModified(ticks, userId).Select<Notebook, Notebook>((b) => PrimaryKeyTranslator.translate(b)).ToList<Notebook>(); ;
            remoteRecords.notes = service.noteService.getModified(ticks, userId).Select<Note, Note>((b) => PrimaryKeyTranslator.translate(b)).ToList<Note>(); ; ;
            Console.WriteLine("Compleded reading db {0} {1}", remoteRecords.books != null, remoteRecords.notes != null);
            return remoteRecords;
        }

        public void Stop() 
        {            
            timer.Stop();            
        }

        public void Start()
        {
            timer.Start();
            syncStartTime = DateTime.Now;
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
