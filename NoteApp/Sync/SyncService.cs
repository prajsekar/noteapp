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
        private INoteAppService remoteModel;
        
        public SyncService(String repoKey, INoteAppService remoteModel,  User user)
            :base(repoKey)
        {
            watcher = new DataWatcher(this, user);
            this.user = user;
            watcher.DataAvailable += (sender, args) => onWatcherEvent(sender, args);
            this.remoteModel = remoteModel;
            this.bookService = new SyncBookService(repoKey, this, remoteModel);
            this.noteService = new SyncNoteService(repoKey, this, remoteModel);
        }
        
        private User _user;
        public override User user
        {
            get {
                return _user;
            }
            set {
                if (user != null)
                {
                    _user = value;
                    watcher.setUser(user);
                }
            }
        }

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
