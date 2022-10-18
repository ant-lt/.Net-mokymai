console.log('HELLO LOOPS');
let n = 0;
console.log('-- while ciklas');
while (n < 3) {
  n++;
  console.log(`      ${n}`);
}
//------------------------------
console.log('-- do...while');
let result = '';
let numberResult = 0;
let i = 0;
do {
  i++;
  result += i;
  numberResult += i;
  console.log(`      ${i}`);
} while (i < 5);
console.log(` ${result}`);
console.log(` ${numberResult}`);
let suma1 = result / 2;
let suma2 = numberResult / 2;

console.log(` suma1 = ${suma1}`);
console.log(` suma2 = ${suma2}`);
//------------------------------
console.log('-- for');
let str = '';
for (let i = 0; i < 9; i++) {
  str += i;
}
console.log(` ${str}`);

console.log('-- for with step');
str = '';
for (let i = 0; i < 9; i += 2) {
  str += i;
}
console.log(` ${str}`);

console.log('-- for....of');
let arr = ['a', 'b', 'c', '1', 2, true];
for (let item of arr) {
  console.log(`    ${item} - ${typeof item}  `);
}

console.log('-- for....in');
let objektas = {
  vardas: 'Jonas',
  pavade: 'Jonaitis',
  amzius: 30,
  gimimoMetai: new Date('2000-01-01'),
};
for (let prop in objektas) {
  console.log(` ${prop} reiksme yra ${objektas[prop]}`);
}