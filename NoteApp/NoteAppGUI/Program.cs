using NoteAppGUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Application;
using System.Diagnostics;
namespace NoteAppGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            //Bootstrap recipe for windows client
            Debug.Write("App started..");
            var remoteMock = args.Length > 0 && args[0] == "remote";
            NoteApplication.bootstrapWinClient(remoteMock);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(remoteMock));
        }
    }
}
