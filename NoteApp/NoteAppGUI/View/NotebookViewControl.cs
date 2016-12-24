using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppGUI.View;
using Cache.Entity;

namespace NoteApp.View
{
    public partial class NotebookViewControl : UserControl, NoteObserver
    {
        private MainForm observer;
        private Notebook _currentNote;
        private Dictionary<long, NoteEntryBox> noteEntryMap = new Dictionary<long, NoteEntryBox>();

        public NotebookViewControl()
        {
            init(null);            
        }

        public NotebookViewControl(NoteObserver observer)
        {
            init(observer);
        }

        public Notebook activeBook
        {
            get
            {
                _currentNote.Notes = new List<Note>();
                for (var i = 0; i < noteListPanel.Controls.Count; i++)
                {
                    var control = (NoteEntryBox)noteListPanel.Controls[i];
                    _currentNote.Notes.Add(control.activeNote);
                }
                return _currentNote;
            }
            set
            {
                if (_currentNote != null && _currentNote.name == value.name)
                {
                    return;
                }
                deleteBookBtn.Show();
                _currentNote = value;
                var notebook = value;
                this.notebookTitleLbl.Text = notebook.name;
                this.noteCreateTitleLbl.Text = new DateTime(notebook.created).ToString();
                noteEntryMap.Clear();
                setNotes(value.Notes);
            }
        }


        public void setObserver(NoteObserver observer)
        {
            if (observer is MainForm)
            {
                this.observer = (MainForm)observer;
            }
        }

        private void setNotes(ICollection<Note> notes){
            if (notes != null)
            {
                clearPanel(noteListPanel);
                foreach (var note in notes)
                {
                    addNoteControl(note);
                }
            }
        }

        private void addNoteControl(Note note, bool notify = false)
        {
            NoteEntryBox noteView = null;
            var noteFound = noteEntryMap.TryGetValue(note.created, out noteView);
            if(noteFound && !create)
            {
                noteView.content = note.content;
                noteView.title = note.title;
                removeCreateNotePanel();
                return;
            }
            
            noteView = new NoteEntryBox(this, note);
            noteListPanel.Controls.Add(noteView);
            noteEntryMap.Add(note.created, noteView);
            
            if (notify)
            {
                //TODO send note add to main window
            }
            removeCreateNotePanel();
        }

        private void addNote(Note note)
        {
            addNoteControl(note, true);
        }

        private void init(NoteObserver observer)
        {
            InitializeComponent();
            removeCreateNotePanel();
            if (observer is MainForm)
            {
                this.observer = (MainForm)observer;
            }
        }

        private void NotebookViewControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.deleteBookBtn.Text = "\uD83D\uDDD1";
            this.closeNoteBtn.Text = "\u2715";
            this.saveNoteBtn.Text = "\uD83D\uDCBE";
            this.deleteNoteBtn.Text = "\uD83D\uDDD1";
        }

        private void closeNoteBtn_Click(object sender, EventArgs e)
        {
            removeCreateNotePanel();
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
                noteListPanel.Height -= noteEditPanel.Height;
                noteContentTxt.Focus();
                noteEditPanel.Visible = true;
                crateNotePanelActive = true;
            }
        }

        public void AddNoteClicked()
        {
            if (crateNotePanelActive)
            {
                removeCreateNotePanel();
            }
            else
            {
                noteView = null;
            }
        }

        public void setSelectedNote(object sender, Cache.Entity.Note note)
        {
            noteView = note;
        }

        
        public void setSelectedBook(object sender, Cache.Entity.Notebook notebook)
        {
            throw new NotImplementedException();
        }

        private Note noteView
        {
            get
            {
                Note _note = null;
                if (noteSource == null)
                {
                    _note = new Note();
                    long ticks = DateTime.Now.Ticks;
                    _note.created = ticks;
                    _note.updated = ticks;
                    _note.Notebook = activeBook;
                }
                else
                {
                    _note = noteSource;
                }
                
                _note.content = noteContentTxt.Text;
                _note.title = noteTitleTxt.Text;
                
                return _note;
            }
            set
            {
                addCreateNotePanel();
                if (value != null)
                {
                    Note _note = value;
                    noteContentTxt.Text = _note.content;
                    noteTitleTxt.Text = _note.title;
                    hiddenIdLbl.Text = _note.Id.ToString();
                    bookNameLbl.Text = _note.Notebook.name;
                    create = false;
                    noteSource = value;
                }
                else
                {
                    noteSource = null;
                    noteContentTxt.Text = "";
                    noteTitleTxt.Text = "";
                    bookNameLbl.Text = activeBook.name;
                    hiddenIdLbl.Text = "-1";
                    create = true; ;
                }
            }
        }
        bool create = true;
        Note noteSource = null;
        private void clearPanel(Panel panel)
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
            }
            panel.Controls.Clear();
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {            
            var note = noteView;
            if (!create)
            {
                observer.noteUpdatedByUC(note);
            }
            else
            {
                observer.noteCreatedByUC(note);
            }
            addNote(note);
        }

        private void deleteNoteBtn_Click(object sender, EventArgs e)
        {
            NoteEntryBox noteBox = null;
            Note note = this.noteView;
            if (noteEntryMap.TryGetValue(note.created, out noteBox))
            {
                noteEntryMap.Remove(note.created);
                noteBox.Dispose();
                noteListPanel.Controls.Remove(noteBox);
                observer.noteDeletedByUC(note);
            }
            removeCreateNotePanel();
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            observer.bookDeletedByUC(activeBook);
        }

        public void setSearchResult(List<Note> notes, String searchKey)
        {
            notebookTitleLbl.Text = String.Format("Search results for \"{0}\"", searchKey);
            noteCreateTitleLbl.Text = "";
            deleteBookBtn.Hide();
            clearPanel(noteListPanel);
            noteEntryMap.Clear();
            foreach (var note in notes)
            {
                addNoteControl(note);
            }
        }
    } 
}
