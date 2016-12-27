using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Core.Model.Entity;

namespace NoteApp.Sync
{
    class SyncNoteService : NoteService
    {
        private INoteAppService service;
        private INoteAppService remoteModel;

        public SyncNoteService(String key, NoteAppService service, NoteAppService remoteModel)
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
            PrimaryKeyTranslator.translate(dbNoteClone);
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
            PrimaryKeyTranslator.translate(newNote);
            remoteModel.noteService.update(e);
        }

        public override void delete(int key)
        {
            var note = base.get(key);
            base.delete(note.Id);
            PrimaryKeyTranslator.translate(note);
            remoteModel.noteService.delete(note.Id);            
        }
    }
}
