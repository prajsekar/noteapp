namespace Appnote.Core.Model.Entity 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Notebook : IUpdateTimeRequired
    {
        public Notebook()
        {
            this.Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string name { get; set; }
        public long created { get; set; }
        public long updated { get; set; }
        public int UserId { get; set; }
        public int secondaryId { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual User User { get; set; }

        public void updateCreationTime(long time)
        {
            this.created = time;
        }

        public void updateModifiedTime(long time)
        {
            this.updated = time;
        }
    }
}
