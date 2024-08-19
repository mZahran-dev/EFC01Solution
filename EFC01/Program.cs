using EFC01.Context;
using EFC01.ITI_DB_Schema;
using Microsoft.EntityFrameworkCore;

namespace EFC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            //dbContext.Database.Migrate();

            // How to Hold the tables by Data Annotation
            dbContext.Set<Student>().Where(S => S.ID == 1);



        }
    }
}
