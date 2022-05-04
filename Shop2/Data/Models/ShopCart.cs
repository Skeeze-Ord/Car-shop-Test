using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Models
{

    public class ShopCart
    {

        private readonly AppDBContent _appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }

        public string ShopCartId;

        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            this._appDBContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Сar = car,
                Price = Math.Abs((int)car.Price)
            });

            _appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDBContent.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Сar).ToList();
        }
    }
}
