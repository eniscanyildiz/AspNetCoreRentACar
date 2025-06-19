using System;
using Microsoft.EntityFrameworkCore;
using RentACar.DataAccess.IRepository;
using RentACar.DataAccess.Models;

namespace RentACar.DataAccess.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        private readonly RentACarDBContext _context;

        public CarRepository(RentACarDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetAvailableCarsAsync()
        {
            return await _context.Cars
                .Where(c => c.Available == true)
                .Include(c => c.Brand)
                .ToListAsync();
        }

        public async Task<List<Car>> GetAllCarsWithBrandAsync()
        {
            return await _context.Cars
                 .Include(c => c.Brand)
                 .ToListAsync();
        }

        public async Task<Car> GetCarWithBrandAsync(int id)
        {
            return await _context.Cars
                .Include(c => c.Brand)
                .FirstOrDefaultAsync(c => c.CarId == id);

        }
    }
}

