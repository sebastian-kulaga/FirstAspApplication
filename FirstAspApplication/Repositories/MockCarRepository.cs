using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAspApplication.Models;

namespace FirstAspApplication.Repositories
{
    public class MockCarRepository : ICarRepository
    {
        private List<Car> _cars;

        public MockCarRepository()
        {
            if (_cars == null)
            {
                InitializeCars();
            }
        }

        private void InitializeCars()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, Brand = "Porsche", Model = "911", ShortDescription = "Carrera GTS", Engine = 2981, HorsePower = 450, FuelType = "Petrol", Price = 645170, ImageUrl = "dummy", ImageThumbnailUrl = "~/lib/images/porsche-911-carrera-image.jpg", IsCarOfTheWeek = true},
                new Car {Id = 1, Brand = "Porsche", Model = "911", ShortDescription = "GT3 RS", Engine = 3996, HorsePower = 520, FuelType = "Petrol", Price = 1000000, ImageUrl = "dummy", ImageThumbnailUrl = "~/lib/images/gt3-rs-image.jpg", IsCarOfTheWeek = false},
                new Car {Id = 1, Brand = "Porsche", Model = "718", ShortDescription = "Boxter", Engine = 1988, HorsePower = 309, FuelType = "Petrol", Price = 248520, ImageUrl = "dummy", ImageThumbnailUrl = "~/lib/images/boxter-image.jpg", IsCarOfTheWeek = false}
            };
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetCarById(int carId)
        {
            return _cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}
