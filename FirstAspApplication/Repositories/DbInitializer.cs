using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAspApplication.Models;

namespace FirstAspApplication.Repositories
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                context.AddRange(
                    new Car { Brand = "Porsche", Model = "911", ShortDescription = "Carrera GTS", Engine = 2981, HorsePower = 450, FuelType = "Petrol", Price = 645170, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/porsche-911-carrera-image.jpg", IsCarOfTheWeek = true },
                    new Car { Brand = "Porsche", Model = "911", ShortDescription = "GT3 RS", Engine = 3996, HorsePower = 520, FuelType = "Petrol", Price = 1000000, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/gt3-rs-image.jpg", IsCarOfTheWeek = false },
                    new Car { Brand = "Porsche", Model = "718", ShortDescription = "Boxter", Engine = 1988, HorsePower = 309, FuelType = "Petrol", Price = 248520, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/boxter-image.jpg", IsCarOfTheWeek = false },
                    new Car { Brand = "Porsche", Model = "718", ShortDescription = "Cayman T", Engine = 3996, HorsePower = 300, FuelType = "Petrol", Price = 700000, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/718-cayman-t-image.jpg", IsCarOfTheWeek = false },
                    new Car { Brand = "Porsche", Model = "Panamera", ShortDescription = "Turbo Executive", Engine = 3996, HorsePower = 550, FuelType = "Petrol", Price = 1440000, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/panamera-turbo-executive-image.jpg", IsCarOfTheWeek = false },
                    new Car { Brand = "Porsche", Model = "Macan", ShortDescription = "GTS", Engine = 1988, HorsePower = 360, FuelType = "Petrol", Price = 300000, ImageUrl = "dummy", ImageThumbnailUrl = "~/images/macan-gts-image.jpg", IsCarOfTheWeek = false }
                    );
                context.SaveChanges();
            }
        }
    }
}
