using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMVC.View
{
    public interface LoginView
    {
        String UserName { get; set; }
        String Password { get; set; }

        event EventHandler<EventArgs> onLogin;
    }
}
