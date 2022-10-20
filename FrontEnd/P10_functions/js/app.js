// BASICS
function helloWorld() {
    let worldText = 'World';
    console.log("Hello World!");
    console.log("Nice weather were having!");
    // console.log(`Hello ${worldText}!`);
}

helloWorld();
helloWorld();
helloWorld();

for (let i = 0; i < 20; i++) {
    helloWorld();
}

// Math funkcijos
let mathPi = Math.PI;
console.log(mathPi);
// let roundValueMath = Math.round(4,9); // INCORRECT ARGUMENT USAGE
let roundValueMath = Math.round(mathPi)
                        .toFixed(2);
console.log(roundValueMath);
let absValueMath = Math.abs(-456);
console.log(absValueMath);
let floorValueMath = Math.floor(2.8);
console.log(floorValueMath);
let ceilValueMath = Math.ceil(2.5);
console.log(ceilValueMath);
let powValueMath = Math.pow(2,5);
console.log(powValueMath);
let randomFromMath = Math.random()*10;
console.log(`Number was calculated: ${randomFromMath}`);

function throwDie() {
    let roll = Math.floor(Math.random() * 6) + 1;
    console.log(`Die was rolled: ${roll}`);
}

function throwDice() {
    throwDie();
    throwDie();
    throwDie();
}

throwDice();

//////////////////////////////////////



function division(firstNumber, secondNumber) {
console.log(firstNumber/secondNumber);
}

division(10,5);

// FUNCTIONS WITH ARGUMENTS
console.log('hello'.toUpperCase());
console.log('hello'.indexOf('l'));

function greet(name) {
    console.log(`Hello ${name}!`);
    console.log(`Nice to meet you!`);
}

greet();
greet(null);
greet('Edvinas');

function throwDice(numRolls) {
    for (let i = 0; i < numRolls; i++) {
        throwDie();     
    }
}

throwDice(5); // Plain JS does not support overloading

function square(num) {
    console.log(num*num);
}

square(9);

function sum(firstNumber, secondNumber) {
    console.log(firstNumber + secondNumber);
}

sum(8,9);

function divide(firstNumber, secondNumber) {
    console.log(firstNumber/secondNumber);
}

divide(10,3);




// FUNCTIONS RETURNING VALUES 
const yell = "welcome".toUpperCase();
console.log(yell);

function sumReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber;
}

console.log(sumReturn(87,56));

function sumBrokenReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber;
    console.log(firstNumber + secondNumber); // Neigyvendina sios dalies, nes jau grazinta reiksme
}

function sumTextReturn(firstNumber, secondNumber) {
    return `Sum: ${firstNumber+secondNumber}`;
}

console.log(sumTextReturn(78,89));

function isGreen(color) {
    if(color.toLowerCase() === 'green') {
        return true
    }
    else {
        return false;
    }
}

console.log(`isGreen: ${isGreen('Green')}`);
console.log(`isGreen: ${isGreen('Blue')}`);

function isBetterGreen(color) {
    if(color.toLowerCase() === 'green') {
        return true
    }

    return false;
}

function isBestGreen(color) {
    return color.toLowerCase() === 'green';
}

function containGreen(arr) {
    for (let color of arr) {
          if(color.toLowerCase() === 'green' || color.toLowerCase() === 'lime') {
            return true;
          }
          // return false;
    }

    return false;
}

let colorArr = ['Pink', 'Blue', 'Green'];

console.log(`Contains green: ${containGreen(colorArr)}`);





// SCOPE
// Function scope
function scopeExample() {
    let scopeName = "Example scope";
    const creationDate = Date.UTC();
    var tag = "Learning";
    console.log(tag);
}

// console.log(tag); // Not possible to access direct function scope

scopeExample();



// Block scope
let animal1 = 'Dog';

function PrintAnimal1() { // Function scope opens
    let animal1 = 'Cat';
    console.log(animal1);

    if(true) { // Block scope opens
        var animal2 = "Owl"; // var is scoped only to functions
        console.log(animal2);
    }
}

PrintAnimal1();
console.log(animal1);



if(true) { // Block scope opens
    var animal2 = "Owl"; // var is scoped only to functions
    console.log(animal2);
}

console.log(`Outer animal2 call: ${animal2}`);

var animals = ["Bear", "Deer", "Zebra"];

var i = 10;
for (var i = 0; i < animals.length; i++) { // Block scope opens
    console.log(i, animals[i]);
}

console.log(i); // With let - 10 if with var - 3


function doubleEleInArray(arr) {
    const result = [];
    for(let num of arr) {
        let double = num * 2;
        result[result.length] = double;
    }

    return result;
}

let doubleNumbersArr = [5,8,9,7,4,7];
console.log(doubleEleInArray(doubleNumbersArr));



// Lexical scope
function outer() {
    let movie = 'Amadeus';

    function inner() {
        console.log(movie.toUpperCase());

        function extraInner() {
            console.log(movie.toUpperCase());
        }

        extraInner();
    }

    inner();
}

outer();


/////////////////
// FUNCTION EXPRESSIONS
// Functions are objects
console.dir(sum);

