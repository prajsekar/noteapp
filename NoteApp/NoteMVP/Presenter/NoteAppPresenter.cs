using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Sync;
using NoteMVP.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVP.Presenter
{
    public class NoteAppPresenter
    {
        private MainView view;
        private INoteAppService model;        
        private User user;        
        //Hack to avoid factory (time constraint)
        public static String PresenterTypeKey;
        private bool syncEnabled = true;
        
        public NoteAppPresenter(MainView view)
        {
            Init(view, null);
        }

        private void Init(MainView view, INoteAppService service)
        {
            this.view = view;
            this.model = service;
            registerHandlers();
        }

        public NoteAppPresenter(MainView view, INoteAppService service)
        {
            Init(view, service);
        }

        private void registerHandlers()
        {
            view.LoadForm += view_LoadForm;
            view.onBookCreated += view_onBookCreated;
            view.onNoteCreated += view_onNoteCreated;
            view.onNoteDeleted += view_onNoteDeleted;
            view.onNoteUpdated += view_onNoteUpdated;
            view.onSearch += view_onSearch;
            view.onBookDeleted += view_onBookDeleted;
            view.onBookSelected += view_onBookSelected;
        }

        void view_onBookSelected(object sender, Notebook e)
        {
            view.setNoteBook(model.bookService.get(e.Id));
        }

        void view_onBookDeleted(object sender, NoteApp.Core.Model.Entity.Notebook e)
        {
            model.bookService.delete(e.Id);            
        }

        void view_onSearch(object sender, string e)
        {
            var result = model.noteService.search(e);
            view.setSearchResults(result);
        }

        
        void view_onNoteUpdated(object sender, NoteApp.Core.Model.Entity.Note e)
        {
            e.Notebook = null;   
            model.noteService.update(e);
            e.Notebook = model.bookService.get(e.NotebookId);    
        }

        void view_onNoteDeleted(object sender, NoteApp.Core.Model.Entity.Note e)
        {   
            model.noteService.delete(e.Id);
        }

        void view_onNoteCreated(object sender, NoteApp.Core.Model.Entity.Note e)
        {
            if (e.Notebook != null)
            {
                e.NotebookId = e.Notebook.Id;
                e.Notebook = null;
            }

            if (String.IsNullOrEmpty(e.Id))
            {
                e.Id = e.NotebookId + e.created;
            }
            model.noteService.add(e);
            e.Notebook = model.bookService.get(e.NotebookId); 
        }

        void view_onBookCreated(object sender, NoteApp.Core.Model.Entity.Notebook e)
        {
            e.UserId = user.Id;
            if (String.IsNullOrEmpty(e.Id))
            {
                e.Id = user.Id + e.name;
            }
            e.User = null;
            model.bookService.add(e);            
        }

        void onRemoteModified(object sender, RemoteRecords e)
        {
            Trace.Write("Data modified ");
            Trace.Write("Sync completed...");
            Trace.WriteLine("Books");

            Dictionary<String, ModifiedBook> modified = new Dictionary<String, ModifiedBook>();
            bool synced = false;
            foreach (var book in e.books)
            {
                if (model.bookService.updateModified(book) == true)
                {
                    synced = true;
                    ModifiedBook modBook = null;
                    if(!modified.TryGetValue(book.Id,out modBook)) {
                        modified.Add(book.Id, new ModifiedBook() { changeType = ModifiedBook.ChangeType.Create, source = book});
                    }
                    Trace.WriteLine("Synced Book name : " + book.name);                
                }
                
            }

            foreach (var note in e.notes)
            {
                if (model.noteService.updateModified(note) == true)
                {
                    ModifiedBook modBook;                    
                    var dbBook = model.bookService.get(note.NotebookId);

                    if(!modified.TryGetValue(dbBook.Id, out modBook)) {
                        modBook = new ModifiedBook() { changeType = ModifiedBook.ChangeType.Update, source = dbBook};
                        modified.Add(dbBook.Id, modBook);
                    }
                    modBook.changes.Add(note);                    
                    Trace.WriteLine("Synced Note : " + note.title);
                    synced = true;
                }
            }

            if (synced)
            {                
                view.setModified(modified.Values.ToList<ModifiedBook>());
            }
        }

        void view_LoadForm(object sender, EventArgs e)
        {
            user = model.userService.validate(new User { name = "John Smith", mail = "jsmith@gmail.com" });
            view.setNotebooks(model.bookService.getAll(user));
            model.user = user;
            model.init();
            //Hack to create remote db after default user created
            if (model is SyncService)
            {   
                var syncService = (SyncService)model;
                syncService.user = user;
                syncService.BooksUpdated += onRemoteModified;
                Trace.Write("Starting data watcher thread...");
                syncService.Start();
                view.user = user;
            }
            else
            {
                view.setMode(true);
            }
        }
    }
}
