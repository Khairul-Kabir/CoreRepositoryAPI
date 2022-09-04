using System;
using System.Collections.Generic;

namespace DataAccessEF.EF.EntityModel
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int Address { get; set; }
        public int Email { get; set; }

        public virtual Address AddressNavigation { get; set; } = null!;
        public virtual Email EmailNavigation { get; set; } = null!;
    }
}
