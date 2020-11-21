using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalNomads.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigitalNomads.Data
{
    public class CtrlAltDefeatDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Meditation> Meditations { get; set; }
        public DbSet<MeditationWords> MeditationWords { get; set; }
        public DbSet<Motivation> Motivations { get; set; }
        public DbSet<Duty> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public CtrlAltDefeatDbContext(DbContextOptions<CtrlAltDefeatDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
