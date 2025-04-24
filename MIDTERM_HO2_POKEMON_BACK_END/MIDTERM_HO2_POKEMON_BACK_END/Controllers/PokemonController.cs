using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MIDTERM_HO2_POKEMON_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        private static List <PokemonDto> _pokemons = new();

        [HttpGet]
        public IActionResult Get(string? name)
        {
            var pokemon = _pokemons.Where(i => i.Name.ToLower() == name.ToLower()).SingleOrDefault();
            return Ok(pokemon);
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_pokemons);
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] PokemonDto pokemon)
        //{
       
        //}
    }
}