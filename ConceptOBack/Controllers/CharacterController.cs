using AutoMapper;
using ConceptOBack.Dto;
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
        private readonly IMapper _mapper;

        public CharacterController(
            ICharacterRepository characterRepository,
            IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<Character>))]
        public IActionResult GetCharacters()
        {
            var characters = _mapper.Map<List<CharacterDto>>(_characterRepository.GetCharacters());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(characters);
        }

        [HttpGet("{characterId}")]
        [ProducesResponseType(200, Type = typeof(Character))]
        [ProducesResponseType(400)]
        public IActionResult GetCharacter(int characterId) 
        {
            if (!_characterRepository.CharacterExists(characterId))
            {
                return NotFound();
            }
            var character = _mapper.Map<CharacterDto>(_characterRepository.GetCharacter(characterId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(character);
        }
    }
}
