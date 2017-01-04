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
    public class NoteService : DataService<Note, int>
    {
        private INoteAppService service;
        public NoteService(String key, INoteAppService service)
            : base(key)
        {
            this.service = service;
        }

        public override void update(Note note)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                ctx.update<Note>(note, n => n.title, n => n.content, n=> n.secondaryId, n=> n.updated);
            }            
        }

        public List<Note> search(String str)
        {
            List<Note> result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                var query = ctx.getDataSet<Note>().Where<Note>(n => (n.title.Contains(str) || n.content.Contains(str)));
                result = query.ToList<Note>().Select<Note, Note>((n) => (Note)n.Clone()).ToList<Note>();                
            }
            return result;
        }

        public virtual List<Note> getModified(long time,int userId)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {                
                var result = ctx.getDataSet<Note>().Where<Note>(n => (n.updated > time) && (n.Notebook.UserId == userId));
                return result.ToList<Note>().Select<Note, Note>((n) => (Note)n.Clone()).ToList<Note>();
                
            }
        }

        public virtual bool updateModified(Note note)
        {
            return false;
        }
    }
}
