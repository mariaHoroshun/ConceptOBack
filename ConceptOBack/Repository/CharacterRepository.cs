using ConceptOBack.Data;
using ConceptOBack.Interfaces;
using ConceptOBack.Models;

namespace ConceptOBack.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DataContext _context;
        public CharacterRepository(DataContext dataContext) 
        {
            _context = dataContext;
        }

        public bool CharacterExists(int characterId)
        {
            return _context.Characters.Any(p => p.Id == characterId);
        }

        public Character GetCharacter(int id)
        {
            return _context.Characters.Where(p => p.Id == id).FirstOrDefault();
        }

        public Character GetCharacter(string name)
        {
            return _context.Characters.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Character> GetCharacters()
        {
            return _context.Characters.OrderBy(p => p.Id).ToList();
        }
    }
}
