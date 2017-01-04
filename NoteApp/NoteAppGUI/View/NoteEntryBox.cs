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
using NoteApp.Core.Model.Entity;
using NoteAppGUI.View;

namespace NoteAppGUI.View
{
    public partial class NoteEntryBox : UserControl
    {
        private Note _note;
        public Note activeNote
        {
            get
            {
                _note.title = title;
                _note.content = content;
                return _note;
            }
            set {
                _note = value;
                title = value.title;              
                created = new DateTime(value.created);
                content = value.content;
                id = value.Id;
            }
        }

        public string title { 
            get {
                return noteNameLbl.Text;
            }
            set {
                noteNameLbl.Text = value;
            }
        }

        public string content
        {
            get
            {
                return noteContentLbl.Text;
            }
            set
            {
                noteContentLbl.Text = value;
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


        private String id { get; set; }
        private NoteObserver observer { get; set; }

        public NoteEntryBox()
        {
            init();
        }

        public NoteEntryBox(Note note)
        {
            init();
            this.activeNote = note;
        }

        public NoteEntryBox(NoteObserver observer, Note note)
        {
            init();
            this.activeNote = note;
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
                observer.setSelectedNote(sender, activeNote);
            }            
        }
    }
}
