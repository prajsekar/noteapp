using NoteApp.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public class NoteAppService : INoteAppService
    {
        public static String RepositoryKey { get; set; }
        private String key;
        
        public NoteAppService()
        {
            key = RepositoryKey;
            initServices();
        }

        public NoteAppService(String repositoryKey)
        {
            key = repositoryKey;
            initServices();
        } 

        private void initServices()
        {
            noteService = new NoteService(key, this);
            bookService = new NotebookService(key, this);
            userService = new UserService(key, this);
        }
        
        public NoteService noteService {get; protected set;}               
        public NotebookService bookService { get; protected set; }
        public UserService userService { get; protected set; }

        private User _user;
        virtual public User user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
    }
}
