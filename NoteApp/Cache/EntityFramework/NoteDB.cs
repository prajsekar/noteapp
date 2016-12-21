using Cache.Entity;
using Cache.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using CacheCodeFirst.Persistence;

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

        public T add<T>(T obj) where T : class
        {
            T result = null;
            try
            {
                result = Set<T>().Add(obj);
                SaveChanges();
            }
            catch (EntityException ex)
            {
                throw new NoteCacheException(String.Format("Error creating new {0} entry", typeof(T).FullName), ex);
            }
            return result;
        }

        public void update<T>(T obj, params System.Linq.Expressions.Expression<Func<T, object>>[] propertiesToUpdate) where T : class
        {
            try
            {
                Set<T>().Attach(obj);
                propertiesToUpdate.ToList().ForEach(p => Entry(obj).Property(p).IsModified = true);
                SaveChanges();
            }
            catch (EntityException ex)
            {
                throw new NoteCacheException(String.Format("Error updating {0} entry", typeof(T).FullName), ex);
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
    }
}
