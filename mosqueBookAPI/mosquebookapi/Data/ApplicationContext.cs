using Microsoft.EntityFrameworkCore;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<Appointment>().ToTable("Appointment");{
            

            //var events = new[]
            //{
            //    new
            //    {
            //        Id = Guid.Parse("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
            //        EventTypeId = eventType1.Id,
            //        Date = DateTime.Now,
            //        Description = "",
            //        MosqueId = mosque.Id
            //    },
            //    new
            //    {
            //        Id = Guid.Parse("802e14d4-7c79-4740-aefc-6bf5b412129c"),
            //        EventTypeId = eventType2.Id,
            //        Date = DateTime.Now,
            //        Description = "",
            //        MosqueId = mosque.Id
            //    },
            //        new
            //    {
            //        Id = Guid.Parse("513a6d9e-b4ee-4299-a945-241428be5114"),
            //        EventTypeId = eventType3.Id,
            //        Date = DateTime.Now,
            //        Description = "",
            //        MosqueId = mosque.Id
            //    },
            //    new
            //    {
            //        Id = Guid.Parse("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"),
            //        EventTypeId = eventType4.Id,
            //        Date = DateTime.Now,
            //        Description = "",
            //        MosqueId = mosque.Id
            //    },      new
            //    {
            //        Id = Guid.Parse("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"),
            //        EventTypeId = eventType5.Id,
            //        Date = DateTime.Now,
            //        Description = "",
            //        MosqueId = mosque.Id
            //    }
            //};

            //modelBuilder.Entity<Event>().HasData(events);



            modelBuilder.Entity<TemporaryAuthenticator>().HasData(new TemporaryAuthenticator
            {
                Id = 1,
                Token = Guid.NewGuid()
            });

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Mosque> Mosques { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventGroup> EventGroups { get; set; }
        public DbSet<TemporaryAuthenticator> TemporaryAuthenticators { get; set; }
    }
}
