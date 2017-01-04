using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Core.Model.Entity;
using System.Diagnostics;

namespace NoteApp.Sync
{
    class SyncNoteService : NoteService
    {
        private INoteAppService service;
        private INoteAppService remoteModel;

        public SyncNoteService(String key, INoteAppService service, INoteAppService remoteModel)
            : base(key, service)
        {
            this.service = service;            
            this.remoteModel = remoteModel;
        }

        public override Note add(Note e)
        {
            if (e.Notebook != null)
            {
                e.NotebookId = e.Notebook.Id;
                e.Notebook = null;
            }
            var dbNote = base.add(e);
            var dbNoteClone = (Note)dbNote.Clone();
           // PrimaryKeyTranslator.translate(dbNoteClone);
            if (dbNoteClone.Notebook != null)
            {
                dbNoteClone.NotebookId = dbNoteClone.Notebook.Id;
                dbNoteClone.Notebook = null;
            }
            var result = remoteModel.noteService.add(dbNote);
            e.Notebook = service.bookService.get(e.NotebookId);
            e.secondaryId = result.Id;
            dbNote.secondaryId = result.Id;
            dbNote.Notebook = null;
            service.noteService.update(dbNote);
            return e;
        }

        public override void update(Note e)
        {
            e.Notebook = null;
            base.update(e);
            var newNote = (Note)e.Clone();
           // PrimaryKeyTranslator.translate(newNote);
            remoteModel.noteService.update(e);
        }

        public override void delete(String key)
        {
            var note = base.get(key);
            base.delete(note.Id);
         //   PrimaryKeyTranslator.translate(note);
            remoteModel.noteService.delete(note.Id);            
        }

        public override List<Note> getModified(long time, int userId)
        {
            Trace.Write("User id : " + userId);
            return remoteModel.noteService.getModified(time, userId);
        }

        public override bool updateModified(Note note)
        {           
            Trace.Write(String.Format("UpdateModified : {0}, Id: {1}, created : {2}, updated : {3}", note.title, note.Id, note.created, note.updated));
            var result = false;
            var dbNote = get(note.Id);
            if (dbNote == null)
            {
                Trace.Write("Adding new record after sync..");
                note.Notebook = null;
                base.add(note);
                Trace.Write("UpdateModified : New Note " + note.title + "Synced to local db");
                result = true;
            }
            else
            {
                if (dbNote.updated != note.updated)
                {
                    Trace.Write("Updating remote modified note : " + note.title);
                    note.Notebook = null;
                    base.update(note);
                    result = true;
                }
                else
                {
                    Trace.Write("Ignoring for sync note : " + note.title);
                }
            }
            return result;
        }
    }
}
