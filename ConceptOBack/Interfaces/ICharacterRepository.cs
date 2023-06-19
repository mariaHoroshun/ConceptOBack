using ConceptOBack.Models;

namespace ConceptOBack.Interfaces
{
    public interface ICharacterRepository
    {
        ICollection<Character> GetCharacters();
    }
}
