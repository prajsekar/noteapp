namespace Appnote.Core.Model.Entity 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class User
    {
        public User()
        {
            this.Notebooks = new HashSet<Notebook>();
        }
        
        public int Id { get; set; }
        public string name { get; set; }
        [Index(IsUnique = true)]
        public string mail { get; set; }        

        public virtual ICollection<Notebook> Notebooks { get; set; }
    }
}
