using Microsoft.AspNetCore.Mvc;
using Shop2.Data.Interfaces;
using Shop2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            CarsListViewModel obj = new();
            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Автомобили";
            return View(obj);
        }
    }
}
