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
    public class UserService : DataService<User, int>
    {
        public UserService(String key) : base(key)
        {

        }

        public override void update(User user)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                ctx.update<User>(user, u => u.name, u => u.Notebooks);
            }    
        }
    }
}
