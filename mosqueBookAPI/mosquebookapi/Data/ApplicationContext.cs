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

            var eventType = new EventType {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                Name = "Salat tarawih",
                Description = "Allaho akbar"
            };
            modelBuilder.Entity<EventType>().HasData(eventType);
            

            var mosque = new Mosque
            {
                Id = Guid.Parse("1a82c06a-4986-4ed3-b1dd-05271b4931d8"),
                Address = "Jamila 07 RUE 900",
                Email = "JamaaSouna@gmail.com",
                Name = "Jamaa Souna",
            };
            modelBuilder.Entity<Mosque>().HasData(mosque);
            var events = new[]
            {
                new 
                {
                    Id = Guid.Parse("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                    EventTypeId = eventType.Id,
                    Date = DateTime.Now.AddDays(3),
                    Description = "tarawih 1",
                    MosqueId = mosque.Id
                },
                new 
                {
                    Id = Guid.Parse("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                    EventTypeId = eventType.Id,
                    Date = DateTime.Now.AddDays(7),
                    Description = "tarawih 7",
                    MosqueId = mosque.Id
                }
            };
            modelBuilder.Entity<Event>().HasData(events);
            var eventGroups = new[]
            {
                new 
                {
                    Id = Guid.Parse("4a113557-d989-4243-af30-4d6906ce02de"),
                    MaxPlaces = 300,
                    Name = "Falouja",
                    EventId = events[0].Id
                },new 
                {
                    Id = Guid.Parse("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                    MaxPlaces = 10,
                    Name = "Samadi",
                    EventId = events[1].Id
                }
            };
            modelBuilder.Entity<EventGroup>().HasData(eventGroups);

            modelBuilder.Entity<TemporaryAuthenticator>().HasData(new TemporaryAuthenticator { 
                Id = 1,
                Token = Guid.NewGuid()
            });

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
        public DbSet<Mosque>  Mosques { get; set; }
        public DbSet<Event>  Events { get; set; }
        public DbSet<EventType>  EventTypes { get; set; }
        public DbSet<EventGroup> EventGroups { get; set; }
        public DbSet<TemporaryAuthenticator> TemporaryAuthenticators { get; set; }
    }
}
