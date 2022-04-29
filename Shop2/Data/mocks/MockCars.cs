using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {Name = "Tesla Model S", 
                        ShortDesc = "Быстрый автомобиль", 
                        LongDesc = "Быстрый и очень тихий автомобиль компании Tesla", 
                        Img = "https://carsweek.ru/upload/iblock/34f/34fc8c4abb849822546cc75e5ce56eeb.jpg",
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _categoryCars.AllCategories.ElementAt(0)},

                    new Car {Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://3d-car-shows.com/wp-content/uploads/2013/02/Ford-Fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.ElementAt(0)},

                    new Car {Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://carsweek.ru/upload/uf/bb7/bb71b76144fa05315870fe85d9972631.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.ElementAt(1)},

                    new Car {Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://i.pinimg.com/originals/31/70/7a/31707a50ecdba4404d5aa6c919101399.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.ElementAt(1)},

                    new Car {Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://img.favcars.com/nissan/leaf/photos_nissan_leaf_2013_1.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.ElementAt(0)}
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
