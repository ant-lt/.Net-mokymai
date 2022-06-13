
using System.Text;

Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=");
int skaicius;
int kitasSkaicius = 20;
int nelyginisSkaicius = 5;

skaicius = 10;
kitasSkaicius = skaicius;

Console.WriteLine($"skaicius = {skaicius}, kitasskaicius = {kitasSkaicius}");
kitasSkaicius += nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius -= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius *= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius = 21;

kitasSkaicius /= nelyginisSkaicius;

Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");


double doubleSkaicius = 21;

doubleSkaicius /= (double)nelyginisSkaicius;

Console.WriteLine($"kitasSkaicius = {doubleSkaicius}");

Console.WriteLine();
Console.WriteLine("Hello, matematinis operatoriai + - * / % ++ --");

// sudetis
int suma = skaicius + kitasSkaicius;
Console.WriteLine(" suma =  skaicius + kitasSkaicius=  {0}", suma);

int atimtis = skaicius - kitasSkaicius;

Console.WriteLine(" atimtis =  skaicius - kitasSkaicius=  {0}", atimtis);

int daugyba = skaicius * kitasSkaicius;

Console.WriteLine(" daugyba = skaicius * kitasSkaicius = {0}", daugyba);

double dalyba = (double) skaicius / kitasSkaicius;

Console.WriteLine(" dalyba = skaicius * kitasSkaicius = {0}", dalyba);

int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

int dalybaSuLiekana = nelyginisSkaicius % 2 ;
Console.WriteLine("dalybaSuLiekana = nelyginisSkaicius % 2 = {0}", dalybaSuLiekana);

skaicius++;
Console.WriteLine($"skaicius = {skaicius}");

skaicius--;
Console.WriteLine($"skaicius = {skaicius}");

// 
double side1 = 5.5;
double side2 = 3.25;
double height = 4.6;
double area = (side1 + side2) / 2 * height;
double areaKazkasKito = ((side1 * 2 ) + side2) / (2 * height);

Console.OutputEncoding = Encoding.UTF8;
int nulis = 0;
int int10 = 10;
long loang10 = 10;
double double10 = 10;

// Console.WriteLine($"int10/nulis = {int10/nulis}"); // luzta
// Console.WriteLine($"long10/nulis = {long10/nulis}"); // luzta
Console.WriteLine($"double10/nulis = {double10 / nulis}"); // grazina ∞
double a = double.PositiveInfinity;

Console.WriteLine($"a={a}");

Console.WriteLine($"a={a==double.PositiveInfinity}");
Console.WriteLine($"a={a == double.NegativeInfinity}");
Console.WriteLine($"a- 500 = {a - 500}");

double a1 = double.NaN;
Console.WriteLine($"∞ / ∞ = {a/ double.PositiveInfinity}");

// *** Overflow and Underflow

short s1 = 30_000;
short s2 = 30_000;
short s3 = (short) (s1 + s2);

Console.WriteLine($"s3 = {s3}");

checked
{
     s3 = (short) (s1 + s2);
}





