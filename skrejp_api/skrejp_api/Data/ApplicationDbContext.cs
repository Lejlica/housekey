using Microsoft.EntityFrameworkCore;
using skrejp_api.Model;
using System;

namespace skrejp_api.Data
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nekretnina> Nekretnina { get; set; }
        public DbSet<Slike> Slike { get; set; }

    }
}
