using System;
using System.Collections.Generic;
using Appnote.Core.Model.Entity;

namespace NoteApp.Core.Model.Service
{
    public interface INoteAppService
    {
        void addNote(Note note);
        void addUser(User user);
        void createNotebook(Notebook book);
        void deleteNoteBook(Notebook book);
        List<Note> findNotes(string str);
        List<Notebook> getNoteBookModified(long time);
        List<Note> getNotesModified(long time);
        void updateNote(Note note);
        void updateNoteBook(Notebook book);
    }
}
