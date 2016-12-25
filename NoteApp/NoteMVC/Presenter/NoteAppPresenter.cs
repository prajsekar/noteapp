using Appnote.Core.Model.Entity;
using NoteApp.Core.Model.Service;
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
        private NoteAppService model;
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
        }

        void view_onBookDeleted(object sender, Appnote.Core.Model.Entity.Notebook e)
        {
            model.bookService.delete(e.Id);
        }

        void view_onSearch(object sender, string e)
        {
            var result = model.noteService.search(e);
            view.setSearchResults(result);
        }

        void view_onNoteUpdated(object sender, Appnote.Core.Model.Entity.Note e)
        {
            model.noteService.update(e);
        }

        void view_onNoteDeleted(object sender, Appnote.Core.Model.Entity.Note e)
        {
            var note = new Note() { Id = e.Id };
            model.noteService.delete(note.Id);
        }

        void view_onNoteCreated(object sender, Appnote.Core.Model.Entity.Note e)
        {
            if (e.Notebook != null)
            {
                e.NotebookId = e.Notebook.Id;
                e.Notebook = null;                
            }
            model.noteService.add(e);
        }

        void view_onBookCreated(object sender, Appnote.Core.Model.Entity.Notebook e)
        {

            e.UserId = user.Id;
            e.User = null;
            model.bookService.add(e);
        }

        void view_LoadForm(object sender, EventArgs e)
        {
            user = model.userService.validate(new User { name = "John Smith", mail = "raj" });
            view.setNotebooks(model.bookService.getAll(user));
        }
    }
}
