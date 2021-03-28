using Microsoft.EntityFrameworkCore;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public class MosqueBookContext : DbContext
    {
        public MosqueBookContext(DbContextOptions<MosqueBookContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<Appointment>().ToTable("Appointment");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
        public DbSet<Mosque>  Mosques { get; set; }
        public DbSet<Event>  Events { get; set; }
        public DbSet<EventType>  EventTypes { get; set; }
        public DbSet<EventGroup> EventGroups { get; set; }
    }
}
