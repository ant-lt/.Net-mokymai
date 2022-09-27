using Microsoft.EntityFrameworkCore;
using P053_QueryingSqliteDb_Namu_darbas.Database.Models;
using P053_QueryingSqliteDb_Namu_darbas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Database
{
    public class ShoeShopRepository: IShoeShopRepository
    {
        private readonly ShoeShopContext _context;

        public ShoeShopRepository(ShoeShopContext context)
        {
            _context = context;
            //_context.Database.EnsureCreated();
        }

        public List<Shoes> GetAllShoes() => _context.Shoes.Include(x => x.ShoeSizes).ToList();

        public void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity)
        {
            var sale = new Sale
            {
                ShoeSizeId = shoeSizeId,
                Pairs = quantity
            };

            _context.Add(sale);

            var shoesSize = _context.ShoeSizes.Find(shoeSizeId);

            shoesSize.Quantity = shoesSize.Quantity - quantity;

            _context.SaveChanges();
        }

        public List<Sale> GetAllPurchases()
        {
            using (var context = new ShoeShopContext())
            {
                var Sales = context.Sales;
                return Sales.ToList();
            }
        }

    }
}
