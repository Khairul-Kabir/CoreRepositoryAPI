using System;
using System.Collections.Generic;

namespace DataAccessEF.EF.EntityModel
{
    public partial class Email
    {
        public Email()
        {
            People = new HashSet<Person>();
        }

        public int EmailId { get; set; }
        public string? EmailAdress { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
