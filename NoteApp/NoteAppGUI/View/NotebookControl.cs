using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cache.Entity;
using NoteAppGUI.View;

namespace NoteAppGUI.View
{
    public partial class NotebookControl : UserControl
    {
        private Notebook _book;
        private NoteObserver observer;
        private Notebook book {
            get
            {
                return _book;
            }
            set
            {
                bookNameLbl.Text = value.name;
                _book = value;
            }
        }
        public NotebookControl()
        {
            init();
        }

        public NotebookControl(NoteObserver observer)
        {
            init();
            this.observer = observer;
        }

        public NotebookControl(NoteObserver observer, Notebook book)
        {
            init();
            this.book = book;
            this.observer = observer;
        }        

        private void init() 
        {
            InitializeComponent();
            bookPanel.Click += new System.EventHandler(onPanelClick);
            bookNameLbl.Click += new System.EventHandler(onPanelClick);
            noteIconLbl.Text = "\uD83D\uDDD2";
        }

        private void onPanelClick(object sender, EventArgs e)
        {
            if (observer != null)
            {
                observer.setSelectedBook(sender, this.book);
            }            
        }
    }
}
