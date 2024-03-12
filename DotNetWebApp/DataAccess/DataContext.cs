using DotNetWebApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebApp.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public string ConnectionString { get; set; }

        public DataContext(string dbFile)
        {
            ConnectionString = "Data Source=" + Path.Combine(Environment.CurrentDirectory, dbFile);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
