using System;
using System.Collections.Generic;

namespace DataAccessEF.EF.EntityModel
{
    public partial class Address
    {
        public Address()
        {
            People = new HashSet<Person>();
        }

        public int AddressId { get; set; }
        public string? StreetAdress { get; set; }
        public string City { get; set; } = null!;
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
