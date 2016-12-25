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
    public class DataWatcherEvent
    {        
        public enum ChangeType
        {
            Create,
            NotesOnly,
            Updated
        }

        public Notebook record { get; set;}
        public ChangeType changeType {get; set;}

    }
    public class DataWatcher 
    {
        private double interval = 2000;
        private Timer timer;
        private INoteAppService service;
        private int userId;
        public event EventHandler<List<DataWatcherEvent>> DataAvailable;
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

        public List<DataWatcherEvent> getModified(long ticks)
        {            
            var books = service.bookService.getModified(ticks, userId);
            List<DataWatcherEvent> result = null;
            if (books != null && books.Count > 0)
            {                
                Dictionary<int, DataWatcherEvent> eventMap = new Dictionary<int, DataWatcherEvent>();
                books.ForEach((book) =>
                {                    
                    PrimaryKeyTranslator.translate(book);
                    DataWatcherEvent watcherEvent = new DataWatcherEvent() { record = book };
                    if (book.created == book.updated)
                    {
                        watcherEvent.changeType = DataWatcherEvent.ChangeType.Create;
                    }
                    else
                    {
                        watcherEvent.changeType = DataWatcherEvent.ChangeType.Updated;
                        watcherEvent.record.Notes = new List<Note>();
                    }
                    eventMap.Add(book.secondaryId, watcherEvent);
                });

                var notes = service.noteService.getModified(ticks, userId);
                if (notes != null && notes.Count > 0)
                {
                    notes.ForEach((note) =>
                    {
                        PrimaryKeyTranslator.translate(note);
                        if (note.NotebookId != 0)
                        {
                            DataWatcherEvent watcherEvent = null;
                            if (eventMap.TryGetValue(note.Notebook.secondaryId, out watcherEvent))
                            {
                                watcherEvent.record.Notes.Add(note);
                            }
                            else
                            {
                                watcherEvent = new DataWatcherEvent()
                                {
                                    record = new Notebook() { Id = note.NotebookId, name = note.Notebook.name },
                                    changeType = DataWatcherEvent.ChangeType.NotesOnly
                                };
                                watcherEvent.record.Notes = new List<Note>();
                                watcherEvent.record.Notes.Add(note);
                                eventMap.Add(note.Notebook.secondaryId, watcherEvent);
                            }
                        }
                    });
                }
                result = eventMap.Values.ToList<DataWatcherEvent>();
            }
            return result;
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
