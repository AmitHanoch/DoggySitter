namespace DoggySitter.Models
{
    public class Branch
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }

        public Branch(long Id, string Name, string Address, string OpeningHours)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.OpeningHours = OpeningHours;
        }
    }
}
