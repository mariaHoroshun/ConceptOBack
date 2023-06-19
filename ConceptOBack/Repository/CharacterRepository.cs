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

        public ICollection<Character> GetCharacters()
        {
            return _context.Characters.OrderBy(p => p.Id).ToList();
        }
    }
}
