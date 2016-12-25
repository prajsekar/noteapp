using NoteApp.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVP.View
{
    public interface MainView
    {
        string userName { get; set; }
        int noteCount { get; set; }
        int bookCount { get; set; }
        void setNotebooks(List<Notebook> books);        
        void updateNotebook(Notebook book);
        void setSearchResults(List<Note> notes);
        void updateNoteBooks(List<Notebook> books);
        void setSyncStart();
        void setSearchEnd();
        void setNoteBook(Notebook book);
        event EventHandler<Notebook> onBookCreated;
        event EventHandler<Notebook> onBookDeleted;        
        event EventHandler<Note> onNoteDeleted;
        event EventHandler<Note> onNoteUpdated;
        event EventHandler<Note> onNoteCreated;
        event EventHandler<String> onSearch;
        event EventHandler<EventArgs> LoadForm;
        event EventHandler<Notebook> onBookSelected;
    }
}
