using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Sync
{
    public class PrimaryKeyTranslator 
    {
        public static void translate(Note note)
        {
            SwapKey(note);
            SwapKey(note.Notebook);
        }

        private static void SwapKey(Note note)
        {
            if (note != null)
            {
                var temp = note.Id;
                note.Id = note.secondaryId;
                note.secondaryId = temp;
            }
        }

        public static void translate(Notebook book)
        {
            SwapKey(book);
            foreach(var note in book.Notes) 
            {
                SwapKey(note);
            }
        }

        private static void SwapKey(Notebook book)
        {
            if (book != null)
            {
                var temp = book.Id;
                book.Id = book.secondaryId;
                book.secondaryId = temp;
            }
        }
    }
}
