namespace React_Asp_Api.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owmers { get; set; }
    }
}
