using Microsoft.EntityFrameworkCore;
using Shopping.Data.Entitties;

//();

namespace Shopping.Data
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext>options):base(options)  
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
