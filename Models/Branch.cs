namespace DoggySitter.Models
{
    public class Branch
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Branch(long Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
