using System.ComponentModel.DataAnnotations;

namespace DoggySitter.Models
{
    public class Branch
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }

        private Branch(long Id, string Name, string Address, string OpeningHours)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.OpeningHours = OpeningHours;
        }

        private Branch()
        {
        }

        public static Branch of(long Id, string Name, string Address, string OpeningHours)
        {
            return new Branch(Id, Name, Address, OpeningHours);
        }

        public static Branch of()
        {
            return new Branch();
        }
    }
}