// Annonymous
const sumAnnon = function (a, b) {
    return a + b;
}

console.log(sumAnnon(5,5));


// Named
const product = function multiplyNamed(a, b) {
    return a * b;
}

console.log(product(5,5));




// HIGHER ORDER FUNCTIONS
// Tai yra funkcijos, kurios priima funkcijas kaip parametrus arba gražina funkcijas kaip return value


function addFtion(a ,b) {
    return a + b;
}

const substractFtion = function (a ,b) {
    return a - b;
}

function multiplyFtion(a ,b) {
    return a * b;
}

const divideFtion = function (a ,b) {
    return a / b;
}

const operations = [addFtion, substractFtion, multiplyFtion, divideFtion];

// console.log(operations[0]);
// console.log(operations[0](100,4));

for(let func of operations) {
    let result = func(50,8);
    console.log(result);
}

// Class in JS gets added with a function
const thing = {
    //aaa: 'asdas',
    doSomething: multiplyFtion
}

console.log(thing.doSomething(70,8));

console.log("asd".toUpperCase());
console.log("asd".indexOf("d"));

// FUNCTION AS PARAMETER
function callThreeTimes(func) {
    func();
    func();
    func();
}

function callGeneric() {
    console.log("Generic call");
}

function callMoreGeneric() {
    console.log("More generic call");
}

callThreeTimes(callGeneric);
callThreeTimes(callMoreGeneric);

// Funkcijos deklaravimas
function repeatNTimes(action, num) {
    for (let i = 0; i < num; i++) {
        action();      
    }
}

repeatNTimes(callGeneric, 5);


function pickOne(f1, f2) {
    let rand = Math.random();
    console.log(rand);
    if(rand < 0.5) {
        f1();
    }
    else {
        f2();
    }
}

pickOne(callGeneric, callMoreGeneric);


// RETURNING FUNCTION FROM FUNCTION
// Works like function factories
function multiplyBy(num) { //multiplyBy(3)
    return function(x) {
        return x * num; // return x * 3;
    }
}

// Sitoje vietoje musu double kintamasis atrodo:
/*
    const double = function(x) {
        return x * 2;
    }
*/
const double = multiplyBy(2);
console.log(double(8));


// Sitoje vietoje musu double kintamasis atrodo:
/*
    const triple = function(x) {
        return x * 3;
    }
*/
const triple = multiplyBy(3);
console.log(triple(8)); // Sitoje vietoje mes 8 paduodame kaip x



function makeBetweenFunc(a, b) {
    return function(num) {
        return num >= a && num <= b;
    }
}

const isChild = makeBetweenFunc(0, 18);
console.log(isChild(17));
console.log(isChild(19));

const isInNineties = makeBetweenFunc(1990, 2000);
const isGoodWeather = makeBetweenFunc(20, 30);

// ARROW FUNCTIONS

let greetArrow = () => {
    console.log("Hello using arrow!");
}

greetArrow();

let greetArrowName = (name) => {
    console.log(`Hello ${name} using arrow!`);
}

greetArrowName("Edvinas");

let sumArrow = (a, b) => a + b;

console.log(sumArrow(8,8));


///////

function registracija(){
    let name = prompt("Please enter name", "");
    let surnaname = prompt("Please enter surname", "");
    let age = prompt("Please enter age", "");
    let email = prompt("Please enter email","");

    let message = 'Hello,' + name;
    console.log(message);

     message ='surname:' + surnaname;
     console.log(message);

     message = 'age:' + age;
     console.log(message);
     message = 'e-mail:' + email;
     console.log(message);
}

//registracija();

//////
// Exercise 4
function register() {
    let name = prompt("Iveskite varda:");
    let surname = prompt("Iveskite pavarde:");
    let age = prompt("Iveskite amziu:");
    let email = prompt("Iveskite emaila:");

    console.log(`name:${name}`);
    console.log(`surname:${surname}`);
    console.log(`age:${age}`);
    console.log(`email:${email}`);
}

//Exercise 4 Done


////////
//Exercise 5

function IsAdult(age) {
    // typeof age === NaN;
    age >= 18 
        ? alert("Sveikiname isigijus energetini") 
        : confirm("(Tevams)Ar duodate leidima?") === true
            ? alert("Sveikiname isigijus energetini")
            : alert("Atsiprasome, bet pardavimas neivyko");
}

 //IsAdult(8);

// Exercise 5 DONE


////////
//Exercise 6


function arKeliamiejiMetai(year) {
    return (year % 100 === 0) ? (year % 400 === 0) : (year % 4 === 0);
}

// for (let i = 0; i <= 2000; i++) {
//     if(arKeliamiejiMetai(i)) {
//         console.log(i);
//     }
    
// }

// Exercise 6 DONE


// Exercise 7

// C = 5/9(F-32)

function fToC(farenheits) {
    let fToCelcius = 5 / 9 * (farenheits-32);
    console.log(`${farenheits}F to ${fToCelcius}C`);
}

function cToF(celcius) {
    let cToFarenheit = celcius * (9/5) + 32;
    console.log(`${celcius}C to ${cToFarenheit}F`);
}

// Exercise 7 DONE
