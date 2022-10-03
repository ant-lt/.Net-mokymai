using Castle.Core.Resource;
using P060_DB_MUSIC_SHOP_EXAM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DB_MUSIC_SHOP.Infrastrukture.Services
{
    public class MusicShopUI
    {
        public void ShowAllCustomers(List<Customer> customers)
        {
            Console.Clear();
            Console.WriteLine("[Pasirinkti klientą]:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|  ID | First Name, Last name                                |");
            Console.WriteLine("--------------------------------------------------------------");

            foreach (Customer customer in customers)
            {
                string fullName = customer.FirstName + ", " + customer.LastName;
                Console.WriteLine($"| {customer.CustomerId,3} | {fullName,-53}|");
            }
            Console.WriteLine("--------------------------------------------------------------");

        }

        public void ShowCatalogue(List<Track> tracks, string headerText)
        {
            Console.Clear();
            Console.WriteLine(headerText);
            Console.WriteLine($"{"".PadRight(202, '-')}");
            Console.WriteLine($"|   ID | Name, Composer, Genre->Name, Album->Title, Milliseconds, Price{"".PadRight(129, ' ')} |");
            Console.WriteLine($"{"".PadRight(202, '-')}");

            foreach (Track track in tracks)
            {
                string line = $"{track.Name}, {track.Composer}, {track.Genre?.Name}, {track.Album?.Title}, {track.Milliseconds}, {track.UnitPrice}";
                Console.WriteLine($"| {track.TrackId,4} |  {line,-190} |");
            }

            Console.WriteLine($"{"".PadRight(202, '-')}");

        }

        public void ShowAllTracks(List<Track> tracks, string headerText)
        {
            Console.Clear();
            Console.WriteLine(headerText);
            Console.WriteLine($"{"".PadRight(191, '-')}");
            Console.WriteLine($"|   ID | Name, Composer, Genre->Name, Album->Title, Milliseconds, Price, Status{"".PadRight(112, ' ')} |");
            Console.WriteLine($"{"".PadRight(191, '-')}");

            foreach (Track track in tracks)
            {
                string line = $"{track.Name}, {track.Composer}, {track.Genre?.Name}, {track.Album?.Title}, {track.Milliseconds}, {track.UnitPrice}, {track.Status}";
                Console.WriteLine($"| {track.TrackId,4} |  {line,-179} |");
            }

            Console.WriteLine($"{"".PadRight(191, '-')}");

        }


        public void ShowCustomerPurchaseHistory(Customer customer, List<Invoice> invoices)
        {
            Console.Clear();
            Console.WriteLine("[PIRKIMO EKRANAS->Peržiūrėti pirkimų istorija (Išrašai)]:");

            foreach (var invoice in invoices)
            {
                // Invoice header
                Console.WriteLine($"InvoiceId: {invoice.InvoiceId}");
                Console.WriteLine($"{"".PadRight(202, '-')}");


                Console.WriteLine($"Name:{customer.FirstName}" + Environment.NewLine
                                + $"Surname:{customer.LastName}" + Environment.NewLine
                                + $"Phone:{customer.Phone}" + Environment.NewLine
                                + $"Address:{customer.Address}" + Environment.NewLine
                                + $"City:{customer.City}" + Environment.NewLine
                                + $"State:{customer.State}" + Environment.NewLine
                                + $"Country:{customer.Country}" + Environment.NewLine
                                + $"PostalCode:{customer.PostalCode}");

                Console.WriteLine($"{"".PadRight(202, '-')}");
                Console.WriteLine($"|   ID | Name, Composer, Genre->Name, Album->Title, Milliseconds, Price{"".PadRight(129, ' ')} |");
                Console.WriteLine($"{"".PadRight(202, '-')}");

                //Invoice items
                foreach (var invoiceItem in invoice.InvoiceItems)
                {
                    string line = $"{invoiceItem.Track.Name}, {invoiceItem.Track.Composer}, {invoiceItem.Track.Genre?.Name}, {invoiceItem.Track.Album?.Title}, {invoiceItem.Track.Milliseconds}, {invoiceItem.Track.UnitPrice}";
                    Console.WriteLine($"| {invoiceItem.Track.TrackId,4} |  {line,-190} |");
                }

                // Invoice total
                Console.WriteLine($"{"".PadRight(202, '-')}");
                decimal? amountWoVat = invoice.Total / (decimal)1.21;

                decimal? amountVat = invoice.Total * (decimal)0.21;

                Console.WriteLine($"Total without Tax: {amountWoVat,0:0.00}" + Environment.NewLine
                                + $"Tax: 21% {amountVat,0:0.00}" + Environment.NewLine
                                 + $"Total: {invoice.Total,0:0.00}");
                Console.WriteLine($"{"".PadRight(202, '-')}");
            }


        }


    }
}
