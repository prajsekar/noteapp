using NoteApp.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVP.View
{
    public class ModifiedBook
    {
        public ModifiedBook()
        {
            changes = new List<Note>();
        }
        public enum ChangeType
        {
            Create,
            Update
        }

        public List<Note> changes { get;  set; }
        public Notebook source { get;  set; }
        public ChangeType changeType { get;  set; }
    }

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
        void setMode(bool isRemote);
        event EventHandler<Notebook> onBookCreated;
        event EventHandler<Notebook> onBookDeleted;        
        event EventHandler<Note> onNoteDeleted;
        event EventHandler<Note> onNoteUpdated;
        event EventHandler<Note> onNoteCreated;
        event EventHandler<String> onSearch;
        event EventHandler<EventArgs> LoadForm;
        event EventHandler<Notebook> onBookSelected;
        void setModified(List<ModifiedBook> books);
    }
}
