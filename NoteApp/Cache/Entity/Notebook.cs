namespace Cache.Entity
{
    using System;
    using System.Collections.Generic;

    public partial class Notebook : IUpdateTimeRequired
    {
        public Notebook()
        {
            this.Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime updated { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual User User { get; set; }

        public void updateCreationTime(DateTime time)
        {
            this.created = time;
        }

        public void updateModifiedTime(DateTime time)
        {
            this.updated = time;
        }
    }
}
