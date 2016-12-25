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
    public class NotebookService : DataService<Notebook, int>
    {
        public NotebookService(String key)
            : base(key)
        {

        }

        public override void update(Notebook book)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                ctx.update<Notebook>(book, b => b.name, b => b.secondaryId, b => b.Notes, b=> b.User);
            }    
        }

        public List<Notebook> getModified(long time)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                var result = ctx.getDataSet<Notebook>().Where<Notebook>(n => (n.updated > time));
                return result.ToList();
            }
        }

        public List<Notebook> getAll(User user)
        {
            List<Notebook> result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                var query = ctx.getDataSet<Notebook>().Where<Notebook>(n => n.UserId == user.Id);
                result  = query.ToList<Notebook>().Select<Notebook, Notebook>((n) => (Notebook)n.Clone()).ToList<Notebook>();

            }
            return result;
        }
    }
}
