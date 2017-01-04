using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteApp.Sync
{
    public class SyncService : NoteAppService
    {
        private DataWatcher watcher;
        private INoteAppService remoteModel;
        internal SyncMode mode;

        public SyncService(String repoKey, INoteAppService remoteModel,  User user, SyncMode mode)
            :base(repoKey)
        {
            watcher = new DataWatcher(this, user);
            this.user = user;
            this.mode = mode;
            watcher.DataAvailable += (sender, args) => onWatcherEvent(sender, args);
            this.remoteModel = remoteModel;
            if (mode == SyncMode.TwoWay)
            {
                this.bookService = new SyncBookService(repoKey, this, remoteModel);
                this.noteService = new SyncNoteService(repoKey, this, remoteModel);
            }
        }
        
        private User _user;
        public override User user
        {
            get {
                return _user;
            }
            set {
                if (value != null)
                {
                    _user = value;
                    watcher.setUser(value);
                }
            }
        }

        public enum AppMode
        {
            Online,
            Offline
        }

        public enum SyncMode
        {
            OneWay,
            TwoWay
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

        public override void init()
        {
            base.init();
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var remotePath = appDataPath + @"\remoteNoteDb.sdf";
            if (!File.Exists(remotePath))
            {
                File.Copy(appDataPath + @"\notestore.sdf", remotePath, false);
            }
        }
    }    
}
