namespace Cache.Entity
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        public User()
        {
            this.Notebooks = new HashSet<Notebook>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }        

        public virtual ICollection<Notebook> Notebooks { get; set; }
    }
}
