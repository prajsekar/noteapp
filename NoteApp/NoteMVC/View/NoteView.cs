using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVC.View
{
    interface NoteView
    {
        int Id { get; set; }
        String Title { get; set; }
        String Content { get; set; }
        String NoteBookName { get; set; }
        int notebookId { get; set; }

        event EventHandler<EventArgs> onDelete;
        event EventHandler<EventHandler> onSave;        
    }
}
