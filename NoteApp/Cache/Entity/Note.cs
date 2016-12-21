namespace Cache.Entity
{
    using System;
    using System.Collections.Generic;

    public partial class Note : IUpdateTimeRequired
    {
        public int Id { get; set; }
        public string title { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime updated { get; set; }
        public string content { get; set; }
        public int NotebookId { get; set; }

        public virtual Notebook Notebook { get; set; }

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
