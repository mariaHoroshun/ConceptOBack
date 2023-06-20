using ConceptOBack.Data;
using ConceptOBack.Interfaces;
using ConceptOBack.Models;

namespace ConceptOBack.Repository
{
    public class SettingRepository : ISettingRepository
    {
        private readonly DataContext _context;

        public SettingRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public ICollection<Setting> GetSettings()
        {
           return _context.Settings.OrderBy(p => p.Id).ToList();
        }
    }
}
