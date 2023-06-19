using ConceptOBack.Interfaces;
using ConceptOBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConceptOBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : Controller
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<Character>))]
        public IActionResult GetCharacters()
        {
            var characters = _characterRepository.GetCharacters();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(characters);
        }
    }
}
