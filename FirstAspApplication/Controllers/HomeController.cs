using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAspApplication.Models;
using FirstAspApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {
            var cars = _carRepository.GetAllCars().OrderBy(c => c.Brand);

            var homeViewModel = new HomeViewModel()
            {
                Cars = cars.ToList(),
                Title = "Welcome to Car Shop"
            };
            return View(homeViewModel);
        }
    }
}