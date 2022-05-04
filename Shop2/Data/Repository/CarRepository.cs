﻿using Microsoft.EntityFrameworkCore;
using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }


        public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => _appDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => _appDBContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}
