using NoteMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMVC.Presenter
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
            MessageBox.Show("Somethinsg", "something");
        }
    }
}
