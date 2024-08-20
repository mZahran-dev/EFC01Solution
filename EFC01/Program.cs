using EFC01.Context;
using EFC01.ITI_DB_Schema;
using Microsoft.EntityFrameworkCore;

namespace EFC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //dbContext.Database.Migrate();

            // How to Hold the tables by Data Annotation
            //dbContext.Set<Student>().Where(S => S.ID == 1);

            #region CRUD Operations
            using ITIDbContext dbContext = new ITIDbContext();

            //Student student = new Student()
            //{
            //    FName = "mahmoud",
            //    LName = "Ibrahim",
            //    Address = "Cairo",
            //    Age = 21,
            //    Dep_Id = 1,

            //};

            //var stud = (from s in dbContext.Students
            //           where s.ID == 2 
            //           select s).FirstOrDefault();
            ////dbContext.Add(student);
            ////dbContext.Set<Student>().Add(student);
            ////dbContext.Students.Add(student);
            ////dbContext.Students.Remove(stud);

            //Console.WriteLine(dbContext.Entry(student).State);
            //dbContext.SaveChanges();

            //Course course = new Course()
            //{
            //    Name = ".Net",
            //    Duration = 23,
            //    Description = "c#",
            //    Top_Id = 1,

            //};
            //dbContext.Add(course);
            //dbContext.SaveChanges();


            //Department department = new Department() 
            //{ 
            //    Name = "cs",
            //    HiringDate = DateTime.Now,
            //    Ins_ID = 1,
            //};

            //dbContext.Add(department);
            //dbContext.SaveChanges();

            //Instructor instructor = new Instructor()
            //{
            //    Name = "omar",
            //    Salary = 7000,
            //    Bouns = 1000,
            //    Address = "Cairo",
            //    Dept_ID = 1,
            //    HourRate = 100
            //};
            //dbContext.Add(instructor);
            //dbContext.SaveChanges();

            //Topic topic = new Topic()
            //{
            //    Name = "Operating System"
            //};
            //dbContext.Add(topic);
            //dbContext.SaveChanges();

            var ins = (from d in dbContext.Instructors
                        where d.ID == 2
                        select d).FirstOrDefault();
            dbContext.Instructors.Remove(ins);
            #endregion

            


        }
    }
}
