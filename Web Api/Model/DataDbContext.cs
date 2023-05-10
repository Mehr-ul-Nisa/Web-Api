using Microsoft.EntityFrameworkCore;

namespace Web_Api.Model
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options): base(options)
        {

        }
        public DbSet<Signup> Signup { get; set; }
    }
}
