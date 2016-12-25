using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Sync
{
    public class SyncService : NoteAppService
    {
        private DataWatcher watcher;        
        
        public SyncService(String repoKey, User user)
            :base(repoKey)
        {
            watcher = new DataWatcher(this, user);
            this.user = user;
            watcher.DataAvailable += (sender, args) => onWatcherEvent(sender, args);
        }

        public User user { get; set; }

        public enum AppMode
        {
            Online,
            Offline
        }

        public void setAppMode(AppMode mode)
        {
            watcher.setAppMode(mode);
        }

        public void Start()
        {
            watcher.Start();
        }

        public void Stop()
        {
            watcher.Stop();

        }

        private void onWatcherEvent(object sender, RemoteRecords notes)
        {
            if (this.BooksUpdated != null)
            {
                this.BooksUpdated(sender, notes);
            }
        }

        public event EventHandler<RemoteRecords> BooksUpdated;
    }

    
}
