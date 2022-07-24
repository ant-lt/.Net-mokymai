namespace SuperSkaiciuotuvas
{
    /* ## Super Skaiciuotuvas ## 
         Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
         1. Nauja operacija 2 Iseiti. 

         Pasirinkus 1 vada į submeniu:
         1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba

         Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
         o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
         1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
         Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
         Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.

     Pvz:
     > 1. Nauja operacija 2 Iseiti. 
     _1
     > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
     _1
     > pasirinktas veiksmas + 
     > iveskite pirma skaiciu
     _15
     > iveskite antra skaiciu
     _45
     > Rezultatas: 60
     > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
     _2
     > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
     _2
     > pasirinktas veiksmas - 
     > Iveskite skaiciu
     _10
     > Rezultatas: 50
     > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
     _1
     > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
     _2
     > pasirinktas veiksmas * 
       > iveskite pirma skaiciu
     _2
     > iveskite antra skaiciu
     _3
     > Rezultatas: 6
     > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
     _3
     > Baigta



     BONUS1: Iskelkite operacijas i metodus
     BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
             - dalyba is nulio, neteisingu ivesciu prevencija 
             - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
             - neteisingas meniu punkto pasirinkimas
     BONUS3: Parasyti unit testus uztikrinant operaciju veikima
     BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas

        */
    public class Program
    {
        // Globalūs kintamieji
        static double? rezultatas = null;
        static double? skaicius1 = null;
        static double? skaicius2 = null;
        static int? veiksmas = null;
        static int meniu = 0;
        static int klaida = 0;
        static bool testi = true;

        static void Main(string[] args)
        {
            PagrindinisMeniu();
        }


        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            //todo
            klaida = 0;
            if (ivedimas.Length >0 && meniu >= 0 && meniu <= 2 && (skaicius1 == null || skaicius2 == null) && veiksmas == null)
            {
                int ivestis= IntSkaiciausTikrinimas(ivedimas);
                if ((meniu == 0 && ivestis >= 1 && ivestis <= 2) || (meniu == 1 && ivestis >= 1 && ivestis <= 3) || (meniu == 2 && ivestis >= 1 && ivestis <= 6))
                    if ((meniu == 0 && ivestis == 2) || (meniu == 1 && ivestis == 3))
                        testi = false; // iseiti is programos
                    else if ((meniu == 0 && ivestis == 1) || (meniu == 1 && ivestis == 1))
                    {
                        rezultatas = null;
                        meniu = 2; // pasirinkti operacijos
                    }
                    else if (meniu == 2 && (ivestis >= 1 && ivestis <= 6))
                    {
                        veiksmas = ivestis;
                        Console.Write("pasirinktas veiksmas ");
                        switch (veiksmas)
                        {
                            case 1:
                                Console.WriteLine("+");
                                break;
                            case 2:
                                Console.WriteLine("-");
                                break;
                            case 3:
                                Console.WriteLine("*");
                                break;
                            case 4:
                                Console.WriteLine("/");
                                break;
                            case 5:
                                Console.WriteLine("^");
                                break;
                            case 6:
                                Console.WriteLine("√");
                                break;

                            default:
                                break;
                        }

                        if (rezultatas != null)
                        {
                            //jeigu naudojam esama rezultata
                            skaicius1 = rezultatas;
                            if (veiksmas == 6 )
                                skaicius2 = rezultatas; // saknes traukimui naudojame esame rezultata
                            else meniu = 4; // ivesti antra skaiciu
                        }
                        else if(veiksmas == 6)
                        {
                            meniu = 5;
                        }
                        else
                            meniu = 3;// ivesti pirma skaiciu
                    }
                    else
                        meniu = ivestis;
                else
                    klaida = 1;// klaida nera tokio meniu
            }

            // 1 skaiciu ivedimas
            else if (ivedimas.Length > 0 && meniu == 3  && skaicius1 == null && klaida == 0 && veiksmas != null )
            {
                skaicius1 = DoubleSkaiciausTikrinimas(ivedimas);
                if (skaicius1 == null) 
                    klaida = 2;
                else 
                    meniu = 4; 
            }
            // 2 skaiciaus ivedimas
            else if (ivedimas.Length > 0 && (meniu == 4 || meniu == 5) && skaicius2 == null && klaida == 0 && veiksmas != null)
            {
                if (veiksmas == 6 && skaicius1 != null ) // saknes traukimas
                    skaicius2 = skaicius1; // saknes traukimo atveju su esamu rezultatu fiktyviai priskiriam skaicius2 tam, kad butu laikoma kad turime 2 ivestus skaicius ir ivyktu apskaiciavimas 
                else if (veiksmas == 6 && skaicius1 == null)
                    {
                    skaicius2 = DoubleSkaiciausTikrinimas(ivedimas);
                    skaicius1 = skaicius2; // saknes traukimui reikia tik vieno parametro todel fiktyviai priskiriam.
                    }
                else
                    skaicius2 = DoubleSkaiciausTikrinimas(ivedimas);

                
                if (skaicius2 == null)  // ivestas ne skaicius
                    klaida = 2;
                else if (skaicius2 == 0 && veiksmas == 4) // dalyba is nullio
                {
                    klaida = 3;
                    skaicius2 = null; // anuliojame antra skaiciu, kad galima butu ivesti pakartotinai
                }
            }


            if (klaida == 0 && veiksmas != null && skaicius1 != null && skaicius2 != null)
            {
                switch (veiksmas) // jeigu yra 2 skaiciai tada apskaiciuojame rezultata
                {
                    case 1:
                        rezultatas = Sudetis((double)skaicius1, (double)skaicius2);
                        break;
                    case 2:
                        rezultatas = Atimtis((double)skaicius1, (double)skaicius2);
                        break;
                    case 3:
                        rezultatas = Daugyba((double)skaicius1, (double)skaicius2);
                        break;
                    case 4:
                        rezultatas = Dalyba((double)skaicius1, (double)skaicius2);
                        break;
                    case 5:
                        rezultatas = Math.Pow((double)skaicius1, (double)skaicius2);
                        break;
                    case 6:
                        rezultatas = Math.Sqrt((double)skaicius2);
                        break;
                    default:
                        break;
                }
                if (klaida == 0 && rezultatas != null)
                    Console.WriteLine("Rezultatas: {0}", rezultatas);
                skaicius1 = null;
                skaicius2 = null;
                veiksmas = null;
                meniu = 1; // grizti i meniu
            }
        }

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            //todo
            rezultatas = null;
            skaicius1 = null;
            skaicius2 = null;
            veiksmas = null;
            klaida = 0;
            meniu = 0;
        }

        public static void PagrindinisMeniu()
        {
 
            Console.Clear();
            Reset();
            while (testi)
            {
                switch (meniu)
                {
                    case 0:  // pradinis meniu
                        Console.WriteLine("\n1. Nauja operacija. 2. Išeiti");
                        break;
                    case 1: // pagrindinis meniu
                        Console.WriteLine("\n1. Nauja operacija. 2.Testi su rezultatu. 3.Išeiti");
                        break;
                    case 2:   // sub meniu operacijos
                        Console.WriteLine("1.Sudetis 2.Atimtis 3.Daugyba 4.Dalyba 5. Kelimas laipsniu 6. Kvadratinė šaknis");
                        break;
                    case 3: // pirmas skaicius
                        Console.WriteLine("Įveskite pirma skaičiu");
                        break;
                    case 4: // antras skaicius
                        Console.WriteLine("Įveskite antra skaičiu");
                        break;
                    case 5: // antras skaicius
                        Console.WriteLine("Įveskite skaičiu");
                        break;
                    default:
                        
                        break;
                }

                SuperSkaiciuotuvas(Console.ReadLine());

                switch (klaida)
                {
                    case 1:
                        Console.WriteLine("Nėra tokio meniu pasirinkimo.");
                        break;
                    case 2:
                        Console.WriteLine("Neteisingas skaičiaus formatas.");
                        klaida = 0;
                        break;
                    case 3:
                        Console.WriteLine("Dalyba iš nulio.");
                        klaida=0;
                        break;
                    default:
                        break;
                }

            }
        }


        public static double Sudetis(double skaicius1, double skaicius2) => skaicius1 + skaicius2;
        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;
        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;
        public static double Dalyba(double skaicius1, double skaicius2) => skaicius1 / skaicius2;

        private static double? DoubleSkaiciausTikrinimas(string? tekstas) => double.TryParse(tekstas, out double skaicius) ? skaicius : null;
        private static int IntSkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;

    }

}