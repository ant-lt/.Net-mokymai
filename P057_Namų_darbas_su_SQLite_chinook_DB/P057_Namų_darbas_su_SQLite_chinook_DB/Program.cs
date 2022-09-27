using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P057_Namų_darbas_su_SQLite_chinook_DB.Database;
using P057_Namų_darbas_su_SQLite_chinook_DB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

namespace P057_Namų_darbas_su_SQLite_chinook_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, Namų_darbas_su_SQLite_chinook_DB!");
            // DB https://www.sqlitetutorial.net/sqlite-sample-database/ importas:
            // projektas turi buti startup'inis
            // Install NuGet packages: 
            // Microsoft.EntityFrameworkCore.Sqlite
            // Microsoft.EntityFrameworkCore.Tools
            // Package Manager Console >Scaffold-DbContext "DataSource=C:\Project\CA Mokymai\P057_Namų_darbas_su_SQLite_chinook_DB\P057_Namų_darbas_su_SQLite_chinook_DB\chinook.db" Microsoft.EntityFrameworkCore.Sqlite
            // Sukurti Direktorijas Database, Models ir sudeti klases.
            // chinookContext pervardinti su didele raide pradzioje

            //            Uzd2();
            //            Uzd3();
            //           Uzd4();
            // Uzd5();
            // Uzd6();
            // Uzd7();
            // Uzd8();
            // Uzd9();
            // Uzd10();
            // Uzd11();
            // Uzd12();
            // Uzd13();
            // Uzd14();
            // Uzd15();
            //Uzd16();
            // Uzd17();
            Uzd18();

        }
        /*
           Naudokite Chinook DB https://www.sqlitetutorial.net/sqlite-sample-database/
            1. Pagal duomenų bazės struktūrą modelius ir DbContext
        */


        /*   2. Prašykite metodą, kuris pagal pateiktą 'Country' grąžintų visus 'customers' iš tos šalies 
        *       (vardą, kliento id ir šalies pavadinimą)
        */
        public static void Uzd2()
        {
            Console.WriteLine("Užduotis 2");
            Console.WriteLine("Pagal pateiktą 'Country' grąžintų visus 'customers' iš tos šalies. Pasirinkta šalis: Brazil");
            var salys = GetCustomerByCountry("Brazil");

            foreach (var salis in salys)
            {
                Console.WriteLine(salis.Vardas + " " + salis.KlientoId + " " + salis.SaliesPavadinimas);
            }
        }


        /// <summary>
        /// Pagal pateiktą 'Country' grąžintų visus 'customers' iš tos šalies
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetCustomerByCountry (string country)
        {
          
            using (var ctx = new ChinookContext())
            {
                var res = ctx.Customers.Where (c => c.Country == country).Select(x => new
                {
                    Vardas = x.FirstName,
                    KlientoId = x.CustomerId,
                    SaliesPavadinimas = x.Country
                });

                return res.ToList();
            }

        }


        /*
          3. Prašykite metodą, kuris pagal pateiktą kliento 'Country' grąžintų visus 'invoice' iš tos šalies
                (kliento pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis)
                // yra tipo problema Invoice laukas InvoiceDate pakeisti i DateTime
        */
        public static void Uzd3()
        {
            Console.WriteLine("Užduotis 3");
            Console.WriteLine("Pagal pateiktą kliento 'Country' grąžintų visus 'invoice' iš tos šalies. Šalis: Brazil");
            var invoices = GetInvoiceByCountry("Brazil");

            foreach(var invoice in invoices)
            {
                Console.WriteLine(invoice.KlientoVardas + " " + invoice.SaskaitosID + " " + invoice.SaskaitosData + " " + invoice.SaskaitosSalis);
            }


        }


        /// <summary>
        /// Pagal pateiktą kliento 'Country' grąžina visus 'invoice' iš tos šalies.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoiceByCountry(string country)
        {

            using (var ctx = new ChinookContext())
            {
                //var res = ctx.Invoices.Include(Customer => Customer.CustomerId).Where(Customer => Customer.Country == country);
                var res = from i in ctx.Invoices // outer sequence
                                join c in ctx.Customers on i.CustomerId equals c.CustomerId // key selector 
                                where c.Country == country
                                select new
                                {
                                    KlientoVardas = c.FirstName +" "+ c.LastName,
                                    SaskaitosID = i.InvoiceId,
                                    SaskaitosData = i.InvoiceDate,
                                    SaskaitosSalis = i.BillingCountry
                                };

                return res.ToList();
            }

        }

        /*
         *  4. Prašykite metodą, kuris darbuotojus 'employees' grąžina sugrupuotus pagal pavadinimą 'Title'
         */
        public static void Uzd4()
        {
            Console.WriteLine("Užduotis 4");
            Console.WriteLine("Darbuotojus 'employees' grąžina sugrupuotus pagal pavadinimą 'Title'");
            var employees = GetAllEmployeesGruopByTitle();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key);
            }
        }

        /// <summary>
        /// Visus darbuotojus 'employees' grąžina sugrupuotus pagal pavadinimą 'Title'
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetAllEmployeesGruopByTitle()
        {

            using (var ctx = new ChinookContext())
            {

                var res = ctx.Employees.Select(x => x).ToList().GroupBy(x => x.Title);

                return res.ToList();
            }

        }

        /*
         *  5. Prašykite metodą, kuris grąžina tik unikalius šalių pavadinimus iš 'customers' lentelės
         */
        public static void Uzd5()
        {
            Console.WriteLine("Užduotis 5");
            Console.WriteLine("Grąžina tik unikalius šalių pavadinimus iš 'customers' lentelės");
            var countryes = GetAllUniqueCountrys();

            foreach (var country in countryes)
            {
                Console.WriteLine(country);
            }
        }


        /// <summary>
        /// Grąžina visus tik unikalius šalių pavadinimus iš 'customers' lentelės
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetAllUniqueCountrys()
        {

            using (var ctx = new ChinookContext())
            {

                var res = ctx.Customers.Select(s =>s.Country).Distinct().OrderBy(c => c);
                
                return res.ToList();
            }

        }


        /*
         *   6. Prašykite metodą, kuris grąžina tik tas sąskaitas už kurias atsakingi 'Sales Support Agent'. 
                (darbuotojo pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis, suma)
         * 
         */
        public static void Uzd6()
        {
            Console.WriteLine("Užduotis 6");
            Console.WriteLine("Grąžina tik tas sąskaitas už kurias atsakingi 'Sales Support Agent'");

            var invoices = GetInvoicesForSalesSupportAgent();
            
            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina tik tas sąskaitas už kurias atsakingi 'Sales Support Agent'
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoicesForSalesSupportAgent()
        {

            using (var ctx = new ChinookContext())
            {

                var res = from i in ctx.Invoices // outer sequence
                          join c in ctx.Customers on i.CustomerId equals c.CustomerId // key selector 
                          join em in ctx.Employees on c.SupportRepId equals em.EmployeeId
                          where em.Title == "Sales Support Agent"
                          select new
                          {
                              Darbuotojas = em.FirstName + " " + em.LastName,
                              SaskaitosID = i.InvoiceId,
                              SaskaitosData = i.InvoiceDate,
                              SaskaitosSalis = i.BillingCountry,
                              SaskaitosSuma = i.Total
                          };


                return res.ToList();
            }

        }

        /*
         * 7. Prašykite metodą, kuris grąžina kiek sąskaitų buvo išrašyta už metus
         * 
         */

        public static void Uzd7()
        {
            Console.WriteLine("Užduotis 7");
            Console.WriteLine("Grąžina kiek sąskaitų buvo išrašyta už metus:");
            var invoices = GetInvoicesCountByYears();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina kiek sąskaitų buvo išrašyta už metus.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoicesCountByYears()
        {

            using (var ctx = new ChinookContext())
            {
                //https://stackoverflow.com/questions/11574474/linq-get-sum-of-data-group-by-date
                var selectedData =
                                from s in ctx.Invoices
                                select new
                                {
                                    Year = s.InvoiceDate.Value.Year,
                                    Total = s.Total
                                };

                var groupedData = from s in selectedData.ToList()
                                  group s by s.Year into g
                                  select new 
                                  {
                                      Metai = g.Key,
                                      SaskaituKiekis = g.Count(),
                                  };
                                 

                return groupedData.ToList();
            }

        }

        /*
         * 8. Prašykite metodą, kuris grąžina kiek prekių (invoice_items) buvo parduota su kiekviena sąskaita 
         * 
         */

        public static void Uzd8()
        {
            Console.WriteLine("Užduotis 8");
            Console.WriteLine("Grąžina kiek prekių (invoice_items) buvo parduota su kiekviena sąskaita");
            var invoices = GetInvoiceItemsCountByInvoice();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina kiek prekių (invoice_items) buvo parduota su kiekviena sąskaita.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoiceItemsCountByInvoice()
        {

            using (var ctx = new ChinookContext())
            {
                var groupedData = from s in ctx.InvoiceItems.ToList()
                                  group s by s.InvoiceId into g
                                  select new
                                  {
                                      SaskaitosNr = g.Key,
                                      PrekiuKiekis = g.Count()
                                  };


                return groupedData.ToList();
            }
        }

        /*
         *   9. Prašykite metodą, kuris grąžina kiek kiekvienoje kliento valstybėje buvo išrašyta sąskaitų 
         * 
         */
        public static void Uzd9()
        {
            Console.WriteLine("Užduotis 9");
            Console.WriteLine("Grąžina kiek kiekvienoje kliento valstybėje buvo išrašyta sąskaitų.");
            var invoices = GetInvoiceCountByCountry();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina kiek kiekvienoje kliento valstybėje buvo išrašyta sąskaitų.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoiceCountByCountry()
        {

            using (var ctx = new ChinookContext())
            {
                var SelectData = (from i in ctx.Invoices // outer sequence
                          join c in ctx.Customers on i.CustomerId equals c.CustomerId // key selector                           
                          where c.Country == i.BillingCountry                         
                          select new
                          {
                              SaskaitosID = i.InvoiceId,
                              KlientoSalis = c.Country,
                            
                          }).ToList();

                var groupedData = SelectData.GroupBy(c => c.KlientoSalis).Select(item => new 
                {
                    KlientoSalis = item.Key,
                    SaskaituKiekis = item.Count()
                });
                    
             
                return groupedData.ToList();
            }
        }

        /*
         *   10. Prašykite metodą, kuris grąžina kiek prekių (invoice_items) buvo parduota su kiekvienoje kliento valstybėje 
         */

        public static void Uzd10()
        {
            Console.WriteLine("Užduotis 10");
            Console.WriteLine("Grąžina kiek prekių (invoice_items) buvo parduota su kiekvienoje kliento valstybėje");
            var invoices = GetInvoiceItemsCountByCountry();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina kiek prekių (invoice_items) buvo parduota su kiekvienoje kliento valstybėje.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoiceItemsCountByCountry()
        {

            using (var ctx = new ChinookContext())
            {
                var SelectData = (from ii in ctx.InvoiceItems
                                  join i in ctx.Invoices on ii.InvoiceId equals  i.InvoiceId
                                  join c in ctx.Customers on i.CustomerId equals c.CustomerId 
                                  where c.Country == i.BillingCountry
                                  select new
                                  {
                                      SaskaitosEilutes = ii.InvoiceLineId,
                                      KlientoSalis = c.Country
                                  }).ToList();

                var groupedData = SelectData.GroupBy(c => c.KlientoSalis).Select(item => new
                {
                    KlientoSalis = item.Key,
                    PrekiuKiekis = item.Count()
                });


                return groupedData.ToList();
            }
        }

        /*
         * 11. Prašykite metodą, kuris grąžina nupirko (invoice_items) 'track' pavadinimą ir 'artist' vardą
         * 
         */

        public static void Uzd11()
        {
            Console.WriteLine("Užduotis 11");
            Console.WriteLine("Grąžina nupirko (invoice_items) 'track' pavadinimą ir 'artist' vardą.");

            var invoices = GetInvoiceItemsTrackArtist();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }

        /// <summary>
        /// Grąžina nupirko (invoice_items) 'track' pavadinimą ir 'artist' vardą.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetInvoiceItemsTrackArtist()
        {

            using (var ctx = new ChinookContext())
            {
 
                var SelectData = (from ii in ctx.InvoiceItems
                                  join t in ctx.Tracks on ii.TrackId equals t.TrackId
                                  join al in ctx.Albums on t.AlbumId equals al.AlbumId
                                  join ar in ctx.Artists on al.ArtistId equals ar.ArtistId
                                  select new
                                  {
                                      TrackName = t.Name,
                                      ArtistName = ar.Name
                                  }).ToList();



                return SelectData;
            }
        }

        /*
         *             12. Prašykite metodą, kuris grąžina kiek 'tracks' yra kiekviename 'playlist' 
                (playlist pavadinimas, kiekis)
         * 
         */

        public static void Uzd12()
        {
            Console.WriteLine("Užduotis 12");
            Console.WriteLine("Grąžina kiek 'tracks' yra kiekviename 'playlist'.");

            var tracks = GetTracksOnPlaylist();

            foreach (var track in tracks)
            {
                Console.WriteLine(track);
            }
        }

        /// <summary>
        /// Grąžina kiek 'tracks' yra kiekviename 'playlist'.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetTracksOnPlaylist()
        {

            using (var ctx = new ChinookContext())
            {

                var SelectData = (from pl in ctx.Playlists
                                  join tr in ctx.Tracks on pl.PlaylistId equals tr.TrackId
                                  select new
                                  {
                                      TrackName = tr.Name,
                                      PlaylistName = pl.Name
                                  }).ToList();

                var groupedData = SelectData.GroupBy(c => c.PlaylistName).Select(item => new
                {
                    PlaylistName = item.Key,
                    TrackKiekis = item.Count()
                });

                return groupedData.ToList();
            }
        }

        /*
         * 13. Prašykite metodą, kuris grąžina kurie metai buvo patys pelningiausi
         * 
         */

        public static void Uzd13()
        {
            Console.WriteLine("Užduotis 13");
            Console.WriteLine("Grąžina kurie metai buvo patys pelningiausi.");
            var yearsRevenueList = GetYearsRevenue();

            foreach (var yearRevenue in yearsRevenueList)
            {
                Console.WriteLine(yearRevenue);
            }
        }

        /// <summary>
        /// Grąžina kurie metai buvo patys pelningiausi.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetYearsRevenue()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData =
                                from s in ctx.Invoices
                                select new
                                {
                                    Year = s.InvoiceDate.Value.Year,
                                    Total = s.Total
                                };

                var groupedData = from s in selectedData.ToList()
                                  group s by s.Year into g
                                  select new
                                  {
                                      Metai = g.Key,
                                      Suma = g.Sum(x => x.Total)
                                  };
                var bestYearRecord = (from u in groupedData.ToList()
                                      orderby u.Suma descending
                                      select u).Take(1);
                               

                return bestYearRecord;
            }
        }

        /*
         * 14. Prašykite metodą, kuris grąžina top 5 parduodamus 'tracks'
         */

        public static void Uzd14()
        {
            Console.WriteLine("Užduotis 14");
            Console.WriteLine("Grąžina top 5 parduodamus 'tracks'.");
            var tracksTop5 = GetTop5TracksSales();

            foreach (var track in tracksTop5)
            {
                Console.WriteLine(track);
            }
        }

        /// <summary>
        /// Grąžina top 5 parduodamus 'tracks'.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetTop5TracksSales()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData =(from ii in ctx.InvoiceItems
                                 join t in ctx.Tracks on ii.TrackId equals t.TrackId
                                 select new
                                 {
                                     TrackName = t.Name,
                                     Quantity = ii.Quantity
                                 }).ToList();

                var groupedData = from s in selectedData
                                  group s by s.TrackName into g
                                  select new
                                  {
                                      TrackName = g.Key,
                                      TotalSales = g.Sum(x => x.Quantity)
                                  };
                var top5Records = (from u in groupedData.ToList()
                                      orderby u.TotalSales descending
                                      select u).Take(5);


                return top5Records;
            }
        }

        /*
         * 15. Prašykite metodą, kuris grąžina top 3 parduodamus 'artists'
         * 
         */

        public static void Uzd15()
        {
            Console.WriteLine("Užduotis 15");
            Console.WriteLine("Grąžina top 3 parduodamus 'artists'");
            var artistsTop3 = GetTop3ArtistsSales();

            foreach (var artist in artistsTop3)
            {
                Console.WriteLine(artist);
            }
        }

        /// <summary>
        /// Grąžina top 3 parduodamus 'artists'.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetTop3ArtistsSales()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData = (from ii in ctx.InvoiceItems
                                  join t in ctx.Tracks on ii.TrackId equals t.TrackId
                                  join al in ctx.Albums on t.AlbumId equals al.AlbumId
                                  join ar in ctx.Artists on al.ArtistId equals ar.ArtistId
                                  select new
                                  {
                                      ArtistName = ar.Name,
                                      Quantity = ii.Quantity
                                  }).ToList();


                var groupedData = from s in selectedData
                                  group s by s.ArtistName into g
                                  select new
                                  {
                                      ArtistName = g.Key,
                                      TotalSales = g.Sum(x => x.Quantity)
                                  };
                var top3Records = (from u in groupedData.ToList()
                                   orderby u.TotalSales descending
                                   select u).Take(3);

                return top3Records;
            }
        }

        /*
         * 16. Prašykite metodą, kuris grąžina top 2 parduodamus 'genres'
         */
        public static void Uzd16()
        {
            Console.WriteLine("Užduotis 16");
            Console.WriteLine("Grąžina top 2 parduodamus 'genres'");
            var genresTop2 = GetTop2GenresSales();

            foreach (var genre in genresTop2)
            {
                Console.WriteLine(genre);
            }
        }

        /// <summary>
        /// Grąžina top 2 parduodamus 'genres'.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetTop2GenresSales()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData = (from ii in ctx.InvoiceItems
                                    join t in ctx.Tracks on ii.TrackId equals t.TrackId
                                    join gnr in ctx.Genres on t.GenreId equals gnr.GenreId
                                    select new
                                    {
                                        GenreName = gnr.Name,
                                        Quantity = ii.Quantity
                                    }).ToList();


                var groupedData = from s in selectedData
                                  group s by s.GenreName into g
                                  select new
                                  {
                                      GenreName = g.Key,
                                      TotalSales = g.Sum(x => x.Quantity)
                                  };
                var top2Records = (from u in groupedData.ToList()
                                   orderby u.TotalSales descending
                                   select u).Take(2);

                return top2Records;
            }
        }

        /*
         * 17. Prašykite metodą, kuris grąžina top 1 parduodamą 'media_types'
         */

        public static void Uzd17()
        {
            Console.WriteLine("Užduotis 17");
            Console.WriteLine("Grąžina top 1 parduodamus 'media_types'");
            var mediaTypesTop1 = GetTop1MediaTypesSales();

            foreach (var media in mediaTypesTop1)
            {
                Console.WriteLine(media);
            }
        }

        /// <summary>
        /// Grąžina top 1 parduodamus 'media_types'.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetTop1MediaTypesSales()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData = (from ii in ctx.InvoiceItems
                                    join t in ctx.Tracks on ii.TrackId equals t.TrackId
                                    join md in ctx.MediaTypes on t.MediaTypeId equals md.MediaTypeId
                                    select new
                                    {
                                        MediaName = md.Name,
                                        Quantity = ii.Quantity
                                    }).ToList();


                var groupedData = from s in selectedData
                                  group s by s.MediaName into g
                                  select new
                                  {
                                      MediaName = g.Key,
                                      TotalSales = g.Sum(x => x.Quantity)
                                  };
                var top1Record = (from u in groupedData.ToList()
                                   orderby u.TotalSales descending
                                   select u).Take(1);

                return top1Record;
            }
        }

        /*
         *  18. Prašykite metodą, kuris grąžina kiekvienoje šalyje yra klientų
         */

        public static void Uzd18()
        {
            Console.WriteLine("Užduotis 18");
            Console.WriteLine("Grąžina kiekvienoje šalyje yra klientų");
            var countrys = GetCustomersCountByCountry();

            foreach (var country in countrys)
            {
                Console.WriteLine(country);
            }
        }

        /// <summary>
        /// Prašykite metodą, kuris grąžina kiekvienoje šalyje yra klientų.
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<dynamic> GetCustomersCountByCountry()
        {

            using (var ctx = new ChinookContext())
            {

                var selectedData = (from c in ctx.Customers
                                    select new
                                    {
                                        Country = c.Country,
                                    }).ToList();


                var groupedData = from s in selectedData
                                  group s by s.Country into g
                                  select new
                                  {
                                      CountryName = g.Key,
                                      CountOfCustomers = g.Count()
                                  };
                var countryRecords = (from u in groupedData.ToList()
                                  orderby u.CountOfCustomers descending
                                  select u);

                return countryRecords;
            }
        }

    }
}