namespace Tower_of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // piešiame bokšto figūra
            string bokstas0 = "    |    ";
            string bokstas1 = "   #|#   ";
            string bokstas2 = "  ##|##  ";
            string bokstas3 = " ###|### ";
            string bokstas4 = "####|####";


            // 1 -------------------------

            Console.WriteLine("1. nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.");

            // 1 stulpelis užpildytas bokšto figūra
            string stulp1eilute1 = bokstas0;
            string stulp1eilute2 = bokstas1;
            string stulp1eilute3 = bokstas2;
            string stulp1eilute4 = bokstas3;
            string stulp1eilute5 = bokstas4;

            // 2 stulpelis užpildytas tik tuščiu stulpelių
            string stulp2eilute1 = bokstas0;
            string stulp2eilute2 = bokstas0;
            string stulp2eilute3 = bokstas0;
            string stulp2eilute4 = bokstas0;
            string stulp2eilute5 = bokstas0;

            // 3 stulpelis užpildytas kaip 2 stulpelis
            string stulp3eilute1 = stulp2eilute1;
            string stulp3eilute2 = stulp2eilute2;
            string stulp3eilute3 = stulp2eilute3;
            string stulp3eilute4 = stulp2eilute4;
            string stulp3eilute5 = stulp2eilute5;


            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();


            // 2  Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi
            Console.WriteLine("2. Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi");

            // bokšto apvertimas 
            string temp = "";
                
            temp = stulp1eilute1;

            stulp1eilute1 = stulp1eilute5;
            stulp1eilute5 = temp;

            temp = stulp1eilute4;
            stulp1eilute4 = stulp1eilute2;
            stulp1eilute2 = temp;


            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();

            // 3 Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
            Console.WriteLine("3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi");

            // 1 stulpelio išvalymas
            stulp1eilute1 = bokstas0;
            stulp1eilute2 = bokstas0;
            stulp1eilute3 = bokstas0;
            stulp1eilute4 = bokstas0;
            stulp1eilute5 = bokstas0;


            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();


            // 4 Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
            Console.WriteLine("4. Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi");

            stulp1eilute5 = bokstas4;
            stulp2eilute5 = bokstas4;
            stulp3eilute5 = bokstas4;

            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();


            // 5 Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi
            Console.WriteLine("5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi");

            stulp1eilute5 = bokstas4;
            stulp2eilute5 = bokstas3;
            stulp3eilute4 = bokstas1;
            stulp3eilute5 = bokstas2;

            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();

            //6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
            Console.WriteLine("6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi");

            stulp1eilute4 = stulp3eilute4;


            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();


            // 7 Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi
            Console.WriteLine("7. Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi");

            stulp2eilute1 = stulp3eilute5;
            stulp2eilute2 = stulp3eilute5;
            stulp2eilute3 = stulp3eilute5;
            stulp2eilute4 = stulp3eilute5;
            stulp2eilute5 = stulp3eilute5;

            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();

            // 8 į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi

            Console.WriteLine("8. į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi");

            stulp3eilute1 = bokstas0;
            stulp3eilute2 = bokstas1;
            stulp3eilute3 = bokstas2;
            stulp3eilute4 = bokstas3;
            stulp3eilute5 = bokstas4;

            stulp1eilute1 = bokstas0;
            stulp1eilute2 = bokstas0;
            stulp1eilute3 = bokstas0;
            stulp1eilute4 = bokstas0;
            stulp1eilute5 = bokstas0;

            stulp2eilute1 = bokstas0;
            stulp2eilute2 = bokstas0;
            stulp2eilute3 = bokstas0;
            stulp2eilute4 = bokstas0;
            stulp2eilute5 = bokstas0;

            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();

            // 9. Pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi

            Console.WriteLine("9. Pakeiskite visų elementų dizainą iš # į \", išveskite Tower of Hanoi");

            bokstas1 = bokstas1.Replace("#", "\"");
            bokstas2 = bokstas2.Replace("#", "\"");
            bokstas3 = bokstas3.Replace("#", "\"");
            bokstas4 = bokstas4.Replace("#", "\"");

            stulp3eilute1 = bokstas0;
            stulp3eilute2 = bokstas1;
            stulp3eilute3 = bokstas2;
            stulp3eilute4 = bokstas3;
            stulp3eilute5 = bokstas4;


            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();

            // kad negadintu sekančio vaizdo
            Console.WriteLine();

            // 10 paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("10. paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute");

            stulp1eilute1 = Console.ReadLine();

            Console.WriteLine($"1eil. {stulp1eilute1} {stulp2eilute1} {stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2} {stulp2eilute2} {stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3} {stulp2eilute3} {stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4} {stulp2eilute4} {stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5} {stulp2eilute5} {stulp3eilute5}");
            Console.WriteLine(" -------1stulp----2stulp----3stulp----");

            Console.WriteLine("--- Tęsti --- ");
            Console.ReadKey();


        }
    }
}