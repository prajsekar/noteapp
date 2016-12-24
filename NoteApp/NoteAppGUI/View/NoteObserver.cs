using Appnote.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppGUI.View
{
    public interface NoteObserver
    {
        void setSelectedNote(object sender, Note note);
        void setSelectedBook(object sender, Notebook notebook);
    }
}
