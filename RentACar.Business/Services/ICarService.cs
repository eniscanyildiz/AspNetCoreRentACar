using System;
using System.Runtime.ConstrainedExecution;
using RentACar.Entity.Entities;

namespace RentACar.Business.Services
{
    public interface ICarService
    {
        Task<List<Car>> GetAllCarsAsync();
        Task<List<Car>> GetAllCarsWithBrandAsync();
        Task<Car> GetCarWithBrandAsync(int id);
        Task<Car> GetCarByIdAsync(int id);
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int id);
    }
}

