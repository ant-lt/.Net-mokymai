// Javascript
// Ecmascript
// ES2018
// ES2017
// ES2016
// ES2015 (ES6 -> took 6 years. A lot of new features were introduced)
// ES5? ES6?

// https://caniuse.com/?search=let

// https://262.ecma-international.org/13.0/
// ECMA decides what browsers need to implement as standards
// TC39 is technical committee which gathers together every year to decide and propose what changes are required for the current specification.

let color1 = "green";
let color2 = 'teal';
let color3 = `yellow`;

console.log("Color1: " + color1);
console.log("Color2: " + color2);
console.log("Color3: " + color3);

let numberOne = 10;
// let numberOne = 10; // Error
let numberTwo = 80;
let numberThree = 15.78;
let numberFour = 15.3333333333333333333333333333333333333333;

console.log(numberOne);
console.log(numberTwo);
console.log(numberThree);
console.log(numberFour);

console.log(numberOne + numberThree);
console.log(numberOne - numberThree);
console.log(numberOne * numberThree);
console.log(numberOne / numberThree);
console.log(numberOne % numberThree); // Modulus

console.log(numberOne ** 2); // pakeliame laipsniu
console.log(numberOne ** 3);

const bigInt = 1234567890123456789012345678901234567890n
console.log(bigInt);

const hugeString = BigInt("9007199254740991")
console.log(hugeString);

const hugeHex = BigInt("0x1fffffffffffff")
const hugeOctal = BigInt("0o377777777777777777")
const hugeBin = BigInt("0b11111111111111111111111111111111111111111111111111111")

// e == exponent
// 9 == 9 nuliai po skaitmens
let milijardas = 1e9;
console.log(milijardas);

console.log(0/0); // NaN == Not a number
console.log(1/0); // Infinity
console.log(1/NaN); // Infinity
console.log(-1/0); // -Infinity

let isNaNequalNaN = NaN == NaN;
console.log(isNaNequalNaN);

console.log(200+(0/0));

var age = prompt("Enter your age");
console.log(age);


var no1 = prompt("Enter first number:");
var no2 = prompt("Enter second number:");
console.log(no1 + no2);

console.log(parseInt(no1) + parseInt(no2));