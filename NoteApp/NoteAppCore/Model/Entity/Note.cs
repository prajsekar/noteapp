namespace NoteApp.Core.Model.Entity 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Note : IUpdateTimeRequired, ICloneable
    {
        [Key]
        public String Id { get; set; }        
        public string title { get; set; }
        public long created { get; set; }
        public long updated { get; set; }
        public string content { get; set; }
        public String NotebookId { get; set; }
        public String secondaryId { get; set; } 
       
        public virtual Notebook Notebook { get; set; }

        public void updateCreationTime(long time)
        {
            this.created = time;
        }

        public void updateModifiedTime(long time)
        {
            this.updated = time;
        }

        public Note()
        {

        }

        public Note(Note note)
        {
            this.Id = note.Id;
            this.Notebook = note.Notebook;
            this.NotebookId = note.NotebookId;
            this.secondaryId = note.secondaryId;
            this.title = note.title;
            this.updated = note.updated;
            this.created = note.created;
            this.content = note.content;
            this.Notebook = note.Notebook;
        }
        public object Clone()
        {
            return new Note(this);
        }
    }
}
