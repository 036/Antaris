using AntarisApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AntarisApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Script> Scripts { get; set; } = null!;
        public DbSet<ScriptInstance> ScriptInstances { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"myconnectionstring");
        }
    }
}
