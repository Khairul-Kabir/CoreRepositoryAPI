namespace Domain
{
    public class PersonVM
    {
        public int PersonId { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int Address { get; set; }
        public int Email { get; set; }

        public virtual AddressVM AddressNavigation { get; set; } = null!;
        public virtual EmailVM EmailNavigation { get; set; } = null!;
    }
}
