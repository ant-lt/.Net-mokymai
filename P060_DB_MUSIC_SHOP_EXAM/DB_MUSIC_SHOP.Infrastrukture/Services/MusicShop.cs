using Castle.Core.Resource;
using DB_MUSIC_SHOP.Infrastrukture.Enums;
using DB_MUSIC_SHOP.Infrastrukture.Interfaces;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using P060_DB_MUSIC_SHOP_EXAM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace DB_MUSIC_SHOP.Infrastrukture.Services
{
    public class MusicShop : IMusicShop
    {
        private readonly IMusicShopRepository _repository;
        private readonly MusisShopMenu menu;
        private readonly MusicShopUI musicShopUI;
        private readonly KeyboardInput keyboardInput;
        private Customer? customer;
        private List<Track> purchaseCard;

        public MusicShop()
        {
            _repository = new MusicShopRepository();
            menu = new MusisShopMenu();
            musicShopUI = new MusicShopUI();
            keyboardInput = new KeyboardInput();
            purchaseCard = new List<Track>();
        }

        public void Begin()
        {
            int input;
            while ((input = menu.EntryMenu()) != (int)Ekey.BACK)
            {
                Console.WriteLine(input);

                switch (input)
                {
                    case 1:
                        Connect();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        EmployeeOptions();
                        break;

                }
            }
        }


        /// <summary>
        /// Pasirinkus "Prisijungti" turėtų išmesti visus esamus Customers su jiems priklausančiais ID. Pasirinkus ID vartotojas turėtų būti prijungtas prie sistemos ir matyti pirkimo langą.
        /// </summary>
        public void Connect()
        {
            
      
            List<Customer> customers = _repository.GetAllCustomers();
           
            musicShopUI.ShowAllCustomers(customers);

            long selectCustomerID = keyboardInput.InputInt("Pasirinkite vartotojo ID iš sąrašo. ID >");           
           
            customer = customers.Find(c => c.CustomerId == selectCustomerID);

            if (customer != null)
            {
                purchaseCard.Clear();
                Purchase(customer);
            }
            else
            {
                Console.WriteLine($"Klaida! Vartotojas su ID ={selectCustomerID} nerastas.");
                keyboardInput.PressAnyKey();
            }
           
           
        }


        /// <summary>
        /// Pasirinkus "Registruotis" vartotojas turėtų įvesti visus privalomus ir pasirinktinai optional Customer laukus. Jei registracija buvo sėkminga turėtų atsirasti naujas įrašas Customers lentelėje, 
        /// jei registracija nepavyko turėtų atsirasti pranešimas su žinute kodėl registracija nepavyko ir būtų liepiama atnaujinti klaidą išmetusius laukus neišeinant iš registracijos lango.
        /// </summary>
        public void Register()
        {

            Console.Clear();
            Console.WriteLine("[Vartotojo registracija:]");

            string firstName = keyboardInput.InputText("Vardas[būtinas]:", true);
            string lastName = keyboardInput.InputText("Pavardė[būtinas]:", true);
            string email = keyboardInput.InputText("El. paštas[būtinas]:", true);
            string? company = keyboardInput.InputText("Company[nebūtinas]:", false);
            string? address = keyboardInput.InputText("Adresas[nebūtinas]:", false);
            string? city = keyboardInput.InputText("Miestas[nebūtinas]:", false);
            string? state = keyboardInput.InputText("State[nebūtinas]:", false);
            string? country = keyboardInput.InputText("Šalis[nebūtinas]:", false);
            string? postalCode = keyboardInput.InputText("Pašto kodas[nebūtinas]:", false);
            string? phone = keyboardInput.InputText("Telefonas[nebūtinas]:", false);
            string? fax = keyboardInput.InputText("Faksas[nebūtinas]:", false);

           Customer customer= new Customer() 
           { 
               FirstName=firstName,
               LastName=lastName,
               Email=email,
               Company=company,
               Address=address,
               City=city,
               State=state,
               Country=country,
               PostalCode=postalCode,
               Phone=phone,
               Fax=fax
           };

            _repository.AddCustomer(customer);

        }

        /// <summary>
        /// Pasirinkus "Darbuotojų Parinktys" programa turėtų paprašyti PIN kodo (Gali būti talpinamas kažkur kode kaip const kintamasis), kurį įvedus turėtų atvesti vartotoją darbuotojo parinkciu. 
        /// </summary>
        public void EmployeeOptions()
        {

            int input;
            while ((input = menu.EmployeesOptions()) != (int)Ekey.BACK)
            {

                switch (input)
                {
                    case 1:
                        ChangeCustomerData();
                        break;
                    case 2:
                        ChangeTrackStatus();
                        break;
                    case 3:
                        Statistics();
                        break;
                }
            }

        }

        public void Purchase(Customer selectedCustomer)
        {
            int input;
            while ((input = menu.PurchaseMenu()) != (int)Ekey.BACK)
            {
                
                switch (input)
                {
                    case 1:
                        Catalogue();
                        break;
                    case 2:
                        AddToCard();
                        break;
                    case 3:
                        ReviewCard();
                        break;
                    case 4:
                        PurchaseHistory();
                        break;

                }
            }
        }

        public void Catalogue()
        {
            int input;
            bool isRunning = true;
            List<Track> tracks = _repository.GetAllActiveTracks();

            do
            {
                musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
                input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: true, searchKeyActive: true, clearScreen: false);
                switch (input)
                {
                    case (int)Ekey.SORT:

                        switch (menu.TracksSortingFunctions())
                        {
                            case 1:
                                tracks.Sort((a, b) => a.Name.CompareTo(b.Name));
                                break;
                            case 2:
                                tracks.Sort((a, b) => b.Name.CompareTo(a.Name));
                                break;
                            case 3:
                                tracks.Sort((a, b) => string.Compare(a.Composer , b.Composer));
                                break;
                            case 4:
                                tracks.Sort(comparison: (a, b) => a.Genre.Name.CompareTo(b.Genre?.Name));
                                break;
                            case 5:
                                //tracks.Sort((a, b) => string.Compare(a.Composer, b.Composer) & string.Compare(a.Album?.Title,b.Album?.Title) );
                                tracks.Sort((a, b) =>
                                {
                                    int ret = string.Compare(a.Composer, b.Composer);
                                    return ret != 0 ? ret : a.Album.Title.CompareTo(b.Album?.Title);
                                });
                                break;
                        }
                        break;

                    case (int)Ekey.SEARCH: 
                        switch (menu.TrackSearchFunctions())
                        {
                            case 1:
                                CatalogueSearchByTrackID(tracks);
                                break;
                            case 2:
                                CatalogueSearchByTrackName(tracks);
                                break;
                            case 3:
                                CatalogueSearchByTrackComposer(tracks);
                                break;
                            case 4:
                                CatalogueSearchByTrackGenre(tracks);
                                break;
                            case 5:
                                CatalogueSearchByTrackComposerAlbum(tracks);
                                break;
                            case 6:
                                CatalogueSearchByTrackMilliseconds(tracks);
                                break;
                        }

                        break;
                    case (int)Ekey.BACK:
                        isRunning = false;
                        break;

                }


            } while (isRunning);

        }

        void CatalogueSearchByTrackID(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            long searchTrackID = keyboardInput.InputInt("Įveskite ieškomo takelio ID->");

            tempTracks = tempTracks.Where(c => c.TrackId == searchTrackID).ToList();
            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);                
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su ID={searchTrackID} nerastas.");
                keyboardInput.PressAnyKey();
            }    

        }

        void CatalogueSearchByTrackName(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            string? searchTrackName = keyboardInput.InputText("Įveskite ieškomo takelio Name->", true);

            tempTracks = tempTracks.Where(c => c.Name == searchTrackName).ToList();
            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Name={searchTrackName} nerastas.");
                keyboardInput.PressAnyKey();
            }

        }

        void CatalogueSearchByTrackComposer(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            string? searchTrackComposer = keyboardInput.InputText("Įveskite ieškomo takelio Composer->", true);

            tempTracks = tempTracks.Where(c => c.Composer == searchTrackComposer).ToList();

            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Composer={searchTrackComposer} nerastas.");
                keyboardInput.PressAnyKey();
            }

        }

        void CatalogueSearchByTrackGenre(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            string? searchTrackGenre = keyboardInput.InputText("Įveskite ieškomo takelio Genre.Name->", true);

            tempTracks = tempTracks.Where(c => c.Genre?.Name == searchTrackGenre).ToList();

            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Genre.Name={searchTrackGenre} nerastas.");
                keyboardInput.PressAnyKey();
            }

        }

        void CatalogueSearchByTrackComposerAlbum(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            
            string? searchTrackComposer = keyboardInput.InputText("Įveskite ieškomo takelio Composer->", true);
            string? searchTrackAlbum = keyboardInput.InputText("Įveskite ieškomo takelio Album.Title->", true);

            tempTracks = tempTracks.Where(c => c.Composer == searchTrackComposer  && c.Album?.Title == searchTrackAlbum ).ToList();

            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Composer={searchTrackComposer} ir Album.Title={searchTrackAlbum} nerastas.");
                keyboardInput.PressAnyKey();
            }

        }

        void CatalogueSearchByTrackMilliseconds(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            long searchTrackMilliseconds = keyboardInput.InputInt("Įveskite ieškomo takelio Milliseconds->");

            tempTracks = tempTracks.Where(c => c.Milliseconds < searchTrackMilliseconds || c.Milliseconds > searchTrackMilliseconds).ToList();
            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Milliseconds mažiau nei {searchTrackMilliseconds} arba daugiau nei {searchTrackMilliseconds} nerastas.");
                keyboardInput.PressAnyKey();
            }
        }

        void CatalogueSearchByTrackAlbumID(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            long searchTrackAlbumID = keyboardInput.InputInt("Įveskite ieškomo takelio Album ID->");

            tempTracks = tempTracks.Where(c => c.AlbumId == searchTrackAlbumID).ToList();
            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su  Album ID= {searchTrackAlbumID} nerastas.");
                keyboardInput.PressAnyKey();
            }
        }

        void CatalogueSearchByTrackAlbumTitle(List<Track> tracks)
        {
            List<Track> tempTracks = new List<Track>();
            tempTracks.AddRange(tracks);

            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS -> Peržiūrėti katalogą]:");
            string? searchTrackAlbumTitle = keyboardInput.InputText("Įveskite ieškomo takelio Album Title->", true);

            tempTracks = tempTracks.Where(c => c.Album?.Title == searchTrackAlbumTitle).ToList();
            if (tempTracks.Count > 0)
            {
                tracks.Clear();
                tracks.AddRange(tempTracks);
            }
            else
            {
                Console.WriteLine($"Klaida! - Track su Album Title= {searchTrackAlbumTitle} nerastas.");
                keyboardInput.PressAnyKey();
            }

        }

        void AddToCard()
        {
            int input;    
            bool isRunning = true;
            
            do
            {
                List<Track> tracks = _repository.GetAllActiveTracks();
                input = menu.AddToCardTracksSearchOptions();

                switch (input)
                {
                    case 1:
                        AddToCardByTrackID(tracks);
                        break;
                    case 2:
                        AddToCardByTrackName(tracks);
                        break;
                    case 3:
                        AddToCardByTrackAlbumId(tracks);
                        break;
                    case 4:
                        AddToCardByTrackAlbumTitle(tracks);
                        break;
                    case (int)Ekey.BACK:
                        isRunning = false;
                        break;
                }

            } while (isRunning);

        }

        void AddToCardByTrackID(List<Track> tracks)
        {
            CatalogueSearchByTrackID(tracks);
            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS->Įdėti į krepšelį->Rastos dainos]");

            int input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: true, addKeyText: "Įdedi į krepšelį visas rastas dainas", sortKeyActive: false, searchKeyActive: false, clearScreen: false);

            if (input == (int)Ekey.ADD)
            {
                purchaseCard.AddRange(tracks);
            }
        }

        void AddToCardByTrackName(List<Track> tracks)
        {
            CatalogueSearchByTrackName(tracks);
            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS->Įdėti į krepšelį->Rastos dainos]");

            int input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: true, addKeyText: "Įdedi į krepšelį visas rastas dainas", sortKeyActive: false, searchKeyActive: false, clearScreen: false);

            if (input == (int)Ekey.ADD)
            {
                purchaseCard.AddRange(tracks);
            }

        }

        void AddToCardByTrackAlbumId(List<Track> tracks)
        {
            CatalogueSearchByTrackAlbumID(tracks);
            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS->Įdėti į krepšelį->Rastos dainos]");

            int input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: true, addKeyText: "Įdedi į krepšelį visas rastas dainas", sortKeyActive: false, searchKeyActive: false, clearScreen: false);

            if (input == (int)Ekey.ADD)
            {
                purchaseCard.AddRange(tracks);
            }

        }

        void AddToCardByTrackAlbumTitle(List<Track> tracks)
        {

            CatalogueSearchByTrackAlbumTitle(tracks);
            musicShopUI.ShowCatalogue(tracks, "[PIRKIMO EKRANAS->Įdėti į krepšelį->Rastos dainos]");

            int input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: true, addKeyText: "Įdedi į krepšelį visas rastas dainas", sortKeyActive: false, searchKeyActive: false, clearScreen: false);

            if (input == (int)Ekey.ADD)
            {
                purchaseCard.AddRange(tracks);
            }

        }

        void ReviewCard()
        {                     
            musicShopUI.ShowCatalogue(purchaseCard, "[PIRKIMO EKRANAS->Peržiūrėti krepšelį]:");
            int input = keyboardInput.GetMenuChoose(menuText: "", maxMenuItemsCount: 0, inputVisible: false, addKeyActive: true, addKeyText: "Užbaigti pirkimą", sortKeyActive: false, searchKeyActive: false, clearScreen: false);

            if (input == (int)Ekey.ADD)
            {
                _repository.AddPurchase(customer, purchaseCard);
                keyboardInput.PressAnyKey();
                //istriname esama krepseli
                purchaseCard.Clear();
            }
        }

        void PurchaseHistory()
        {
            List<Invoice>  invoices= _repository.GetAllInvoicesByCustomer(customer);

            musicShopUI.ShowCustomerPurchaseHistory(customer, invoices);
            keyboardInput.PressAnyKey();
        }


        void ChangeCustomerData()
        {
            List<Customer> customers = _repository.GetAllCustomers();
            int input;
            long selectCustomerID;
            while ((input = menu.ChangeCustomerDataOptions()) != (int)Ekey.BACK)
            {
                switch (input)
                {
                    case 1:
                        musicShopUI.ShowAllCustomers(customers);
                        keyboardInput.PressAnyKey();
                        break;
                    case 2:
                        musicShopUI.ShowAllCustomers(customers);
                        selectCustomerID = keyboardInput.InputInt("Pasirinkite vartotojo ID iš sąrašo. ID >");
                        customer = customers.Find(c => c.CustomerId == selectCustomerID);
                        if (customer != null)
                            DeleteCustomer(customer);
                        else
                        {
                            Console.WriteLine($"Klaida! Vartotojas su ID ={selectCustomerID} nerastas.");
                            keyboardInput.PressAnyKey();
                        }

                        break;
                    case 3:
                        musicShopUI.ShowAllCustomers(customers);
                        selectCustomerID = keyboardInput.InputInt("Pasirinkite vartotojo ID iš sąrašo. ID >");
                        customer = customers.Find(c => c.CustomerId == selectCustomerID);
                        if (customer != null)
                            ChangeExistingCustomerData(customer);
                        else
                        {
                            Console.WriteLine($"Klaida! Vartotojas su ID ={selectCustomerID} nerastas.");
                            keyboardInput.PressAnyKey();
                        }
                        break;

                }
            }

        }

        void DeleteCustomer(Customer customer)
        {
            if (keyboardInput.ChooseYesOrNo($"Pašalinti pirkėją ID= {customer.CustomerId}"))
            { 
                _repository.DeleteCustomer(customer);  
            }
        }

        void ChangeExistingCustomerData(Customer customer)
        {
            Console.Clear();
            Console.WriteLine($"[Modifikuoti pirkėjo ID ={customer.CustomerId} duomenis]:");

            string firstName = keyboardInput.InputText($"Vardas[būtinas] {customer.FirstName} keičiamas į:", true);
            string lastName = keyboardInput.InputText($"Pavardė[būtinas] {customer.LastName} keičiamas į:", true);
            string email = keyboardInput.InputText($"El. paštas[būtinas] {customer.Email} keičiamas į:", true);
            string? company = keyboardInput.InputText($"Company[nebūtinas] {customer.Company} keičiamas į:", false);
            string? address = keyboardInput.InputText($"Adresas[nebūtinas] {customer.Address} keičiamas į:", false);
            string? city = keyboardInput.InputText($"Miestas[nebūtinas] {customer.City} keičiamas į:", false);
            string? state = keyboardInput.InputText($"State[nebūtinas] {customer.State} keičiamas į:", false);
            string? country = keyboardInput.InputText($"Šalis[nebūtinas] {customer.Country} keičiamas į:", false);
            string? postalCode = keyboardInput.InputText($"Pašto kodas[nebūtinas] {customer.PostalCode} keičiamas į:", false);
            string? phone = keyboardInput.InputText($"Telefonas[nebūtinas] {customer.Phone} keičiamas į:", false);
            string? fax = keyboardInput.InputText($"Faksas[nebūtinas] keičiamas {customer.Fax} į:", false);


            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.Company = company;
            customer.Address = address;
            customer.City = city;
            customer.State = state;
            customer.Country = country;
            customer.PostalCode = postalCode;
            customer.Phone = phone;
            customer.Fax = fax;
            
            _repository.UpdateCustomerData(customer);

        }

        void ChangeTrackStatus()
        {
            int input;

            List<Track> tracks = _repository.GetAllTracks();
            long trackId;
            while ((input = menu.ChangeTrackStatusOptions()) != (int)Ekey.BACK)
            {
                switch (input)
                {
                    case 1:
                        musicShopUI.ShowAllTracks(tracks, "[DARBUOTOJU PARINKTYS EKRANAS->Dainų sąrašas]:");
                        keyboardInput.PressAnyKey();
                        break;
                    case 2:
                        musicShopUI.ShowAllTracks(tracks, "[DARBUOTOJU PARINKTYS EKRANAS->Dainų sąrašas]:");
                        trackId = keyboardInput.InputInt("Pasirinkite dainos ID iš sąrašo. ID >");
                        var track = tracks.Find(c => c.TrackId == trackId);
                        if (track != null)
                           ModifyTrackStatus(track);
                        else
                        {
                            Console.WriteLine($"Klaida! Dainos su ID ={trackId} nerasta.");
                            keyboardInput.PressAnyKey();
                        }
                        break;

                }
            }

        }

        void ModifyTrackStatus(Track track)
        {
            int input;
            bool isRunning = true;

            Console.Clear();
            Console.WriteLine($"Keičiamas dainos ID ={track.TrackId} su statusu [{track.Status}]:");

            while (isRunning )
            {                
                input = menu.TrackStatusOptions();
                switch (input)
                {
                    case 1:
                        track.Status = "Active";
                        _repository.UpdateTrackStatus(track);
                        break;
                    case 2:
                        track.Status = "Inactive";
                        _repository.UpdateTrackStatus(track);
                        break;
                    case (int)Ekey.BACK:
                        break;
                }
                isRunning = false;
            }            
        }

        void Statistics()
        {
            const string pin= "1122";
            int input;

            Console.Clear();
            if (keyboardInput.InputText("Įveskite PIN kodą->", false) == pin )
            {
                while ((input = menu.EmployeesStatistics()) != (int)Ekey.BACK)
                {
                    switch (input)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("PIN kodas neteisingas");
                keyboardInput.PressAnyKey();
            }
        }
    }
}
