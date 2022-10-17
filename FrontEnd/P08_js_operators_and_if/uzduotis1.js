console.log('---hello uzduotis 1 -----');

let a = window.prompt("Pirmas skaičius", "0");
let b = window.prompt("Antras skaičius", "0");


//normalus parsinimas
if (parseInt(a) > parseInt(b)) {
    rezultatas = 'a > d';
}
// paprastas parsinimas
else if (+a < +b) {
    rezultatas = 'a < b';
}
else
{
    rezultatas = 'a = b'
}

console.log(rezultatas);
