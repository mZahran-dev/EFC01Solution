using EFC01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            dbContext.Database.Migrate();


        }
    }
}
