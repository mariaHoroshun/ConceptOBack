using ConceptOBack.Models;
using Microsoft.EntityFrameworkCore;

namespace ConceptOBack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<CharacterInfoModule> CharacterInfoModules { get; set; }
    }
}
