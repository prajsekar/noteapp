using NoteApp.Core.Model.Entity;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Sync
{
    class SyncBookService : NotebookService
    {
        private INoteAppService service;
        private INoteAppService remoteModel;

        public SyncBookService(String key, INoteAppService service, INoteAppService remoteModel)
            : base(key, service)
        {
            this.service = service;
            this.remoteModel = remoteModel;
        }

        public override void delete(String key)
        {
            var book = base.get(key);
            base.delete(key);
           // PrimaryKeyTranslator.translate(book);
            remoteModel.bookService.delete(book.Id);            
        }

        public override Notebook add(Notebook e)
        {
            var userId = e.UserId;
            e.User = null;
            base.add(e);
          //  PrimaryKeyTranslator.translate(e);
            e.UserId = userId;
            e.User = null;
            var result = remoteModel.bookService.add(e);
          //  PrimaryKeyTranslator.translate(result);
            base.update(result);
            return result;
        }

        public override bool updateModified(Notebook book)
        {
            var result = false;
            Trace.Write("UpdateModified : New Note " + book.Id + "Before sync to local db");
            var dbBook = get(book.Id);
            if (dbBook == null)
            {
                book.User = null;
                var temp = book.Notes;
                book.Notes = null;
                base.add(book);
                book.Notes = temp;
                Trace.Write("Book " + book.name + "Synced to local db");
                result = true;
            }
            return result;
        }

        public override List<Notebook> getModified(long time, int userId)
        {
            Trace.Write("User id : " + userId);
            return remoteModel.bookService.getModified(time, userId);
        }
    }
}
