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
            var mosque = new Mosque
            {
                Id = Guid.Parse("1a82c06a-4986-4ed3-b1dd-05271b4931d8"),
                Address = "Neue Str. 3, 89077 Ulm",
                Email = "AlSalam@gmail.com",
                Name = "Al-Salam Moschee",
            };

            modelBuilder.Entity<Mosque>().HasData(mosque);

            var eventType1 = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                Name = "Fajr",
                Description = "",
                MosqueId = mosque.Id

            };
            var eventType2 = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"),
                Name = "Dohr",
                Description = "",
                MosqueId = mosque.Id

            };
            var eventType3 = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"),
                Name = "Asr",
                Description = "",
                MosqueId = mosque.Id

            };
            var eventType4 = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"),
                Name = "Maghreb",
                Description = "",
                MosqueId = mosque.Id

            };
            var eventType5 = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"),
                Name = "Ishaa",
                Description = "Please choose a group",
                MosqueId = mosque.Id

            };
            modelBuilder.Entity<EventType>().HasData(eventType1, eventType2, eventType3, eventType4, eventType5);

            var events = new[]
            {
                new
                {
                    Id = Guid.Parse("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                    EventTypeId = eventType1.Id,
                    Date = DateTime.Now,
                    Description = "",
                    MosqueId = mosque.Id
                },
                new
                {
                    Id = Guid.Parse("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                    EventTypeId = eventType2.Id,
                    Date = DateTime.Now,
                    Description = "",
                    MosqueId = mosque.Id
                },
                    new
                {
                    Id = Guid.Parse("513a6d9e-b4ee-4299-a945-241428be5114"),
                    EventTypeId = eventType3.Id,
                    Date = DateTime.Now,
                    Description = "",
                    MosqueId = mosque.Id
                },
                new
                {
                    Id = Guid.Parse("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"),
                    EventTypeId = eventType4.Id,
                    Date = DateTime.Now,
                    Description = "",
                    MosqueId = mosque.Id
                },      new
                {
                    Id = Guid.Parse("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"),
                    EventTypeId = eventType5.Id,
                    Date = DateTime.Now,
                    Description = "",
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
                    Name = "Salat "+eventType1.Name,
                    EventId = events[0].Id
                },
                new
                {
                    Id = Guid.Parse("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                    MaxPlaces = 300,
                   Name = "Salat "+eventType2.Name,
                    EventId = events[1].Id
                }
                ,
                new
                {
                    Id = Guid.Parse("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"),
                    MaxPlaces = 300,
                   Name = "Salat "+eventType3.Name,
                    EventId = events[2].Id
                }
                   ,
                new
                {
                    Id = Guid.Parse("a482283f-291a-43bd-8b88-6a4838e96998"),
                    MaxPlaces = 300,
                   Name = "Salat "+eventType4.Name,
                    EventId = events[3].Id
                }
                  ,
                new
                {
                    Id = Guid.Parse("b5d9b806-d791-440a-b773-8380b7d237bd"),
                    MaxPlaces = 300,
                   Name = "Salat "+eventType5.Name,
                    EventId = events[4].Id
                }
                    ,
                new
                {
                    Id = Guid.Parse("3be97c6d-7a78-44df-b1a7-2f7a035600c6"),
                    MaxPlaces = 150,
                   Name = "Tarawih group 1",
                    EventId = events[4].Id
                }
                    ,
                new
                {
                    Id = Guid.Parse("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"),
                    MaxPlaces = 150,
                     Name = "Tarawih group 2",
                    EventId = events[4].Id
                }
            };
            modelBuilder.Entity<EventGroup>().HasData(eventGroups);

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
