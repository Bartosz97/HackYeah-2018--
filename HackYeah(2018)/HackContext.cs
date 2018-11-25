using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Models;
using Microsoft.EntityFrameworkCore;

namespace HackYeah_2018_
{
    public class HackContext : DbContext
    {
        public HackContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Rank> Ranks { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
         //   builder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
          //  builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //builder.Entity<Rank>()
            //    .HasRequired(c => c.Stage)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //builder.Entity<Side>()
            //    .HasRequired(s => s.Stage)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }
    }
}
