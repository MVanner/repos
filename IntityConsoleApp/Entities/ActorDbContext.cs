using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace IntityConsoleApp.Entities
{
    class ActorDbContext : DbContext
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Database=ActorDb; Trusted_Connection=True;";

        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
