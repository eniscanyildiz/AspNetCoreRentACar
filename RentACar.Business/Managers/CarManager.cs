using System;
using AutoMapper;
using RentACar.Business.Services;
using RentACar.DataAccess.IRepository;
using RentACar.Entity.Entities;

namespace RentACar.Business.Managers
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarManager(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<List<Car>> GetAllCarsWithBrandAsync()
        {
            var carsDataModel = await _carRepository.GetAllCarsWithBrandAsync();

            var carsEntityModel = _mapper.Map<List<Car>>(carsDataModel);

            return carsEntityModel;
        }
        public async Task<Car> GetCarWithBrandAsync(int id)
        {
            var carsDataModel = await _carRepository.GetCarWithBrandAsync(id);

            var carsEntityModel = _mapper.Map<Car>(carsDataModel);

            return carsEntityModel;
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            var carsDataModel = await _carRepository.GetAllAsync();

            var carsEntityModel = _mapper.Map<List<Car>>(carsDataModel);

            return carsEntityModel;
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            var carsDataModel = await _carRepository.GetByIdAsync(id);

            var carsEntityModel = _mapper.Map<Car>(carsDataModel);

            return carsEntityModel;
        }

        public async Task AddCarAsync(Car car)
        {
            var carsDataModel = _mapper.Map<RentACar.DataAccess.Models.Car>(car);

            await _carRepository.AddAsync(carsDataModel);
            await _carRepository.SaveAsync();
        }

        public async Task UpdateCarAsync(Car car)
        {
            var carsDataModel = _mapper.Map<RentACar.DataAccess.Models.Car>(car);

            _carRepository.Update(carsDataModel);
            await _carRepository.SaveAsync();
        }

        public async Task DeleteCarAsync(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car != null)
            {
                _carRepository.Delete(car);
                await _carRepository.SaveAsync();
            }
        }

        
    }

}

