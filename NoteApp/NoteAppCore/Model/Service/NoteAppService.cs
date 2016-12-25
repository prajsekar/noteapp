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
        
        public NoteService noteService {get; private set;}               
        public NotebookService bookService { get; private set; }
        public UserService userService { get; private set; }
    }
}
