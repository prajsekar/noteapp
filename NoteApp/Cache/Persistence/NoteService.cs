using Cache.Entity;
using Cache.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Persistence
{
    public class NoteService
    {        
        public static void addUser(User user)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                ctx.add<User>(user);
            }
        }

        public static void addNote(Note note)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                ctx.add<Note>(note);
            }       
        }

        public static void updateNote(Note note)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {  
                ctx.update<Note>(note, n => n.title, n => n.content);                
            }
        }

        public static void updateNoteBook(Notebook book)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                {
                    ctx.update<Notebook>(book, b => b.name);                    
                }
            }
        }

        public static void createNotebook(Notebook book)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                ctx.add<Notebook>(book);
            }
        }


        public static void deleteNoteBook(Notebook book)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                ctx.delete<Notebook>(book);
            }
        }

        public static void note(Note note)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                ctx.add<Note>(note);                
            }
        }

        public static List<Note> findNotes(String str)
        {
            using (var ctx = DataStoreFactory.getRepository())
            {
                var result = ctx.getDataSet<Note>().Where<Note>(n => (n.title.Contains(str) || n.content.Contains(str)));
                return result.ToList();
            }
        }
    }
}
