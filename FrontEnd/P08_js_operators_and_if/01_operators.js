console.log('--- hello operators ---');
console.log('--- Assignment Operators');
let x = 50;
let y = 2;
console.log(`x= ${x}`);
console.log(`y= ${y}`);
let text1 = 'Jonas';
let text2 = 'Jonaitis';
let text3 = text1 + ' ' + text2;
console.log(text3);
console.log('--- Arithmetic Operators------');
let suma = x + y;
let suma1 = '5' + 5;
console.log(`suma1= ${suma1}`);
let suma2 = +'5' + 5;
console.log(`suma2= ${suma2}`);

let atimtis = x - y;
let atimtis1 = '5' - y;
console.log(`atimtis1= ${atimtis1}`);
let atimtis2 = 'abc' - y;
console.log(`atimtis2= ${atimtis2}`);
let atimtis3 = '5 abc' - y;
console.log(`atimtis3= ${atimtis3}`);

let daugyba = x * y;

let dalyba = x / y;
let dalyba_is_nulio = x / 0;
console.log(`dalyba_is_nulio= ${dalyba_is_nulio}`);

let trupmenine = x % y;

x++;
y--;
console.log(`x= ${x}`);
console.log(`y= ${y}`);

//JavaScript Comparison Operators
console.log('------------------------------------');
x = 5;
console.log(`x= ${x}`);
console.log(`x == 8 ${x == 8}`);
console.log(`x == 5 ${x == 5}`);
console.log(`x == '5' ${x == '5'}`);

console.log(`x === 8 ${x === 8}`);
console.log(`x === 5 ${x === 5}`);
let rez = x === '5';
console.log(`x === '5' ${rez}`);

console.log(`x !== 8 ${x !== 8}`);
console.log(`x !== 5 ${x !== 5}`);
console.log(`x !== '5' ${x !== '5'}`);

console.log(`x > 8 ${x > 8}`);
console.log(`x >= 8 ${x >= 8}`);

console.log(`x < 8 ${x < 8}`);
console.log(`x <= 8 ${x <= 8}`);

console.log(`8 > 'Petras' ${8 > 'Petras'}`);
console.log(`8 < 'Petras' ${8 < 'Petras'}`);
console.log(`8 == 'Petras' ${8 == 'Petras'}`);

console.log(`8 > '2' ${8 > '2'}`);
console.log(`8 < '2' ${8 < '2'}`);
console.log(`'8' > '2' ${'8' > '2'}`);
console.log(`'Jonas' > 'Petras' ${'Jonas' > 'Petras'}`);
console.log(`'Jonas' < 'Petras' ${'Jonas' < 'Petras'}`);

//loginiai operatoriai
let l1 = x < 10 && y > 1; //AND
console.log(`l1 = x < 10 && y > 1 ${l1}`);
let l2 = x < 10 || y > 1; //OR
console.log(`l2 = x < 10 || y > 1 ${l2}`);
let l3 = !(x < 10); //NOT
console.log(`l3 = !(x < 10) ${l3}`);
