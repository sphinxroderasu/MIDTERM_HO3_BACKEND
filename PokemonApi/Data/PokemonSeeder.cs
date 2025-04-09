using PokemonApi.Data;
using PokemonApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace PokemonApi
{
    public static class PokemonSeeder
    {
        public static void SeedData(PokemonDbContext context)
        {
        
            var pokemonToAdd = new List<Pokemon>
            {
                new Pokemon { Name = "Bulbasaur", Type = "Grass", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Ivysaur", Type = "Grass", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Venusaur", Type = "Grass", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Charmander", Type = "Fire", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Charmeleon", Type = "Fire", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Charizard", Type = "Fire", SecondaryType = "Flying", Generation = 1 },
                new Pokemon { Name = "Squirtle", Type = "Water", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Wartortle", Type = "Water", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Blastoise", Type = "Water", SecondaryType = "", Generation = 1 },

                // Generation 1
                new Pokemon { Name = "Caterpie", Type = "Bug", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Metapod", Type = "Bug", SecondaryType = "", Generation = 1 },
                new Pokemon { Name = "Butterfree", Type = "Bug", SecondaryType = "Flying", Generation = 1 },
                new Pokemon { Name = "Weedle", Type = "Bug", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Kakuna", Type = "Bug", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Beedrill", Type = "Bug", SecondaryType = "Poison", Generation = 1 },
                new Pokemon { Name = "Pidgey", Type = "Normal", SecondaryType = "Flying", Generation = 1 },
                new Pokemon { Name = "Pidgeotto", Type = "Normal", SecondaryType = "Flying", Generation = 1 },
                new Pokemon { Name = "Pidgeot", Type = "Normal", SecondaryType = "Flying", Generation = 1 },

                // Generation 2
                new Pokemon { Name = "Chikorita", Type = "Grass", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Bayleef", Type = "Grass", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Meganium", Type = "Grass", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Cyndaquil", Type = "Fire", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Quilava", Type = "Fire", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Typhlosion", Type = "Fire", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Totodile", Type = "Water", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Croconaw", Type = "Water", SecondaryType = "", Generation = 2 },
                new Pokemon { Name = "Feraligatr", Type = "Water", SecondaryType = "", Generation = 2 },

                // Generation 3
                new Pokemon { Name = "Treecko", Type = "Grass", SecondaryType = "", Generation = 3 },
                new Pokemon { Name = "Grovyle", Type = "Grass", SecondaryType = "", Generation = 3 },
                new Pokemon { Name = "Sceptile", Type = "Grass", SecondaryType = "", Generation = 3 },
                new Pokemon { Name = "Torchic", Type = "Fire", SecondaryType = "", Generation = 3 },
                new Pokemon { Name = "Combusken", Type = "Fire", SecondaryType = "Fighting", Generation = 3 },
                new Pokemon { Name = "Blaziken", Type = "Fire", SecondaryType = "Fighting", Generation = 3 },
                new Pokemon { Name = "Mudkip", Type = "Water", SecondaryType = "Ground", Generation = 3 },
                new Pokemon { Name = "Marshtomp", Type = "Water", SecondaryType = "Ground", Generation = 3 },
                new Pokemon { Name = "Swampert", Type = "Water", SecondaryType = "Ground", Generation = 3 },

                // Generation 4
                new Pokemon { Name = "Turtwig", Type = "Grass", SecondaryType = "Ground", Generation = 4 },
                new Pokemon { Name = "Grotle", Type = "Grass", SecondaryType = "Ground", Generation = 4 },
                new Pokemon { Name = "Torterra", Type = "Grass", SecondaryType = "Ground", Generation = 4 },
                new Pokemon { Name = "Chimchar", Type = "Fire", SecondaryType = "Fighting", Generation = 4 },
                new Pokemon { Name = "Monferno", Type = "Fire", SecondaryType = "Fighting", Generation = 4 },
                new Pokemon { Name = "Infernape", Type = "Fire", SecondaryType = "Fighting", Generation = 4 },
                new Pokemon { Name = "Piplup", Type = "Water", SecondaryType = "", Generation = 4 },
                new Pokemon { Name = "Prinplup", Type = "Water", SecondaryType = "", Generation = 4 },
                new Pokemon { Name = "Empoleon", Type = "Water", SecondaryType = "Steel", Generation = 4 },

                // Generation 5
                new Pokemon { Name = "Snivy", Type = "Grass", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Servine", Type = "Grass", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Serperior", Type = "Grass", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Tepig", Type = "Fire", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Pignite", Type = "Fire", SecondaryType = "Fighting", Generation = 5 },
                new Pokemon { Name = "Emboar", Type = "Fire", SecondaryType = "Fighting", Generation = 5 },
                new Pokemon { Name = "Oshawott", Type = "Water", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Dewott", Type = "Water", SecondaryType = "", Generation = 5 },
                new Pokemon { Name = "Samurott", Type = "Water", SecondaryType = "", Generation = 5 },

                // Generation 6
                new Pokemon { Name = "Chespin", Type = "Grass", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Quilladin", Type = "Grass", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Chestnaught", Type = "Grass", SecondaryType = "Fighting", Generation = 6 },
                new Pokemon { Name = "Fennekin", Type = "Fire", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Braixen", Type = "Fire", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Delphox", Type = "Fire", SecondaryType = "Psychic", Generation = 6 },
                new Pokemon { Name = "Froakie", Type = "Water", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Frogadier", Type = "Water", SecondaryType = "", Generation = 6 },
                new Pokemon { Name = "Greninja", Type = "Water", SecondaryType = "Dark", Generation = 6 },

                // Generation 7
                new Pokemon { Name = "Rowlet", Type = "Grass", SecondaryType = "Flying", Generation = 7 },
                new Pokemon { Name = "Dartrix", Type = "Grass", SecondaryType = "Flying", Generation = 7 },
                new Pokemon { Name = "Decidueye", Type = "Grass", SecondaryType = "Ghost", Generation = 7 },
                new Pokemon { Name = "Litten", Type = "Fire", SecondaryType = "", Generation = 7 },
                new Pokemon { Name = "Torracat", Type = "Fire", SecondaryType = "", Generation = 7 },
                new Pokemon { Name = "Incineroar", Type = "Fire", SecondaryType = "Dark", Generation = 7 },
                new Pokemon { Name = "Popplio", Type = "Water", SecondaryType = "", Generation = 7 },
                new Pokemon { Name = "Brionne", Type = "Water", SecondaryType = "", Generation = 7 },
                new Pokemon { Name = "Primarina", Type = "Water", SecondaryType = "Fairy", Generation = 7 },

                // Generation 8
                new Pokemon { Name = "Grookey", Type = "Grass", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Thwackey", Type = "Grass", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Rillaboom", Type = "Grass", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Scorbunny", Type = "Fire", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Raboot", Type = "Fire", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Cinderace", Type = "Fire", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Sobble", Type = "Water", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Drizzile", Type = "Water", SecondaryType = "", Generation = 8 },
                new Pokemon { Name = "Inteleon", Type = "Water", SecondaryType = "", Generation = 8 },

                // Generation 9
                new Pokemon { Name = "Sprigatito", Type = "Grass", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Floragato", Type = "Grass", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Meowscarada", Type = "Grass", SecondaryType = "Dark", Generation = 9 },
                new Pokemon { Name = "Fuecoco", Type = "Fire", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Crocalor", Type = "Fire", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Skeledirge", Type = "Fire", SecondaryType = "Ghost", Generation = 9 },
                new Pokemon { Name = "Quaxly", Type = "Water", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Wugtrio", Type = "Water", SecondaryType = "", Generation = 9 },
                new Pokemon { Name = "Quaquaval", Type = "Water", SecondaryType = "Fighting", Generation = 9 }
            };

            
            foreach (var pokemon in pokemonToAdd)
            {
                if (!context.Pokemon.Any(p => p.Name == pokemon.Name))
                {
                    context.Pokemon.Add(pokemon);
                }
            }

            context.SaveChanges();
        }
    }
}