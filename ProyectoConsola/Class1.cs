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
            public string? company { get; set; }
            public string? model { get; set; }
            public string? state { get; set; }
            public string? license { get; set; }
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
        public static void Create(string company, string model, string state, string license, int production_year) 
        { 
            using GarageContext context = new GarageContext();
            {
                context.Cars.Add(new Car
                {
                    company = company,
                    model = model,
                    state = state,
                    license = license,
                    production_year = production_year
                }); 
                context.SaveChanges();
            }
            
        }
        public static List<string[]> Read() 
        {
            List<string[]> list = new List<string[]>();
            using GarageContext context = new GarageContext();
            {
                foreach (Car c in context.Cars) 
                {
                    string[] row = {
                        Convert.ToString(c.id), 
                        c.company,
                        c.model,
                        c.state,
                        c.license, 
                        Convert.ToString(c.production_year)};
                    list.Add(row);
                }
            }
            return list;
        }
        public static void Update(int id, string company, string model, string state, string license, int production_year) 
        {
            using GarageContext context = new GarageContext();
            {
                var cartomodify = context.Cars.Find(id);
                if (cartomodify != null) 
                {
                    cartomodify.company = company;
                    cartomodify.model = model;
                    cartomodify.state = state;
                    cartomodify.license = license;
                    cartomodify.production_year = production_year;
                    context.SaveChanges();
                }

            };
        }
        public static void Delete(int id) 
        {
            using GarageContext context = new GarageContext();
            {
            var selected = from c in context.Cars
                       where c.id == id
                       select c;
                context.Cars.Remove(selected.ToList()[0]);
                context.SaveChanges();
            }
        }
    }

}
