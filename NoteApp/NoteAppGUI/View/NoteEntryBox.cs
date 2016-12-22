using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMVP.View;
using Cache.Entity;
using NoteAppGUI.View;

namespace NoteAppGUI.View
{
    public partial class NoteEntryBox : UserControl
    {
        private Note _note;
        private Note note
        {
            get
            {
                _note.title = name;
                return _note;
            }
            set {
                _note = note;
                name = note.title;              
                created = new DateTime(note.created);
                id = note.Id;
            }
        }

        private string name { 
            get {
                return noteNameLbl.Text;
            }
            set {
                noteNameLbl.Text = value;
            }
        }

        private DateTime created
        {
            get
            {
                return DateTime.Parse(noteCreatedLbl.Text);
            }
            set
            {
                noteCreatedLbl.Text = value.ToString();
            }
        }


        private int id { get; set; }
        private NoteObserver observer { get; set; }

        public NoteEntryBox()
        {
            init();
        }

        public NoteEntryBox(Note note)
        {
            init();
            this.note = note;
        }

        public NoteEntryBox(NoteObserver observer, Note note)
        {
            init();
            this.note = note;
            this.observer = observer;
        }

        private void init() {
            InitializeComponent();  
            contentPanel.Click += new System.EventHandler(this.onNoteClicked);
            noteContentLbl.Click += new System.EventHandler(this.onNoteClicked);
            noteNameLbl.Click += new System.EventHandler(this.onNoteClicked);
            noteCreatedLbl.Click += new System.EventHandler(this.onNoteClicked);
        }

        private void onNoteClicked(object sender, EventArgs args)
        {
            if (observer != null)
            {
                observer.setSelectedNote(sender, note);
            }
            MessageBox.Show("Note clicked", "NoteClicked");
        }
    }
}
