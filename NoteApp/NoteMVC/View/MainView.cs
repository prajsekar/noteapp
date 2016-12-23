using Cache.Entity;
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
        void updateNoteBooks(List<Notebook> books);
        event EventHandler<Notebook> onBookCreated;
        event EventHandler<Notebook> onBookDeleted;        
        event EventHandler<Note> onNoteDeleted;
        event EventHandler<Note> onNoteUpdated;
        event EventHandler<Note> onNoteCreated;
    }
}
