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
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
    }
}
