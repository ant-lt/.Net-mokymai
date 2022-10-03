using Microsoft.EntityFrameworkCore;
using P060_DB_MUSIC_SHOP_EXAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MUSIC_SHOP.Infrastrukture.Interfaces
{
    public interface IMusicShopRepository
    {
        List<Customer> GetAllCustomers();
        List<Track> GetAllActiveTracks();
        List<Track> GetAllTracks();
        List<Invoice> GetAllInvoicesByCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void AddCustomer(Customer customer);
        void AddPurchase(Customer customer, List<Track> tracks);
        void UpdateCustomerData(Customer customer);
        void UpdateTrackStatus(Track track);
    }
}
