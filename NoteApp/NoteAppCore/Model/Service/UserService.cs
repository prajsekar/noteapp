using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public class UserService : DataService<User, int>
    {

        private NoteAppService service;
        public UserService(String key, NoteAppService service)
            : base(key)
        {
            this.service = service;
        }
       
        public override void update(User user)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                ctx.update<User>(user, u => u.name, u => u.Notebooks);
            }    
        }

        public User validate(User user)
        {
            User dbUser = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                dbUser = ctx.getDataSet<User>().SingleOrDefault<User>(u => String.Equals(u.mail,user.mail));
                if (dbUser == null)
                {
                    dbUser = this.add(user);     
                }
                return dbUser;
            }   
        }
    }
}
