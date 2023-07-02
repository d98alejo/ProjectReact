using Microsoft.EntityFrameworkCore;
using ProjectReact.Models;

namespace ProjectReact.Data
{
	public class DataContext: DbContext
	{
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Activity> Activities { get; set; } //El nombre que va a tener en la BD
    }
}
