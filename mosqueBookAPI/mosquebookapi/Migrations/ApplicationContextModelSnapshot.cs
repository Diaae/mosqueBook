﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mosquebookapi.Data;

namespace mosquebookapi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("mosquebookapi.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsActif")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("Token")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.HasIndex("Date", "UserId")
                        .IsUnique();

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("mosquebookapi.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid?>("EventTypeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("MosqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("MosqueId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                            Date = new DateTime(2021, 4, 12, 1, 48, 24, 394, DateTimeKind.Local).AddTicks(6910),
                            Description = "tarawih 1",
                            EventTypeId = new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                            MosqueId = new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8")
                        },
                        new
                        {
                            Id = new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                            Date = new DateTime(2021, 4, 16, 1, 48, 24, 397, DateTimeKind.Local).AddTicks(8112),
                            Description = "tarawih 7",
                            EventTypeId = new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                            MosqueId = new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8")
                        });
                });

            modelBuilder.Entity("mosquebookapi.Models.EventGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("EventId")
                        .HasColumnType("char(36)");

                    b.Property<int>("MaxPlaces")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a113557-d989-4243-af30-4d6906ce02de"),
                            EventId = new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                            MaxPlaces = 300,
                            Name = "Falouja"
                        },
                        new
                        {
                            Id = new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                            EventId = new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                            MaxPlaces = 10,
                            Name = "Samadi"
                        });
                });

            modelBuilder.Entity("mosquebookapi.Models.EventType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EventType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                            Description = "Allaho akbar",
                            Name = "Salat tarawih"
                        });
                });

            modelBuilder.Entity("mosquebookapi.Models.Mosque", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Mosque");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"),
                            Address = "Jamila 07 RUE 900",
                            Email = "JamaaSouna@gmail.com",
                            Name = "Jamaa Souna"
                        });
                });

            modelBuilder.Entity("mosquebookapi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("mosquebookapi.Models.Appointment", b =>
                {
                    b.HasOne("mosquebookapi.Models.EventGroup", "Group")
                        .WithMany("Appointments")
                        .HasForeignKey("GroupId");

                    b.HasOne("mosquebookapi.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("mosquebookapi.Models.Event", b =>
                {
                    b.HasOne("mosquebookapi.Models.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId");

                    b.HasOne("mosquebookapi.Models.Mosque", "Mosque")
                        .WithMany("Events")
                        .HasForeignKey("MosqueId");

                    b.Navigation("EventType");

                    b.Navigation("Mosque");
                });

            modelBuilder.Entity("mosquebookapi.Models.EventGroup", b =>
                {
                    b.HasOne("mosquebookapi.Models.Event", "Event")
                        .WithMany("Groups")
                        .HasForeignKey("EventId");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("mosquebookapi.Models.Event", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("mosquebookapi.Models.EventGroup", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("mosquebookapi.Models.EventType", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("mosquebookapi.Models.Mosque", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("mosquebookapi.Models.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
