﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DigitalNomads.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigitalNomads.Data
{
    public class CtrlAltDefeatDbContext : IdentityDbContext
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

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
