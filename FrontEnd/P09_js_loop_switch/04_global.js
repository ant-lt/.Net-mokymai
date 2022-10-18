let a = 10;
let b = 20;
let c = 2;
let formule = 'a + b * c';
let res = eval(formule);
console.log(`  ${res}`);
//---------------------------------------------
console.log('***--- isNaN()');
console.log(isNaN(123));
console.log(isNaN(-1.23));
console.log(isNaN(5 - 2));
console.log(isNaN(5 - 'A'));
console.log(isNaN(0));
console.log(isNaN('123'));
console.log(isNaN('Hello'));
console.log(isNaN('2005/12/12'));
//---------------------------------------------
console.log('-------------------------------------');
console.log(Number(true));
console.log(Number(false));
console.log(Number(new Date('2022/01/01')));
console.log('-------------------------------------');
console.log(parseFloat(10));
console.log(parseFloat('10'));
console.log(parseFloat('10.33'));
console.log(parseFloat('34 45 66'));
console.log(parseFloat('He was 40'));
console.log('-------------------------------------');
console.log(parseInt(10));
console.log(parseInt(10.9));
console.log(parseInt('10'));
console.log(parseInt('10.55'));
console.log(parseInt('34 45 66'));
console.log(parseInt('He was 40'));
console.log(parseInt('60 He was 40'));

console.log('-------------------------------------');
typeof 'John'; // Returns "string"
typeof 3.14; // Returns "number"
typeof NaN; // Returns "number"
typeof false; // Returns "boolean"
typeof [1, 2, 3, 4]; // Returns "object"
typeof { name: 'John', age: 34 }; // Returns "object"
typeof new Date(); // Returns "object"
typeof function () {}; // Returns "function"
typeof myCar; // Returns "undefined" *
typeof null; // Returns "object"
typeof undefined; // undefined
