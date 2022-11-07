namespace React_Asp_Api.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BrithDate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwner { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
