
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class MyWebAppContext : DbContext
    {
        public MyWebAppContext(DbContextOptions<MyWebAppContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
