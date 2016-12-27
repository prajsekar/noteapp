using NoteMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteMVP.Presenter
{
    public class LoginPresenter
    {
        private LoginView view;
        public LoginPresenter(LoginView view)
        {
            this.view = view;
            this.view.onLogin += onUserLogin;
        }

        private void onUserLogin(object sender, EventArgs e)
        {
           Console.WriteLine("Somethinsg", "something");
        }
    }
}
