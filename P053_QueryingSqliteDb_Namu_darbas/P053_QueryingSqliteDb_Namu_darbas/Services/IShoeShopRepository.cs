using P053_QueryingSqliteDb_Namu_darbas.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Services
{
    public interface IShoeShopRepository
    {
        List<Shoes> GetAllShoes();
        void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity);

    }
}
