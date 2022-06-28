
Console.WriteLine("Hello, String!");
string vardas = "Petras";

DateTime siandien = DateTime.Today;

Console.WriteLine("********* string concationation");
var pilnasVardas = vardas + " Pavardenis";

Console.WriteLine("********* string composition");
var vardasIrDate = string.Format("{0} data={1}", vardas, siandien);
Console.WriteLine(vardasIrDate);

Console.WriteLine("********* string interpolation");
var vardasIrData1 = $"{vardas} data = {siandien}";
Console.WriteLine(vardasIrData1);

///----------
///
string nullas = null;
string baltaErdve = "          ";
string tuscia = "";
string tuscia1 = string.Empty;
Console.WriteLine("Ar \"\" yra tapatu string.Empty? {0}", tuscia == tuscia1);

Console.WriteLine("Ar \"\" yra tapatu baltaErdve? {0}", tuscia == baltaErdve); 

bool arTuscia = string.IsNullOrEmpty(tuscia);
Console.WriteLine($"ArTuscia={arTuscia}");

bool arNullas = string.IsNullOrEmpty(nullas);
Console.WriteLine($"ArNulas={arNullas}");

bool arBaltaErdveYraTuscia = string.IsNullOrEmpty(baltaErdve);
Console.WriteLine($"ArBaltaErdveYraTuscia={arBaltaErdveYraTuscia}");

bool arBaltaErdve = string.IsNullOrWhiteSpace(baltaErdve);
Console.WriteLine($"ArBaltaErdve={arBaltaErdve}");


Console.WriteLine("-----------------------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"eilute {Environment.NewLine} nauja";
string aa5 = $"kelias diskineje sistemoje c: {Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}windows";
string aa6 = $"{{  }}";
string aa7 = @"galime 
rasyti teksta
per 
kelias eilutes";

Console.WriteLine("-----------------------------");
double skaicius = 886.654888489545454;

string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.000");
Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio);










