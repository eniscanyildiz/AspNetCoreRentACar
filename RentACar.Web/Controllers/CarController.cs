using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Services;
using RentACar.Entity.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentACar.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carManager)
        {
            _carService = carManager;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _carService.GetAllCarsWithBrandAsync();
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public async Task<IActionResult> Create(Car car)
        {
            if (ModelState.IsValid)
            {
                await _carService.AddCarAsync(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var car = await _carService.GetCarWithBrandAsync(id);
            if (car == null)
                return NotFound();

            return View(car);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                await _carService.UpdateCarAsync(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var car = await _carService.GetCarWithBrandAsync(id);
            if (car == null)
                return NotFound();

            return View(car);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _carService.DeleteCarAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

