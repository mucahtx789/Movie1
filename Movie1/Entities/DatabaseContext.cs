using Microsoft.EntityFrameworkCore;

namespace Movie1.Entities
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {

        }
        public DbSet<Contents> Contents { get; set; }
    }
}
