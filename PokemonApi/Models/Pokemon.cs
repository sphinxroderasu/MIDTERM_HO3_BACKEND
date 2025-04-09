namespace PokemonApi.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? SecondaryType { get; set; }
        public int Generation { get; set; }
    }
}
