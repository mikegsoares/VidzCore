using Microsoft.EntityFrameworkCore;
using Vidz.API.Models;

namespace Vidz.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {  
        }

        public DbSet<Value> Values { get; set; }

    }
}