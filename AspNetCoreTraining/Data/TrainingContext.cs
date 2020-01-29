using AspNetCoreTraining.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data
{
    public class TrainingContext : DbContext {

        public DbSet<Student> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }



        public TrainingContext(DbContextOptions<TrainingContext> options) 
            :base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");

            modelBuilder.Entity<Student>()
                    .HasData(DataFactory.Students);
            modelBuilder.Entity<Course>()
                    .HasData(DataFactory.Courses);
            modelBuilder.Entity<Enrollment>()
                    .HasData(DataFactory.Enrollments);
        }
    }
}
