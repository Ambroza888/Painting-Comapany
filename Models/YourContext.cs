using Microsoft.EntityFrameworkCore;

namespace Paiting.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // public DbSet<User> Users {get;set;}
        // public DbSet<User> Users {get;set;}
        // public DbSet<User> Users {get;set;}
        // public DbSet<User> Users {get;set;}
    }
}