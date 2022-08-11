namespace OOP_KlasesSavarankiskaUzduotis7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Uzduotis 7!");
            Uzduotis7();
        }

        /*
         * 
        * Uzduotis 7: Sukurkite 5 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos sukomponuokite (Sudekite rysius tarp ju).
            Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
            Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
            Kiekvienas studentas turi 1 pažymių knygelę.
            Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
            Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
            Inicializuokite klases su duomenimis (turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus, kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. Objektai gali buti skirtingi tarp metodu):       
                Mokyklos pavadinima + Kiekviena mokytoja kartu su jo mokiniu vardais
                   (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
                   (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki
         */
    
        public static void Uzduotis7()
        {
            /* mano pradine versija
            Mokykla mokykla1 = new Mokykla();
            mokykla1.Pavadinimas = "mokykla1";

            
            Mokykla mokykla2 = new Mokykla();
            mokykla2.Pavadinimas = "mokykla2";



            Mokytojas mokytojas1 = new Mokytojas();
            mokytojas1.Vardas = "Mokytojas 1";
            Mokytojas mokytojas2 = new Mokytojas();
            mokytojas2.Vardas = "Mokytojas 2";

            mokykla1.Mokytojai.Add(mokytojas1);
            mokykla1.Mokytojai.Add(mokytojas2);


            Studentas studentas1= new Studentas();
            studentas1.Vardas = "Studentas1";   
            mokytojas1.Studentai.Add(studentas1);

            Studentas studentas2 = new Studentas();
            studentas2.Vardas = "Studentas2";
            mokytojas2.Studentai.Add(studentas2);


            PazymiuKnygele pazymiuKnygele1 = new PazymiuKnygele();

            Pamoka pamoka1 = new Pamoka();
            pamoka1.Pavadinimas = "Biologija";
            pamoka1.Pazymiai.Add(5);
            pamoka1.Pazymiai.Add(7);
            pamoka1.Pazymiai.Add(8);


            Pamoka pamoka2 = new Pamoka();
            pamoka2.Pavadinimas = "Matematika";
            pamoka2.Pazymiai.Add(8);
            pamoka2.Pazymiai.Add(9);
            pamoka2.Pazymiai.Add(10);

            pazymiuKnygele1.Pamokos.Add(pamoka1);
            pazymiuKnygele1.Pamokos.Add(pamoka2);

            studentas1.PazymiuKnygele = pazymiuKnygele1;




            foreach (var mokytojas in mokykla1.Mokytojai)
            {
                Console.WriteLine($"Mokykla: {mokykla1.Pavadinimas} Mokytojas: {mokytojas.Vardas}");
                foreach (var studentas in mokytojas.Studentai)
                {
                    Console.WriteLine($"Studentas: {studentas.Vardas} ");
                }
                
            }

            */
 
        }

        static void AtspausdintiMokykla(Mokykla mokykla)
        {
            Console.WriteLine($"Mokyklos pavadinimas: {mokykla.Pavadinimas}");
            foreach (var mokytojas in mokykla.Mokytojai)
            {
                Console.WriteLine($"Mokytojas: {mokytojas.Vardas}");
                foreach (var mokinys in mokytojas.Studentai)
                {
                    Console.WriteLine($"Mokinio vardas: {mokinys.Vardas}");
                }
            }
        }

        static void AtspausdintiMokiniuVidurkius(Mokykla mokykla)
        {
            foreach (var mokytojas in mokykla.Mokytojai)
            {
                foreach (var mokinys in mokytojas.Studentai)
                {
                    foreach (var pamoka in mokinys.PazymiuKnygele.Pamokos)
                    {

                        Console.WriteLine($"Mokinys: {mokinys.Vardas}\nPamoka: {pamoka} - {ApskaiciuotiVidurki(pamoka.Value)}\n");
                    }
                }
            }
        }

        static double ApskaiciuotiVidurki(List<int> pazymiai)
        {
            var vidurkis = 0;
            foreach (var pazymys in pazymiai)
            {
                vidurkis += pazymys;
            }

            vidurkis = vidurkis / pazymiai.Count;

            return vidurkis;
        }

    }
}