using Cache.Entity;
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
    public partial class MainForm : Form, MainView, NoteObserver
    {
        public MainForm()
        {
            InitializeComponent();
            noteCreatedBtn.Click += new System.EventHandler(this.onAddBook);
            this.newBookNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            removeCreatePanel();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (newBookNameTxt.Text != "")
                {
                    onAddBook(sender, e);
                }
            }
        }
        private bool createPanelActive = true;
        private void removeCreatePanel() {
            if (createPanelActive)
            {
                leftPanel.Controls.RemoveAt(1);
                notebookStackPanel.Height += createBookConfirmPanel.Height;
                createPanelActive = false;
            }
        }

        private void addCreatePanel()
        {
            if (!createPanelActive)
            {
                leftPanel.Controls.Add(createBookConfirmPanel);
                notebookStackPanel.Height -= createBookConfirmPanel.Height;
                newBookNameTxt.Focus();
                createPanelActive = true;
            }
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

        public void setNotebooks(List<Notebook> books)
        {
            clearPanel(notebookStackPanel);            
            foreach (var book in books)
            {
                notebookStackPanel.Controls.Add(new NotebookControl(this, book));
            }
            setSelectedBook(this, books[0]);
        }

        private void onAddBook(object sender, EventArgs args)
        {
            var ticks = DateTime.Now.Ticks;
            var name = newBookNameTxt.Text;
            newBookNameTxt.Text = "";
            removeCreatePanel();
            this.notebookStackPanel.Controls.Add(new NotebookControl(this, new Notebook() { Id = 1, name = name, created = ticks, updated = ticks }));            
        }

        public void setNotes(List<Cache.Entity.Note> notes)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<Note> onNoteSelected;

        public event EventHandler<Notebook> onBookSelected;

        public event EventHandler<EventArgs> onBookCreated;

        public event EventHandler<EventArgs> onNoteCreated;

        public void setSelectedNote(object sender, Note note)
        {
            if (this.onNoteSelected != null)
            {
                this.onNoteSelected(sender, note);
            } 
        }


        public void setSelectedBook(object sender, Notebook notebook)
        {
            SetBookAreaTitle(notebook);
            if (this.onBookSelected != null)
            {
                this.onBookSelected(sender, notebook);
            } 
        }

        private void clearPanel(Panel panel)
        {
            while (panel.Controls.Count > 0) {
                panel.Controls[0].Dispose();
            }
            panel.Controls.Clear();
        }

        private void SetBookAreaTitle(Notebook notebook)
        {
            this.notebookTitleLbl.Text = notebook.name;
            this.noteCreateTitleLbl.Text = new DateTime(notebook.created).ToString();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addCreatePanel();
        }
    }
}
