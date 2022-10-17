console.log('---hello uzduotis 2 -----');

let a = window.prompt("Pirmas skaičius", "0");
let b = window.prompt("Antras skaičius", "0");
let c = window.prompt("Trečias skaičius", "0");


let rezultatas = 'Visi teigiami';

if (parseInt(a) < 0) {
    rezultatas = 'Yra neigiamų skaičių';
}
else if (parseInt(b) < 0) {
    rezultatas = 'Yra neigiamų skaičių';
}
else if (parseInt(c) < 0)
{
    rezultatas = 'Yra neigiamų skaičių';
}

console.log(rezultatas);

/* parašykite programą kurioje ivedami 3 skaiciai 
ir išvedama ar yra neigiamų skaičių tarp tų trijų */
let x = '-3'; //window.prompt('iveskite pirma skaiciu', '0');
let y = '-7'; //window.prompt('iveskite antra skaiciu', '0');
let z = '2'; //window.prompt('iveskite trecia skaiciu', '0');

if (+x < 0 || +y < 0 || +z < 0) {
  console.log('  YRA neigiamu');
} else {
  console.log('  VISI teigiami');
}

console.log('---------------------------------------');
/* parašykite programą kurioje ivedami 3 skaiciai ir išvedama ar 
yra neigiamų skaičių tarp tų trijų
suskaiciuokite kiek yra neigiamu skaiciu */
let kiekis = 0;
if (+x < 0) {
  kiekis++;
}
if (+y < 0) {
  kiekis++;
}
if (+z < 0) {
  kiekis++;
}

if (kiekis > 0) {
  console.log('  YRA neigiamu');
} else {
  console.log('  VISI teigiami');
}
console.log(`  neigiamu kiekis yra ${kiekis}`);