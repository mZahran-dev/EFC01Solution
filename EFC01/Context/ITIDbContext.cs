using EFC01.ITI_DB_Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-M4KTLBQ; Database = ITI_Db; Trusted_Connection = True; Encrypt = false; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent APIS
            modelBuilder.Entity<Student>()
                        .Property("Address")
                        .HasDefaultValue("Cairo");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
    }
}
