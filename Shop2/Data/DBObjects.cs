using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                         new Car
                         {
                             Name = "Tesla Model S",
                             ShortDesc = "Быстрый автомобиль",
                             LongDesc = "Быстрый и очень тихий автомобиль компании Tesla",
                             Img = "/img/tesla.jpg",
                             Price = 45000,
                             IsFavourite = true,
                             Available = true,
                             Category = Categories["Электромобили"]
                         },

                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/Ford-Fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/bmw.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", Desc = "Современный вил транспорта" },
                        new Category {CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего згорания"}
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        _category.Add(el.CategoryName, el);
                    }
                }

                return _category;
            }
        }
    }
}
