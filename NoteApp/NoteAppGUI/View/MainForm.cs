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
            removeCreateBookPanel();
            removeCreateNotePanel();
            deleteBookBtn.Text = "\uD83D\uDDD1";
            addBookBtn.Text = "\u002B";
            addNoteBtn.Text = "\u002B";
            deleteNoteBtn.Text = "\uD83D\uDDD1";
            closeNoteBtn.Text = "\u2715";
            saveNoteBtn.Text = "\uD83D\uDCBE";
            noteCreatedBtn.Text = "\uD83D\uDCBE";
            closeBookCreate.Text = "\u2715";
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
                
        private bool createBookPanelActive = true;
        private void removeCreateBookPanel() {
            if (createBookPanelActive)
            {
                createBookConfirmPanel.Visible = false;
                notebookStackPanel.Height += createBookConfirmPanel.Height;
                createBookPanelActive = false;
            }
        }

        private void addCreateBookPanel()
        {
            if (!createBookPanelActive)
            {
                //leftPanel.Controls.Add(createBookConfirmPanel);
                notebookStackPanel.Height -= createBookConfirmPanel.Height;
                newBookNameTxt.Focus();
                createBookConfirmPanel.Visible = true;
                createBookPanelActive = true;
            }
        }

        private bool crateNotePanelActive = true;
        private void removeCreateNotePanel()
        {
            if (crateNotePanelActive)
            {
                noteEditPanel.Visible = false;
                noteListPanel.Height += noteEditPanel.Height;
                crateNotePanelActive = false;
            }
        }

        private void addCreateNotePanel()
        {
            if (!crateNotePanelActive)
            {
                //leftPanel.Controls.Add(createBookConfirmPanel);
                noteListPanel.Height -= noteEditPanel.Height;
                noteContentTxt.Focus();
                noteEditPanel.Visible = true;
                crateNotePanelActive = true;
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
            removeCreateBookPanel();
            var book = new Notebook() { Id = 1, name = name, created = ticks, updated = ticks };
            this.notebookStackPanel.Controls.Add(new NotebookControl(this, book));
            if (notebookStackPanel.Controls.Count == 1)
            {
                setSelectedBook(this, book);
            }

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

      
        private void closeNoteBtn_Click(object sender, EventArgs e)
        {
            removeCreateNotePanel();
        }

        private void addNoteBtn_Click_1(object sender, EventArgs e)
        {
            if (crateNotePanelActive)
            {
                removeCreateNotePanel();
            }
            else
            {
                addCreateNotePanel();
            }
        }

        private void addBookBtn_Click_1(object sender, EventArgs e)
        {
            if(!createBookPanelActive) 
            {
                addCreateBookPanel();
            }
            else 
            {
                removeCreateBookPanel();
            }
        }

        private void closeBookCreate_Click(object sender, EventArgs e)
        {
            removeCreateBookPanel();
        }

        private Note editPanelNote
        {
            get
            {
                return new Note() { title = noteTitleTxt.Text };
            }
            set
            {

            }
        }
    }
}
