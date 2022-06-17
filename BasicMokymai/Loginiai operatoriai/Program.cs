
Console.WriteLine("Hello, Loginia operatoriai!");
Console.WriteLine("&& (AND) , || (OR), ! (NOT), ^(XOR)");

bool tiesa = true;
bool melas = !tiesa;

Console.WriteLine($" Tiesa = {tiesa}");
Console.WriteLine($" melas = {melas}");
Console.WriteLine($" !melas = {!melas}");

Console.WriteLine("AND &&");
Console.WriteLine($"tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($"tiesa AND mielas {tiesa && melas}");
Console.WriteLine($"mielas AND tiesa {melas && tiesa}");
Console.WriteLine($"mielas AND mielas {melas && melas}");

Console.WriteLine("OR ||");
Console.WriteLine($"tiesa OR tiesa {tiesa || tiesa}");
Console.WriteLine($"tiesa OR mielas {tiesa || melas}");
Console.WriteLine($"mielas OR tiesa {melas || tiesa}");
Console.WriteLine($"mielas OR mielas {melas || melas}");


Console.WriteLine("XOR ||");
Console.WriteLine($"tiesa XOR tiesa {tiesa ^ tiesa}");
Console.WriteLine($"tiesa XOR mielas {tiesa ^ melas}");
Console.WriteLine($"mielas XOR tiesa {melas ^ tiesa}");
Console.WriteLine($"mielas XOR mielas {melas ^ melas}");

Console.WriteLine("NAND ! &&");
Console.WriteLine($"tiesa NAND tiesa {!(tiesa && tiesa)}");
Console.WriteLine($"tiesa NAND mielas {!(tiesa && melas)}");
Console.WriteLine($"mielas NAND tiesa {!(melas && tiesa)}");
Console.WriteLine($"mielas NAND mielas {!(melas && melas)}");


Console.WriteLine("NOR ! OR");
Console.WriteLine($"tiesa NOR tiesa {!(tiesa || tiesa)}");
Console.WriteLine($"tiesa NOR mielas {!(tiesa || melas)}");
Console.WriteLine($"mielas NOR tiesa {!(melas || tiesa)}");
Console.WriteLine($"mielas NOR mielas {!(melas || melas)}");

Console.WriteLine("NXOR ! ^");
Console.WriteLine($"tiesa NXOR tiesa {!(tiesa ^ tiesa)}");
Console.WriteLine($"tiesa NXOR mielas {!(tiesa ^ melas)}");
Console.WriteLine($"mielas NXOR tiesa {!(melas ^ tiesa)}");
Console.WriteLine($"mielas NXOR mielas {!(melas ^ melas)}");


Console.WriteLine($"mielas OR tiesa OR melas AND tiesa {(melas || tiesa || melas && tiesa)}");

int a = 5;
int b = 5;
int c = 6;

bool s = a >= b && a > c || tiesa;

Console.WriteLine(s);

/*
 * PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGŪS,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/*
Console.WriteLine("Įveskite 2 skaičius:");
int skaicius1 = Convert.ToInt32(Console.ReadLine());
int skaicius2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ar lygus {skaicius1} = {skaicius2} ? rezultatas {skaicius1 == skaicius2}");
*/

/*
 * ARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGINIAI,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/*
Console.WriteLine("Įveskite 2 skaičius:");
int skaicius1 = Convert.ToInt32(Console.ReadLine());
int skaicius2 = Convert.ToInt32(Console.ReadLine());

bool ra = skaicius1 % 2 == 0;
bool rb = skaicius1 % 2 == 0;

bool r = ra && rb;

bool r1 = skaicius1 % 2 == 0 && skaicius1 % 2 == 0;

Console.WriteLine($"Ar skačiai {skaicius1}  ir  {skaicius2}  lyginiai ? rezultatas {r}");
Console.WriteLine($"Ar skačiai {skaicius1}  ir  {skaicius2}  lyginiai ? rezultatas {r1}");
*/
/*
 * Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
kanalas A __---___---___---___---___
kanalas B ____---___---___---___---_
Apatinis brūkšnys (_) reiškia false, o paprastas (-) true.
Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
e) (A OR B) NAND A



atsakymas:
a) ____-_____-_____-_____-___
b) __-----_-----_-----_-----_
c) __--_--_--_--_--_--_--_--_
*/


bool al1 = "_" == "-";
bool al2 = "_" == "-";
bool al3 = "-" == "-";

bool bl1 = "_" == "-";
bool bl2 = "_" == "-";
bool bl3 = "_" == "-";


/*
Console.WriteLine("Įveskite a ");

string a1 = Console.ReadLine();

Console.WriteLine("Įveskite b ");
string b1 = Console.ReadLine();


bool al = a1 == "-";
bool bl = b1 == "-";


bool res = al && bl;
*/

string res1 = (al1 && bl1).ToString().Replace("False", "_").Replace("True", "-");
string res2 = (al2 && bl2).ToString().Replace("False", "_").Replace("True", "-");
string res3 = (al3 && bl3).ToString().Replace("False", "_").Replace("True", "-");

 Console.WriteLine($"a) {res1}{res2}{res3}");


res1 = (al1 || bl1).ToString().Replace("False", "_").Replace("True", "-");
res2 = (al2 || bl2).ToString().Replace("False", "_").Replace("True", "-");
res3 = (al3 || bl3).ToString().Replace("False", "_").Replace("True", "-");

Console.WriteLine($"b) {res1}{res2}{res3}");


res1 = (al1 ^ bl1).ToString().Replace("False", "_").Replace("True", "-");
res2 = (al2 ^ bl2).ToString().Replace("False", "_").Replace("True", "-");
res3 = (al3 ^ bl3).ToString().Replace("False", "_").Replace("True", "-");

Console.WriteLine($"c) {res1}{res2}{res3}");


res1 = (!(al1 && bl1)).ToString().Replace("False", "_").Replace("True", "-");
res2 = (!(al2 && bl2)).ToString().Replace("False", "_").Replace("True", "-");
res3 = (!(al3 && bl3)).ToString().Replace("False", "_").Replace("True", "-");


Console.WriteLine($"d) {res1}{res2}{res3}");

res1 = (!(al1 || bl1)).ToString().Replace("False", "_").Replace("True", "-");
res2 = (!(al2 || bl2)).ToString().Replace("False", "_").Replace("True", "-");
res3 = (!(al3 || bl3)).ToString().Replace("False", "_").Replace("True", "-");


Console.WriteLine($"e) {res1}{res2}{res3}");


res1 = (!al1).ToString().Replace("False", "_").Replace("True", "-");
res2 = (!al2).ToString().Replace("False", "_").Replace("True", "-");
res3 = (!al3).ToString().Replace("False", "_").Replace("True", "-");


Console.WriteLine($"f) {res1}{res2}{res3}");


res1 = (!((al1) || bl1) && (al1)).ToString().Replace("False", "_").Replace("True", "-");
res2 = (!((al2) || bl2) && (al2)).ToString().Replace("False", "_").Replace("True", "-");
res3 = (!((al3) || bl3) && (al3)).ToString().Replace("False", "_").Replace("True", "-");

Console.WriteLine($"g) {res1}{res2}{res3}");


/*

Console.WriteLine($"a) {al}  AND  {bl} ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

res = al || bl;
Console.WriteLine($"b){al}  OR  {bl} ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

res = al ^ bl;
Console.WriteLine($"c){al}  XOR  {bl} ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

//**
res = !(al && bl); 
Console.WriteLine($"d){al}  NAND  {bl}  ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

res = !(al || bl);
Console.WriteLine($"e){al}  NOR  {bl}  ->{res.ToString().Replace("False", "_").Replace("True", "-")}");


res = !(al);
Console.WriteLine($"f) NOT {al} ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

res = !((al) || bl) && (al);
Console.WriteLine($"g)  {al} OR {bl} NAND {al} ->{res.ToString().Replace("False", "_").Replace("True", "-")}");

*/



/*
 * [19:39] Robertas Ūselis
Prašykite programą kuri pritaikius loginę funkciją grąžina tokius rezultatus
A B F(A,B)
0 0 0
0 1 1
1 0 1

1 1 1 A B F(A,B)
0 0 1
0 1 1
1 0 0

1 1 1 A B F(A,B)
0 0 1
0 1 0
1 0 1
1 1 0

A B C F(A,B,C)
0 0 0 1
0 0 1 0
0 1 0 0
0 1 1 0
1 0 0 1
1 0 1 0
1 1 0 0
1 1 1 1

*/











