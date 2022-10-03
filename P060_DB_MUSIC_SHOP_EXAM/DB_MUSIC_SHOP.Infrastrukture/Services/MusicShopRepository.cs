using DB_MUSIC_SHOP.Infrastrukture.Database;
using DB_MUSIC_SHOP.Infrastrukture.Interfaces;
using P060_DB_MUSIC_SHOP_EXAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MUSIC_SHOP.Infrastrukture.Services
{
    public class MusicShopRepository: IMusicShopRepository
    {
        private readonly chinookContext _context = new chinookContext();

        public MusicShopRepository()
        {
         
        }

        public MusicShopRepository(chinookContext chinookContext)
        {
            _context = chinookContext;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void AddPurchase(Customer customer, List<Track> tracks)
        {
            decimal totalInvoice = 0;
            Invoice invoice = new Invoice()
            { Customer = customer,
                InvoiceDate = DateTime.Now,
                BillingAddress = customer.Address,
                BillingCity = customer.City,
                BillingCountry = customer.Country,
                BillingState = customer.State,
                BillingPostalCode = customer.PostalCode,
            };

            foreach (var track in tracks)
            {
                InvoiceItem invoiceItem = new InvoiceItem()
                {
                    TrackId = track.TrackId,
                    UnitPrice = track.UnitPrice,
                    Quantity = 1
                };
                invoice.InvoiceItems.Add(invoiceItem);
                totalInvoice = totalInvoice + track.UnitPrice;
            }
            invoice.Total = totalInvoice;
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public List<Track> GetAllActiveTracks()
        {
            return _context.Tracks.Where( t => t.Status == "Active").ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public List<Invoice> GetAllInvoicesByCustomer(Customer customer)
        {
            return _context.Invoices.Where( t => t.Customer == customer).ToList();
        }

        public List<Track> GetAllTracks()
        {
            return _context.Tracks.ToList();
        }

        public void UpdateCustomerData(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void UpdateTrackStatus(Track track)
        {
            _context.Update(track);
            _context.SaveChanges();
        }
    }
}
