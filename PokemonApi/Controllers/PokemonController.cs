using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonApi.Data;
using PokemonApi.Models;

namespace PokemonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonDbContext _context;

        public PokemonController(PokemonDbContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon([FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize > 50) pageSize = 50;
                if (pageSize < 1) pageSize = 20;

                var totalCount = await _context.Pokemon.CountAsync();

                if (totalCount == 0)
                {
                    Response.Headers.Add("X-Total-Count", "0");
                    Response.Headers.Add("X-Total-Pages", "0");
                    return new List<Pokemon>();
                }

                var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
                var pokemon = await _context.Pokemon
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                Response.Headers.Add("X-Total-Count", totalCount.ToString());
                Response.Headers.Add("X-Total-Pages", totalPages.ToString());
                Response.Headers.Add("Access-Control-Expose-Headers", "X-Total-Count, X-Total-Pages");

                return pokemon;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Pokémon: {ex.Message}");
                return StatusCode(500, "An error occurred while retrieving data");
            }
        }

      
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            try
            {
                var pokemon = await _context.Pokemon.FindAsync(id);
                if (pokemon == null)
                {
                    return NotFound($"Pokémon with ID {id} not found");
                }
                return pokemon;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Pokémon with ID {id}: {ex.Message}");
                return StatusCode(500, "An error occurred while retrieving data");
            }
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<Pokemon>> GetPokemonByName(string name)
        {
            try
            {
                Console.WriteLine($"Searching for Pokémon: {name}");
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("Name parameter cannot be empty");
                }

                var pokemon = await _context.Pokemon
                    .FirstOrDefaultAsync(p => p.Name.ToLower() == name.ToLower());

                if (pokemon == null)
                {
                    Console.WriteLine("Pokémon not found.");
                    return NotFound(new { message = $"Pokémon '{name}' not found" });
                }

                return Ok(pokemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Pokémon with name {name}: {ex.Message}");
                return StatusCode(500, "An error occurred while retrieving data");
            }
        }
    }
}
