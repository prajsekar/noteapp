﻿using Appnote.Core.Model.Entity;
using Appnote.Core.Persistence;
using NoteApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public class NoteService : INoteAppService
    {
        public static String RepositoryKey { get; set; }
        private static String _key;
        
        public NoteService()
        {
            _key = RepositoryKey;
        }

        public NoteService(String repositoryKey)
        {
            _key = repositoryKey;
        } 

        public void addUser(User user)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                ctx.add<User>(user);
            }
        }

        public void addNote(Note note)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                ctx.add<Note>(note);
            }       
        }

        public void updateNote(Note note)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {  
                ctx.update<Note>(note, n => n.title, n => n.content);                
            }
        }

        public void updateNoteBook(Notebook book)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                {
                    ctx.update<Notebook>(book, b => b.name);                    
                }
            }
        }

        public void createNotebook(Notebook book)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                ctx.add<Notebook>(book);
            }
        }


        public void deleteNoteBook(Notebook book)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                ctx.delete<Notebook>(book);
            }
        }

        public List<Note> findNotes(String str)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                var result = ctx.getDataSet<Note>().Where<Note>(n => (n.title.Contains(str) || n.content.Contains(str)));
                return result.ToList();
            }
        }

        public List<Note> getNotesModified(long time) 
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                var result = ctx.getDataSet<Note>().Where<Note>(n => (n.updated > time));
                return result.ToList();
            }
        }

        public List<Notebook> getNoteBookModified(long time)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(_key))
            {
                var result = ctx.getDataSet<Notebook>().Where<Notebook>(n => (n.updated > time));
                return result.ToList();
            }
        }
    }
}
