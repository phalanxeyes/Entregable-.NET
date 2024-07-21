using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProyectodeConsola
{
    public class Car
    {
            public int id { get; set; }
            public string company { get; set; }
            public string model { get; set; }
            public string state { get; set; }
            public string license { get; set; }
            public int production_year { get; set; }
    }
    public class GarageContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public GarageContext() 
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Garage;Integrated Security=true");
        }

    }
    public class CRUD
    {
        public static void Create() 
        { 
            using GarageContext context = new GarageContext();
            {
                context.Cars.Add(new Car
                {
                    company = Console.ReadLine(),
                    model = Console.ReadLine(),
                    state = Console.ReadLine(),
                    license = Console.ReadLine(),
                    production_year = (int)Convert.ChangeType(Console.ReadLine(), typeof(int))
                }); 
                context.SaveChanges();
            }
            
        }
        public static void Read() 
        {
            using GarageContext context = new GarageContext();
            {
                foreach (Car c in context.Cars) 
                {
                    Console.WriteLine(c.id.ToString());
                    Console.WriteLine(c.company);
                    Console.WriteLine(c.model);
                    Console.WriteLine(c.state);
                    Console.WriteLine(c.license);
                    Console.WriteLine(c.production_year);
                }
            }
        }
        public static void Update() 
        {
            int.TryParse(Console.ReadLine(), out int id);
            using GarageContext context = new GarageContext();
            {
                var cartomodify = context.Cars.Find(id);
                cartomodify.company = Console.ReadLine();
                cartomodify.model = Console.ReadLine();
                cartomodify.state = Console.ReadLine();
                cartomodify.license = Console.ReadLine();
                cartomodify.production_year = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                context.SaveChanges();
            };
        }
        public static void Delete() 
        {
            int.TryParse(Console.ReadLine(), out int idinput);
            using GarageContext context = new GarageContext();
            {
            var selected = from c in context.Cars
                       where c.id == idinput
                       select c;
                context.Cars.Remove(selected.ToList()[0]);
                context.SaveChanges();
            }
        }
    }

}
