
Console.WriteLine("Hello, Operatoriai");

// Reliaciniai operatoriai == != < > >= <=

var skaicius = 10;
var nelyginisSkaicius = 5;
var lyginisSkaicius = 10;
Console.WriteLine(" ==  patikrina ar kintamieji yra lygus");
Console.WriteLine($" {skaicius} == {lyginisSkaicius} yra {skaicius == lyginisSkaicius}");

bool ar10yraLygu5 = skaicius == nelyginisSkaicius;
Console.WriteLine($" {skaicius} == {nelyginisSkaicius} yra {ar10yraLygu5}");
Console.WriteLine(" != patikrina ar kintamieji yra nelygus");
Console.WriteLine($" {skaicius} != {lyginisSkaicius} yra {skaicius == lyginisSkaicius}");
Console.WriteLine($" {skaicius} != {nelyginisSkaicius} yra {skaicius == nelyginisSkaicius}");
Console.WriteLine("--------------------------------------");
Console.WriteLine(" > patikrina ar kaireje esanti reiksme yra didesne uz desineje");
Console.WriteLine($" {skaicius} > {lyginisSkaicius} yra {skaicius > lyginisSkaicius}");
Console.WriteLine($" {skaicius} > {nelyginisSkaicius} yra {skaicius > nelyginisSkaicius}");
Console.WriteLine("--------------------------------------");
Console.WriteLine(" > patikrina ar kaireje esanti reiksme yra mazesne uz desineje");
Console.WriteLine($" {skaicius} < {lyginisSkaicius} yra {skaicius < lyginisSkaicius}");
Console.WriteLine($" {skaicius} < {nelyginisSkaicius} yra {skaicius < nelyginisSkaicius}");
Console.WriteLine("--------------------------------------");
Console.WriteLine(" >= patikrina ar kaireje esanti reiksme yra didesne arba lygi  uz desineje");
Console.WriteLine($" {skaicius} >= {lyginisSkaicius} yra {skaicius >= lyginisSkaicius}");
Console.WriteLine($" {skaicius} >= {nelyginisSkaicius} yra {skaicius >= nelyginisSkaicius}");
Console.WriteLine("--------------------------------------");
Console.WriteLine(" <= patikrina ar kaireje esanti reiksme yra mazesne arba lygi  uz desineje");
Console.WriteLine($" {skaicius} <= {lyginisSkaicius} yra {skaicius <= lyginisSkaicius}");
Console.WriteLine($" {skaicius} <= {nelyginisSkaicius} yra {skaicius <= nelyginisSkaicius}");



/*
var a = "A";
var b = "B";
Console.WriteLine();
*/