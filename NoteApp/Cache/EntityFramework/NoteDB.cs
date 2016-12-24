using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Data;
using Appnote.Core.Persistence;
using Appnote.Core.Model.Entity;
using Appnote.Core.Model;

namespace Cache.EntityFramework
{
    public class NoteDB : DbContext, IRepository
    {
        public NoteDB(String connectionString) :
            base(connectionString)
        {

        }

        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StoreInfo> storeInfoes { get; set; }

        public T add<T>(T obj) where T : class
        {
            T result = null;
            try
            {
                if (obj is IUpdateTimeRequired)
                {
                    var timeUpdatedEntry = (IUpdateTimeRequired)obj;
                    var time = DateTime.Now.Ticks;
                    timeUpdatedEntry.updateCreationTime(time);
                    timeUpdatedEntry.updateModifiedTime(time);
                }
                result = Set<T>().Add(obj);
                SaveChanges();
            }
            catch (UpdateException ex)
            {
                throw new NoteAppDataException(String.Format("Error creating new {0} entry", typeof(T).FullName), ex, "DuplicateEntryError");
            }
            catch (DataException ex)
            {
                throw new NoteAppDataException(String.Format("Error creating new {0} entry", typeof(T).FullName), ex, "DataError");
            }
            return result;
        }

        public void update<T>(T obj, params System.Linq.Expressions.Expression<Func<T, object>>[] propertiesToUpdate) where T : class
        {
            try
            {                
                Set<T>().Attach(obj);
                if (typeof(T) is IUpdateTimeRequired)
                {
                    var timeUpdatedEntry = (IUpdateTimeRequired)obj;
                    timeUpdatedEntry.updateModifiedTime(DateTime.Now.Ticks);                    
                    Entry(obj).Property("updated").IsModified = true;
                }
                propertiesToUpdate.ToList().ForEach(p => Entry(obj).Property(p).IsModified = true);
                SaveChanges();
            }
            catch (EntityException ex)
            {
                throw new NoteAppDataException(String.Format("Error updating {0} entry", typeof(T).FullName), ex);
            }
        }

        public void delete<T>(T obj) where T : class
        {
            Set<T>().Remove(obj);
            SaveChanges();
        }

        public T get<T, K>(K id) where T : class
        {
            return Set<T>().Find(id);
        }

        public IQueryable<T> getDataSet<T>() where T : class
        {
            return Set<T>();
        }

        public Task<T> getAsync<T, K>(K id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> updateAsync<T>(T obj, params System.Linq.Expressions.Expression<Func<T, object>>[] propertiesToUpdate) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> deleteAsync<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> getDatasetAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> addAsync<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
