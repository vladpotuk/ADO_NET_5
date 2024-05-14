using Microsoft.EntityFrameworkCore;
using System;
using ADO_NET_4.Models;
using ADO_NET_4.DataAccess;

namespace ADO_NET_4.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Games;Trusted_Connection=True;");

            
            using (var context = new MyDbContext(optionsBuilder.Options))
            {
              
                var entity = new MyEntity { Name = "Sample Entity" };
                context.MyEntities.Add(entity);
                context.SaveChanges();

                Console.WriteLine("Entity added successfully!");
            }
        }
    }
}
