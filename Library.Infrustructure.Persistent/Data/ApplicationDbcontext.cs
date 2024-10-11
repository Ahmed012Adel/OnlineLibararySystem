using Libarary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Library.Infrustructure.Persistent.Data
{
    public class ApplicationDbcontext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyInformation).Assembly);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<RequestBook> Requests { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
    }
}
