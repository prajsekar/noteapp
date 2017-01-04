using NoteApp.Core.Model.Entity;
using NoteMVP.Presenter;
using NoteMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNoteApp
{
    class TestView : MainView
    {
        public TestView(NoteAppPresenter presenter)
        {
            this.presenter = presenter;            
        }

        private NoteAppPresenter presenter;
        private String _userName;
        private int _noteCount;
        private int _bookCount;

        public string userName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public int noteCount
        {
            get
            {
                return _noteCount;
            }
            set
            {
                _noteCount = value;
            }
        }

        public int bookCount
        {
            get
            {
                return _bookCount;
            }
            set
            {
                _bookCount = value;
            }
        }

        public void setNotebooks(List<Notebook> books)
        {
            
        }

        public void updateNotebook(Notebook book)
        {
            
        }

        public void setSearchResults(List<Note> notes)
        {
            
        }

        public void updateNoteBooks(List<Notebook> books)
        {
           
        }

        public void setSyncStart()
        {
            
        }

        public void setSearchEnd()
        {
            
        }

        public void setNoteBook(Notebook book)
        {
           
        }

        public void bookCreated(Notebook book)
        {
            this.onBookCreated(this, book);
        }

        public void bookDeleted(Notebook book)
        {
            this.onBookDeleted(this, book);
        }

        public void noteDeleted(Note note)
        {
            this.onNoteDeleted(this, note);
        }

        public void noteUpdated(Note note)
        {
            this.onNoteUpdated(this, note);
        }

        public void noteCreate(Note note)
        {
            this.onNoteCreated(this, note);
        }

        public void searchNotes(String searchStr)
        {
            this.onSearch(this, searchStr);
        }

        public void selectNotebook(Notebook book)
        {
            this.onBookSelected(this, book);
        }

        public void loadForm()
        {
            this.LoadForm(this, new EventArgs());
        }

        public event EventHandler<Notebook> onBookCreated;
        public event EventHandler<Notebook> onBookDeleted;
        public event EventHandler<Note> onNoteDeleted;
        public event EventHandler<Note> onNoteUpdated;
        public event EventHandler<Note> onNoteCreated;
        public event EventHandler<string> onSearch;
        public event EventHandler<EventArgs> LoadForm;
        public event EventHandler<Notebook> onBookSelected;


        public void setMode(bool isRemote)
        {  
        }


        public void setModified(List<ModifiedBook> books)
        {
            throw new NotImplementedException();
        }
    }
}
