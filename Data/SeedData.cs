using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using VolvoTest.MVC.Models;

namespace VolvoTest.MVC.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
          using (var context = new VolvoTestContext(
            serviceProvider.GetRequiredService<DbContextOptions<VolvoTestContext>>())
          )
          {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (!context.TruckModel.Any())
            {
                context.TruckModel.AddRange(
                  new TruckModel {
                    Name = "FH", Active = true
                  },
                  new TruckModel {
                    Name = "FM", Active = true
                  },
                  new TruckModel {
                    Name = "Other 1", Active = false
                  },
                  new TruckModel {
                    Name = "Other 2", Active = false
                  }
                );
                context.SaveChanges();
            }

            if (!context.Truck.Any()) {
              context.Truck.AddRange(
                new Truck {
                  TruckModel = "FM",
                  ManufactureYear = 2021,
                  ModelYear = 2021,
                  Renavam = 12345678901,
                  Plate = "AAA0000",
                  Chassi = "AAAAAAAAAAAAAAAAA",
                  HorsePower = 300
                },
                new Truck {
                  TruckModel = "FH",
                  ManufactureYear = 2021,
                  ModelYear = 2021,
                  Renavam = 98765432109,
                  Plate = "BBB9999",
                  Chassi = "BBBBBBBBBBBBBBBBB",
                  HorsePower = 400
                }
              );
              context.SaveChanges();
            }
          }
        }
    }
}