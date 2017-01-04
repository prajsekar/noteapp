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
        public static Note translate(Note note)
        {
            SwapKey(note);
            SwapKey(note.Notebook);
            return note;
        }

        private static void SwapKey(Note note)
        {
            //if (note != null)
            //{
            //    var temp = note.Id;
            //    note.Id = note.secondaryId;
            //    note.secondaryId = temp;
            //}
        }

        public static Notebook translate(Notebook book)
        {
            SwapKey(book);
            foreach(var note in book.Notes) 
            {
                SwapKey(note);
            }
            return book;
        }

        private static void SwapKey(Notebook book)
        {
            //if (book != null)
            //{
            //    var temp = book.Id;
            //    book.Id = book.secondaryId;
            //    book.secondaryId = temp;
            //}
        }
    }
}
