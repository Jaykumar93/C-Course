using Microsoft.EntityFrameworkCore;
using RedisASP.Model;
namespace RedisASP.DbContext
{
    
        public class DbContextClass : DbContext
        {
            public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
            {
            }
            public DbSet<Product> Products { get; set; }
        }
  
}
