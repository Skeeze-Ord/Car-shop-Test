using Microsoft.AspNetCore.Mvc;
using Shop2.Data.Interfaces;
using Shop2.Data.Models;
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

        [Route("Cars/List")]
        [Route("Cars/List/{Category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else 
            {
                if(string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else if(string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase)){
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel()
            {
                AllCars = cars,
                CurrCategory = currCategory
            };


            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}
