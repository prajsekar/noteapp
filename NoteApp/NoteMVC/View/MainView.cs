using Cache.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVC.View
{
    public interface MainView
    {
        string userName { get; set; }
        string noteCount { get; set; }
        string bookCount { get; set; }
        void setNotebooks(List<Notebook> books);
        void setNotes(List<Note> notes);
        event EventHandler<EventArgs> onNoteSelected;
        event EventHandler<EventArgs> onBookSelected;
        event EventHandler<EventArgs> onBookCreated;
        event EventHandler<EventArgs> onNoteCreated;
    }
}
