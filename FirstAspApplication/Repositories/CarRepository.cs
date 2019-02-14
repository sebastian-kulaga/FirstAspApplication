using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAspApplication.Models;

namespace FirstAspApplication.Repositories
{
    public class CarRepository: ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _appDbContext.Cars;
        }

        public Car GetCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}
