using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car Сar { get; set; }
        public int Price { get; set; }

        public string ShopCartId { get; set; }

    }
}
