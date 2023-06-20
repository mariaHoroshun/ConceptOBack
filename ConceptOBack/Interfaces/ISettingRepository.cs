using ConceptOBack.Models;

namespace ConceptOBack.Interfaces
{
    public interface ISettingRepository
    {
        ICollection<Setting> GetSettings();
    }
}
