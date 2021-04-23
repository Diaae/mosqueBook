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
                Email = "verwaltung@assalam-ulm.de",
                Name = "Al-Salam Moschee",
            };

            modelBuilder.Entity<Mosque>().HasData(mosque);

            var fajrEventType = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                Name = "Fajr",
                Description = "",
                MosqueId = mosque.Id

            };
            var dohrEventType = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"),
                Name = "Dohr",
                Description = "",
                MosqueId = mosque.Id

            };
            var asrEventType = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"),
                Name = "Asr",
                Description = "",
                MosqueId = mosque.Id

            };
            var maghrebEventType = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"),
                Name = "Maghreb",
                Description = "",
                MosqueId = mosque.Id

            };
            var ishaaEventType = new
            {
                Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"),
                Name = "Ishaa",
                Description = "Enthält Gruppen: Tarawih Gruppe 1 - Tarawih Gruppe 2",
                MosqueId = mosque.Id

            };
            modelBuilder.Entity<EventType>().HasData(fajrEventType, dohrEventType, asrEventType, maghrebEventType, ishaaEventType);

            for (int i = 1; i <= 30; i++)
            {
                var fajrEvent = new
                {
                    Id = Guid.NewGuid(),
                    EventTypeId = fajrEventType.Id,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    MosqueId = mosque.Id
                    
                };
                var dohrEvent = new
                {
                    Id = Guid.NewGuid(),
                    EventTypeId = dohrEventType.Id,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    isFriday = false,
                    MosqueId = mosque.Id
                };
                var asrEvent = new
                {
                    Id = Guid.NewGuid(),
                    EventTypeId = asrEventType.Id,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    MosqueId = mosque.Id
                };
                var maghrebEvent = new
                {
                    Id = Guid.NewGuid(),
                    EventTypeId = maghrebEventType.Id,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    MosqueId = mosque.Id
                };
                var ishaaEvent = new
                {
                    Id = Guid.NewGuid(),
                    EventTypeId = ishaaEventType.Id,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    MosqueId = mosque.Id
                };

                modelBuilder.Entity<Event>().HasData(fajrEvent, dohrEvent, asrEvent, maghrebEvent, ishaaEvent);

                var fajrEventGroup = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Salat " + fajrEventType.Name,
                    EventId = fajrEvent.Id
                };
                var dohrEventGroup = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Salat " + dohrEventType.Name,
                    EventId = dohrEvent.Id
                };
                var asrEventGroup = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Salat " + asrEventType.Name,
                    EventId = asrEvent.Id
                };
                var maghrebEventGroup = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Salat " + maghrebEventType.Name,
                    EventId = maghrebEvent.Id
                };
                var ishaaEventGroup1 = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Salat " + ishaaEventType.Name,
                    EventId = ishaaEvent.Id
                };
                var ishaaEventGroup2 = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Tarawih group 1",
                    EventId = ishaaEvent.Id
                };
                var ishaaEventGroup3 = new
                {
                    Id = Guid.NewGuid(),
                    MaxPlaces = 120,
                    Name = "Tarawih group 2",
                    EventId = ishaaEvent.Id
                };
            
                modelBuilder.Entity<EventGroup>().HasData(fajrEventGroup, dohrEventGroup, asrEventGroup, maghrebEventGroup, ishaaEventGroup1, ishaaEventGroup2, ishaaEventGroup3);
            }

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
