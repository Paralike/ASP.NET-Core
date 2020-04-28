using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using pubertekelo.DAL.Entities;

namespace pubertekelo.DAL.Entities
{
    class PubErtekeloDbContext : DbContext
    {
        public PubErtekeloDbContext([NotNull] DbContextOptions options) : base(options)
        {

        }
        public DbSet <Felhasznalo> Felhasznalok { get; set; }
    }
}
