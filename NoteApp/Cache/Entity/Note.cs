namespace Cache.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Note : IUpdateTimeRequired
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string title { get; set; }
        public long created { get; set; }
        public long updated { get; set; }
        public string content { get; set; }
        public int NotebookId { get; set; }

        public virtual Notebook Notebook { get; set; }

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
