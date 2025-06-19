using System;
using RentACar.DataAccess.Models;

namespace RentACar.DataAccess.IRepository
{
    public interface ICarRepository : IRepository<Car>
    {
        Task<List<Car>> GetAvailableCarsAsync();
        Task<List<Car>> GetAllCarsWithBrandAsync();
        Task<Car> GetCarWithBrandAsync(int id);
    }
}

