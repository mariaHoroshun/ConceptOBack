using ConceptOBack.Models;

namespace ConceptOBack.Interfaces
{
    public interface ICharacterRepository
    {
        ICollection<Character> GetCharacters();

        Character GetCharacter(int id);

        Character GetCharacter(string name);

        bool CharacterExists (int characterId);
    }
}
