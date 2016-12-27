using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Sync;
using NoteMVP.View;
using System;
using System.Collections.Generic;
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
            this.view = view;
            registerHandlers();
            if (PresenterTypeKey == "noSync")
            {
                syncEnabled = false;
            }
        }

        public NoteAppPresenter(MainView view, INoteAppService service)
        {
            this.view = view;
            this.model = service;
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
            model.noteService.add(e);
            e.Notebook = model.bookService.get(e.NotebookId); 
        }

        void view_onBookCreated(object sender, NoteApp.Core.Model.Entity.Notebook e)
        {
            e.UserId = user.Id;
            e.User = null;
            model.bookService.add(e);            
        }

        void view_LoadForm(object sender, EventArgs e)
        {            
           
            model = syncEnabled ? 
                new SyncService("localDB", new NoteAppService("remoteDB"), null) :
                new NoteAppService();

            user = model.userService.validate(new User { name = "John Smith", mail = "jsmith@gmail.com" });
            view.setNotebooks(model.bookService.getAll(user));
            model.user = user;

            //Hack to create remote db after default user created
            if (syncEnabled)
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                var remotePath = appDataPath + @"\remoteNoteDb.sdf";
                if (!File.Exists(remotePath))
                {
                    File.Copy(appDataPath + @"\notestore.sdf", remotePath, false);
                }      
            }
            //Hack to create remote db
                 
        }
    }
}
