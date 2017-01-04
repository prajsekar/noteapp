using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NoteApp.Core.Model.Service
{
    public class NotebookService : DataService<Notebook, int>
    {
        private INoteAppService service;
        public NotebookService(String key, INoteAppService service)
            : base(key)
        {
            this.service = service;
        }

        public override void update(Notebook book)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                ctx.update<Notebook>(book, b => b.name, b => b.secondaryId);
            }    
        }

        public virtual List<Notebook> getModified(long time, int userId)
        {            
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                Trace.Write("Get modified : " + repoKey + "Time " + time);
                var query = ctx.getDataSet<Notebook>().Where<Notebook>(n => (n.updated > time) && (n.UserId == userId));
                return query.ToList<Notebook>().Select<Notebook, Notebook>((n) => (Notebook)n.Clone()).ToList<Notebook>();
            }
        }

        public List<Notebook> getAll(User user)
        {
            List<Notebook> result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                var query = ctx.getDataSet<Notebook>().Where<Notebook>(n => n.UserId == user.Id);
                result  = query.ToList<Notebook>().Select<Notebook, Notebook>((n) => (Notebook)n.Clone()).ToList<Notebook>();

            }
            return result;
        }

        public virtual bool updateModified(Notebook book)
        {
            return false;
        }

        public void setRemoteModified(Notebook book)
        {
            Notebook result = null;
            if (book.Id == 0)
            {
                book.User = null;
                result = this.add(book);
                book.Id = result.Id;
            }
            else
            {
                foreach (var note in book.Notes)
                {                    
                    if (note.Id == 0)
                    {
                        note.Notebook = null;
                        note.NotebookId = book.Id;
                        var dbNote = service.noteService.add(note);
                        note.Id = dbNote.Id;
                    }
                }
            }
            
        }
    }
}
