using NoteMVP.Presenter;
using NoteMVP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppGUI.View
{
    public partial class LoginForm : Form, LoginView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            InitEventHandlers();
            presenter = new LoginPresenter(this);
            
        }
              
        public string UserName
        {
            get
            {
                return userNameTxt.Text;
            }
            set
            {
                userNameTxt.Text = value;
            }
        }

        //Skiped implementing authentication
        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private void InitEventHandlers()
        {
            loginBtn.Click += new System.EventHandler(this.loginBtnClicked);
        }

        private void loginBtnClicked(object sender, EventArgs e)
        {
            if (this.onLogin != null)
            {
                this.onLogin(sender, e);
            }
        }
        public event EventHandler<EventArgs> onLogin;
    }
}
