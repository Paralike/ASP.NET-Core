using System.Diagnostics.CodeAnalysis;
using PubErtekelo.DAL.Entities;
using   Microsoft.EntityFrameworkCore;

namespace PubErtekelo.DAL
{
    public class PubErtekeloDbContext : DbContext
    {
        public PubErtekeloDbContext([NotNull] DbContextOptions options) : base(options)
        {

        }
        public DbSet <Felhasznalo> Felhasznalok { get; set; }
    }
}
