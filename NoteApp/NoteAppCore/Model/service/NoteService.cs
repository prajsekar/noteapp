using Appnote.Core.Model.Entity;
using Appnote.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public class NoteService : DataService<Note, int>
    {
        public NoteService(String key) : base(key)
        {

        }

        public override void update(Note note)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                ctx.update<Note>(note, n => n.title, n => n.content, n=> n.secondaryId);
            }            
        }

        public List<Note> search(String str)
        {
            List<Note> result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                var query = ctx.getDataSet<Note>().Where<Note>(n => (n.title.Contains(str) || n.content.Contains(str)));
                result = query.ToList<Note>().Select<Note, Note>((n) => (Note)n.Clone()).ToList<Note>();                
            }
            return result;
        }

        public List<Note> getModified(long time)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                var result = ctx.getDataSet<Note>().Where<Note>(n => (n.updated > time));
                return result.ToList();
            }
        }
    }
}
