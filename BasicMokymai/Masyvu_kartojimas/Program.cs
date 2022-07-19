
namespace Masyvu_kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {

            Uzduotis_5();
        }

        /*
         * ## 1.2 Rasti mažiausią ##
      Duotas vienatis sveikų skaičių masyvas.
      Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
      { 5, 3, 7, 6, 8, 7, 10 }
      rezultatas:  3
         * 
         */
        static public void Uzduotis_1()
        {
            int[] masyvas = { 5, 3, 7, 6, 8, 7, 10 };
            MaziausiasSkaiciusMasyve( masyvas);

        }

        static public int MaziausiasSkaiciusMasyve(int[] masyvas)
        {
            int maziausiasSkaicius = masyvas[0];
            for (int i = 1; i < masyvas.Length; i++)
            {
                if (maziausiasSkaicius > masyvas[i]  ) maziausiasSkaicius = masyvas[i];
            }

            return maziausiasSkaicius;
        }

        /*
         * 2. ## Rasti didžiausią ##
       Duotas vienatis sveikų skaičių masyvas.
       Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
       { 5, 3, 7, 6, 8, 7, 10 }
       rezultatas:  10
        */
        static public void Uzduotis_2()
        {
            int[] masyvas = { 5, 3, 7, 6, 8, 7, 10 };
            Console.WriteLine("rezultatas: " +DidziausiasSkaiciusMasyve(masyvas));
        }

        static public int DidziausiasSkaiciusMasyve(int[] masyvas)
        {
            int didziausiasSkaicius = masyvas[0];
            for (int i = 1; i < masyvas.Length; i++)
            {
                if (didziausiasSkaicius < masyvas[i]) didziausiasSkaicius = masyvas[i];
            }

            return didziausiasSkaicius;
        }


        /*
         * 3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
       Duotas vienmatis sveikų skaičių masyvas. 
       Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo 
        mažiausio iki didžiausio
       { 5, 1, 7, 6, 8, 7, 10 }

       rezultatas:  1, 5, 6, 7, 7, 8, 10
         */

        static public void Uzduotis_3()
        {
            int[] masyvas = { 5, 3, 7, 6, 8, 7, 10 };
            int[] suriuokiotas = new int [masyvas.Length];

            suriuokiotas = RikiuotiDidejimoTvarka(masyvas);
            for (int i = 0; i < suriuokiotas.Length; i++)
            {
                Console.WriteLine(suriuokiotas[i]);
            }

        }

        public static int[] RikiuotiDidejimoTvarka(int[] masyvas)
        {

            for (int i = 0; i < masyvas.Length; i++)
            {
                for (int j = i + 1; j < masyvas.Length; j++)
                {
                    if (masyvas[i] > masyvas[j])
                    {
                        int temp = masyvas[i];
                        masyvas[i] = masyvas[j];
                        masyvas[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", masyvas));
            return masyvas;
        }

        /*
         * ## 4. RIKIUOTI TRIS RAIDES ##
Parašykite programą kurioje vienas metodas.
  - Naudotojo paprašome įvesti 3 raides (atskirai).
    Būtina validacija kad įvesta tik vienas simbolis.
  - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
  Pvz:
  > Iveskite pirma raide:
  _ C
  > Iveskite antra raide:
  _ D
  > Iveskite trecia raide:
  _ B
  >  B, C, D
         * 
         * 
         */
        static public void Uzduotis_4()
        {
            char[] raides = new char[3];

            for (int  i = 0;  i < raides.Length ;  i++)
            {
                raides[i] = RaidesIvedimas($"Iveskite {i + 1} raide.");
            }

            Console.WriteLine(string.Join(", ", RikiuotiTrisRaides(raides)));
            
        }

        static public char[] RikiuotiTrisRaides(char[] raides)
        {
           
            for (int i = 0; i < raides.Length; i++)
            {
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] > raides[j])
                    {
                        char temp = raides[i];
                        raides[i] = raides[j];
                        raides[j] = temp;
                    }
                }
            }
            return raides;
        }

        /*
         *     ## 5. RIKIUOTI KETURIAS RAIDES ## 
            - Naudotojo paprašome įvesti 4 raides (atskirai). 
              Būtina validacija kad įvesta tik vienas simbolis. 
            - Metodas priima masyvą iš string (su prielaidai kad kiekvienas string yra tik 1 raide) 
              ir grąžina string (NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -. 
            Pvz: 
            > Iveskite pirma raide:
            _ C
            > Iveskite antra raide:
            _ A
            > Iveskite trecia raide:
            _ B
            > Iveskite ketvirtą raide:
            _ E
            > A-B-C-E
            
         * 
         * 
         */
        static public void Uzduotis_5()
        {
            string[] raides = new string[4];

            for (int i = 0; i < raides.Length; i++)
            {
                raides[i] = RaidesIvedimas($"Iveskite {i + 1} raide.").ToString();
            }

            Console.WriteLine(RikiuotiKeturiasRaides(raides));

        }


        static public string RikiuotiKeturiasRaides(string[] raides)
        {
            char [] charMas = new char[raides.Length];

            for (int i = 0; i < raides.Length; i++)
            {
                charMas[i] = raides[i][0];
            }

            RikiuotiTrisRaides(charMas);

            return String.Join("-", charMas);
        }

        static public char RaidesIvedimas(string tekstas)
        {
            char raide=' ';
            string eilute;
            bool ivestaRaide=false;

            while (!ivestaRaide) 
            {
                Console.WriteLine(tekstas);
                eilute = Console.ReadLine();

                if (char.IsLetter(eilute[0]) && eilute.Length == 1)
                {
                    raide = eilute[0];
                    ivestaRaide = true;
                }
                else
                {
                    Console.WriteLine("Klaida. Pakartokite ivedima.");
                    ivestaRaide=false;
                }
            }
           
            return raide;
        }

    }
}