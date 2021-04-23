using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public class DataSeeding
    {
        public static async Task InitData(ApplicationContext context)
        {
            var mosqueId = new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8");
            if (context.Mosques.SingleOrDefault(m => m.Id.Equals(mosqueId)) != null)
                return;
            using (var transaction = context.Database.BeginTransaction())
            {
                var mosque = new Mosque
                {
                    Id = mosqueId,
                    Address = "Neue Str. 3, 89077 Ulm",
                    Email = "verwaltung@assalam-ulm.de",
                    Name = "Al-Salam Moschee",
                };

                context.Mosques.Add(mosque);
                context.SaveChanges();

                var fajrEventType = new EventType
                {
                    Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                    Name = "Fajr",
                    Description = "",
                    Mosque = mosque

                };
                var dohrEventType = new EventType
                {
                    Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"),
                    Name = "Dohr",
                    Description = "",
                    Mosque = mosque

                };
                var asrEventType = new EventType
                {
                    Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"),
                    Name = "Asr",
                    Description = "",
                    Mosque = mosque

                };
                var maghrebEventType = new EventType
                {
                    Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"),
                    Name = "Maghreb",
                    Description = "",
                    Mosque = mosque

                };
                var ishaaEventType = new EventType
                {
                    Id = Guid.Parse("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"),
                    Name = "Ishaa",
                    Description = "Enthält Gruppen: Tarawih Gruppe 1 - Tarawih Gruppe 2",
                    Mosque = mosque

                };
                context.EventTypes.AddRange(new[] { fajrEventType, dohrEventType, asrEventType, maghrebEventType, ishaaEventType });
                context.SaveChanges();

                for (int i = 1; i <= 30; i++)
                {
                    var fajrEvent = new Event
                    {
                        Id = Guid.NewGuid(),
                        EventType = fajrEventType,
                        Date = DateTime.Now.AddDays(i),
                        Description = "",
                        Mosque = mosque

                    };
                    var dohrDate = DateTime.Now.AddDays(i);
                    var isFriday = dohrDate.DayOfWeek == DayOfWeek.Friday;
                    var dohrEvent = new Event
                    {
                        Id = Guid.NewGuid(),
                        EventType = dohrEventType,
                        Date = dohrDate,
                        Description = isFriday ? "Enthält Gruppen: Jumuah Gruppe 1 - Jumuah Gruppe 2" : "",
                        Mosque = mosque
                    };
                    var asrEvent = new Event
                    {
                        Id = Guid.NewGuid(),
                        EventType = asrEventType,
                        Date = DateTime.Now.AddDays(i),
                        Description = "",
                        Mosque = mosque
                    };
                    var maghrebEvent = new Event
                    {
                        Id = Guid.NewGuid(),
                        EventType = maghrebEventType,
                        Date = DateTime.Now.AddDays(i),
                        Description = "",
                        Mosque = mosque
                    };
                    var ishaaEvent = new Event
                    {
                        Id = Guid.NewGuid(),
                        EventType = ishaaEventType,
                        Date = DateTime.Now.AddDays(i),
                        Description = "",
                        Mosque = mosque
                    };


                    context.Events.AddRange(new[] { fajrEvent, dohrEvent, asrEvent, maghrebEvent, ishaaEvent });
                    context.SaveChanges();
                    var eventGroupList = new List<EventGroup>() {
                        new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + fajrEventType.Name,
                            Event = fajrEvent
                        },new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + asrEventType.Name,
                            Event = asrEvent
                        }, new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + maghrebEventType.Name,
                            Event = maghrebEvent
                        }, new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + ishaaEventType.Name,
                            Event = ishaaEvent
                        },
                         new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Tarawih Gruppe 1",
                            Event = ishaaEvent
                        },
                        new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Tarawih Gruppe 2",
                            Event = ishaaEvent
                        }
                    };
                    if (isFriday)
                    {
                        eventGroupList.AddRange(new[]{
                            new EventGroup{
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Jumuah Gruppe 1",
                        },new EventGroup{
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Jumuah Gruppe 2 " ,
                        }
                        }
                       );
                    }
                    else
                    {
                        eventGroupList.Add(new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + dohrEventType.Name,
                        }
                        );
                    }
                    context.AddRange(eventGroupList);
                    context.SaveChanges();
                }
                await transaction.CommitAsync();

            }
        }
    }
}
