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
            handleZeroBook();
            addBookBtn.Text = "\u002B";
            addNoteBtn.Text = "\u002B";
            noteCreatedBtn.Text = "\uD83D\uDCBE";
            closeBookCreate.Text = "\u2715";
            notebookViewControl1.setObserver(this);
            bookCount = 0;
            noteCount = 0;
        }
        private Dictionary<String, NotebookControl> bookControlMap = new Dictionary<String, NotebookControl>();
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
                notebookStackPanel.Height -= createBookConfirmPanel.Height;
                newBookNameTxt.Focus();
                createBookConfirmPanel.Visible = true;
                createBookPanelActive = true;
            }
        }

        private void handleZeroBook()
        {
            if (zeroBook)
            {
                addNoteBtn.Hide();
                notebookViewControl1.Hide();
                zeroBook = false;
            }
        }

        private void revertZeroBook()
        {
            if (!zeroBook)
            {
                addNoteBtn.Show();
                notebookViewControl1.Show();
                zeroBook = true;
            }
        }

        public string userName
        {
            get
            {
                return userNameLbl.Text;
            }
            set
            {
                userNameLbl.Text = value;
            }
        }

        public int noteCount
        {
            get
            {
                return Int32.Parse(noteCountLbl.Text);
            }
            set
            {
                noteCountLbl.Text = value.ToString();
            }
        }

        public int bookCount
        {
            get
            {
                return Int32.Parse(bookCountLbl.Text);
            }
            set
            {
                bookCountLbl.Text = value.ToString();
            }
        }

        public void setNotebooks(List<Notebook> books)
        {
            clearPanel(notebookStackPanel);            
            foreach (var book in books)
            {
                addBookToPanel(book);                
            }
            setSelectedBook(this, books[0]);
            revertZeroBook();
        }

       

        private void addBookToPanel(Notebook book, bool update = false)
        {   
            NotebookControl control = null;            
            var valFound = bookControlMap.TryGetValue(book.name, out control);
            if (!valFound)
            {
                control = new NotebookControl(this, book);
                bookControlMap.Add(book.name, control);
                bookCount++;
                noteCount += book.Notes.Count;
                notebookStackPanel.Controls.Add(control);
            }
            if (valFound && !update)
            {
                MessageBox.Show("Note already exists, please try unique name", "Error");
            }
            else if (update)
            {
                noteCount -= control.activeBook.Notes.Count;
                control.activeBook = book;
                noteCount += book.Notes.Count;
            }
        }

        private void onAddBook(object sender, EventArgs args)
        {
            var ticks = DateTime.Now.Ticks;
            var name = newBookNameTxt.Text;
            newBookNameTxt.Text = "";
            removeCreateBookPanel();
            var book = new Notebook() { Id = -1, name = name, created = ticks, updated = ticks };
            addBookToPanel(book); 
            if (notebookStackPanel.Controls.Count == 1)
            {
                setSelectedBook(this, book);
                revertZeroBook();
            }
            if (this.onBookCreated != null)
            {
                this.onBookCreated(this, book);
            }
        }
        private bool zeroBook = true;

        public void setSelectedNote(object sender, Note note)
        {
           //TODO remove this method
        }

        public void setSelectedBook(object sender, Notebook notebook)
        {            
            notebookViewControl1.activeBook = notebook;
        }

        private void clearPanel(Panel panel)
        {
            while (panel.Controls.Count > 0) {
                panel.Controls[0].Dispose();
            }
            panel.Controls.Clear();
        }
        
        private void addNoteBtn_Click_1(object sender, EventArgs e)
        {
            notebookViewControl1.AddNoteClicked();
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

        public void noteDeletedByUC(Note note)
        {
            if (this.onNoteDeleted != null)
            {
                this.onNoteDeleted(this, note);
            }
            noteCount--;
        }

        public void noteCreatedByUC(Note note)
        {
            noteCount++;
            if (this.onNoteCreated != null)
            {
                this.onNoteCreated(this, note);
            }
        }

        public void noteUpdatedByUC(Note note)
        {   
            if (this.onNoteUpdated != null)
            {
                this.onNoteDeleted(this, note);
            }
        }       

        public void bookDeletedByUC(Notebook book)
        {
            NotebookControl _bookControl = null;
            if (bookControlMap.TryGetValue(book.name, out _bookControl))
            {
                bookControlMap.Remove(book.name);
                bookCount--;
                noteCount -= book.Notes.Count;
                notebookStackPanel.Controls.Remove(_bookControl);
                _bookControl.Dispose();
            }
            if (bookControlMap.Count == 0)
            {
                handleZeroBook();
            }
            else
            {
                notebookViewControl1.activeBook = bookControlMap[bookControlMap.Keys.ToArray()[0]].activeBook;
            }
            if (this.onBookDeleted != null)
            {
                this.onBookDeleted(this, book);
            }
        }


        public void updateNotebook(Notebook book)
        {
            addBookToPanel(book, true);
        }

        public void updateNoteBooks(List<Notebook> books)
        {
            foreach (var book in books)
            {
                addBookToPanel(book, true);
            }
        }

        public event EventHandler<Notebook> onBookDeleted;
        public event EventHandler<Note> onNoteDeleted;
        public event EventHandler<Note> onNoteUpdated;
        public event EventHandler<Notebook> onBookCreated;
        public event EventHandler<Note> onNoteCreated;
    }
}
