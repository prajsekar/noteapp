using NoteMVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppGUI
{
    public partial class MainForm : Form, MainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string userName
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

        public string noteCount
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

        public string bookCount
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

        public void setNotebooks(List<Cache.Entity.Notebook> books)
        {
            throw new NotImplementedException();
        }

        public void setNotes(List<Cache.Entity.Note> notes)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> onNoteSelected;

        public event EventHandler<EventArgs> onBookSelected;

        public event EventHandler<EventArgs> onBookCreated;

        public event EventHandler<EventArgs> onNoteCreated;
    }
}
