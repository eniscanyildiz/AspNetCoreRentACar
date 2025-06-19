using System;
using AutoMapper;
using RentACar.DataAccess.Models;

namespace RentACar.Business.Mapper
{
	public class MappingProfile: Profile
	{
        public MappingProfile()
        {
            CreateMap<Car, RentACar.Entity.Entities.Car>().ReverseMap();
            CreateMap<Brand, RentACar.Entity.Entities.Brand>().ReverseMap();
        }
    }
}

