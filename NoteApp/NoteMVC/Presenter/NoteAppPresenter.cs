using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using NoteApp.Sync;
using NoteMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVP.Presenter
{
    public class NoteAppPresenter
    {
        private MainView view;
        private INoteAppService model;
        private INoteAppService remoteModel;
        private User user;
        
        public NoteAppPresenter(MainView view)
        {
            this.view = view;
            registerHandlers();
            model = new NoteAppService();            
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
            PrimaryKeyTranslator.translate(e);
            remoteModel.bookService.delete(e.Id);            
        }

        void view_onSearch(object sender, string e)
        {
            var result = model.noteService.search(e);
            view.setSearchResults(result);
        }

        
        void view_onNoteUpdated(object sender, NoteApp.Core.Model.Entity.Note e)
        {
            //_book = e.Notebook;
            e.Notebook = null;
            model.noteService.update(e);
            var newNote = (Note)e.Clone();
            PrimaryKeyTranslator.translate(newNote);            
            remoteModel.noteService.update(e);
            e.Notebook = model.bookService.get(e.NotebookId);            
        }

        void view_onNoteDeleted(object sender, NoteApp.Core.Model.Entity.Note e)
        {
            var note = new Note() { Id = e.Id , secondaryId = e.secondaryId};
            model.noteService.delete(note.Id);
            PrimaryKeyTranslator.translate(e);
            remoteModel.noteService.delete(note.Id);
        }

        void view_onNoteCreated(object sender, NoteApp.Core.Model.Entity.Note e)
        {            
            if (e.Notebook != null)
            {
                e.NotebookId = e.Notebook.Id;
                e.Notebook = null;                
            }
            var dbNote = model.noteService.add(e);
            var dbNoteClone = (Note)dbNote.Clone();
            PrimaryKeyTranslator.translate(dbNoteClone);
            if (dbNoteClone.Notebook != null)
            {
                dbNoteClone.NotebookId = dbNoteClone.Notebook.Id;
                dbNoteClone.Notebook = null;
            }
            var result = remoteModel.noteService.add(dbNote);
            e.Notebook = model.bookService.get(e.NotebookId);
            e.secondaryId = result.Id;
            dbNote.secondaryId = result.Id;
            dbNote.Notebook = null;
            model.noteService.update(dbNote);
            
        }

        void view_onBookCreated(object sender, NoteApp.Core.Model.Entity.Notebook e)
        {
            e.UserId = user.Id;
            e.User = null;
            model.bookService.add(e);
            PrimaryKeyTranslator.translate(e);
            e.UserId = user.Id;
            e.User = null;
            var result = remoteModel.bookService.add(e);
            e.secondaryId = result.Id;
            model.bookService.update(e);
        }

        void view_LoadForm(object sender, EventArgs e)
        {
            user = model.userService.validate(new User { name = "John Smith", mail = "raj" });
            view.setNotebooks(model.bookService.getAll(user));
            remoteModel = new SyncService("remoteDB", user);
        }
    }
}
