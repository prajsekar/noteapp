using NoteApp.Core.Model.Entity;
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
    public partial class MainForm : Form, MainView, NoteObserver
    {
        public MainForm(bool oneWaySync )
        {
            Init(oneWaySync);
        }
        
        public MainForm()
        {
            Init(false);            
        }

        private void Init(bool oneWaySync)
        {
            InitializeComponent();
            this.oneWaySync = oneWaySync;
            var service = NoteApp.Application.NoteApplication.GetService(oneWaySync);
            presenter = new NoteAppPresenter(this, service);
            bookCreatedBtn.Click += new System.EventHandler(this.onAddBook);
            this.newBookNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            removeCreateBookPanel();
            handleZeroBook();
            addBookBtn.Text = "\u002B";
            addNoteBtn.Text = "\u002B";
            bookCreatedBtn.Text = "\uD83D\uDCBE";
            closeBookCreate.Text = "\u2715";
            searchBtn.Text = "\uD83D\uDD0D";
            notebookViewControl1.setObserver(this);
            bookCount = 0;
            noteCount = 0;
            setMode(oneWaySync);
        }

        private bool oneWaySync = false;
        private NoteAppPresenter presenter;
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => this._setNotebooks(books)));
                return;
            }
            else
            {
                _setNotebooks(books);
            }
        }

        public void _setNotebooks(List<Notebook> books)
        {
            if (books != null && books.Count > 0)
            {
                clearPanel(notebookStackPanel);
                foreach (var book in books)
                {
                    addBookToPanel(book);
                }
                setSelectedBook(this, books[0]);
                revertZeroBook();
            }
        }

       

        private bool addBookToPanel(Notebook book, bool update = false)
        {   
            NotebookControl control = null;
            var valid = true;
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
                valid = false;
            }
            else if (update)
            {
                noteCount -= control.activeBook.Notes.Count;
                control.activeBook = book;
                noteCount += book.Notes.Count;
            }
            return valid;
        }

        private void onAddBook(object sender, EventArgs args)
        {
            addNoteBtn.Show();
            var ticks = DateTime.Now.Ticks;
            var name = newBookNameTxt.Text;
            newBookNameTxt.Text = "";
            removeCreateBookPanel();
            var book = new Notebook() { Id = String.Empty, name = name, created = ticks, updated = ticks };
            if (addBookToPanel(book))
            {               
                if (this.onBookCreated != null)
                {
                    this.onBookCreated(this, book);
                }
                if (notebookStackPanel.Controls.Count == 1)
                {
                    setSelectedBook(this, book);
                    revertZeroBook();
                }
            }
        }
        private bool zeroBook = true;

        public void setSelectedNote(object sender, Note note)
        {
           //TODO remove this method
        }

        private long currentBook;
        public void setSelectedBook(object sender, Notebook notebook)
        {
            currentBook = notebook.created;
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
                note.updated = DateTime.Now.Ticks;
                this.onNoteUpdated(this, note);
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
                setSelectedBook(this, bookControlMap[bookControlMap.Keys.ToArray()[0]].activeBook);
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
        public event EventHandler<string> onSearch;
        public event EventHandler<EventArgs> LoadForm;

        public void setSearchResults(List<Note> notes)
        {
            addNoteBtn.Hide();
            notebookViewControl1.setSearchResult(notes, searchTxtBox.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchTxt = searchTxtBox.Text;
            if (this.onSearch != null && searchTxt != "")
            {
                this.onSearch(sender, searchTxt);
            }
            //var time = DateTime.Now.Ticks;
            //var notes = new List<Note>();
            //for(var i = 0; i < 5; i++) {
            //    notes.Add(new Note() {
            //        Id = i, 
            //        created = DateTime.Now.Ticks + i, 
            //        title = "Note" + i,
            //        content = "Content" + i,
            //        Notebook = new Notebook() {
            //            Id = i,
            //            name = "Book" + 1
            //        }
            //    });
            //}
            //setSearchResults(notes); 
        }


        public void setSyncStart()
        {
            syncStatusLbl.Text = "In Progress";
            syncStatusLbl.ForeColor = System.Drawing.Color.Yellow;
        }

        public void setSearchEnd()
        {
            syncStatusLbl.Text = "Complete";
            syncStatusLbl.ForeColor = System.Drawing.Color.YellowGreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.LoadForm != null)
            {
                this.LoadForm(sender, e);
            }
        }


        public void setNoteBook(Notebook book)
        {
            addNoteBtn.Show();            
            notebookViewControl1.activeBook = book;
        }

        

        public event EventHandler<Notebook> onBookSelected;


        public void setMode(bool isRemote)
        {
            if (isRemote)
            {
                this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
                appTitleLbl.Text = appTitleLbl.Text + " - Remote";
            }
            
        }


     
        public void setModified(List<ModifiedBook> books)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => this._setModified(books)));
                return;
            }
            else
            {
                _setModified(books);
            }
        }

        private void _setModified(List<ModifiedBook> books)
        {
            foreach (var book in books)
            {
                if (book.changeType == ModifiedBook.ChangeType.Create)
                {
                    addBookToPanel(book.source);
                    //Dont do anything here
                }
                else
                {
                    addNoteBtn.Show();
                    notebookViewControl1.setSelectedBook(book.source, true);                    
                }                
            }
        }

        private User _user; 
        public User user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
    }
}
