using Microsoft.EntityFrameworkCore;
using GuitarVault.Models;

namespace GuitarVault.BD
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GuitarraModel> Guitarras { get; set; }
        public DbSet<ContactoModel> Contactos { get; set; }
    }
}