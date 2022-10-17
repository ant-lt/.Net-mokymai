console.log('---hello uzduotis 4 -----');

/*
Sukurkite
kodą kuris naudodamasis if else kondicija pagal iš anksto nustatytą bėgiko naudojant let) poziciją konsolėje išmestų bėgiko
vardą ir kokį medalį jis gavo pvz Jonas gavo sidarbinį medalį Jums reikės sukurti 3 kintamuosius ir du iš jų nustatyti iš anksto
1. Bėgiko vardas aprašyti iš anksto reiktų
2. Pozicija kurią užėmė bėgikas aprašyti iš anksto reiktų
3. Ir neaprašytą kintamąjį kuris bus tiesiog medaliui nustayti pagal kurį tikrinsim kokį gaus pagal užimtą poziciją
*/
let vardas = 'Jonas';
let vieta = 1;
let medalis = 'paguodos';
if (vieta === 1) medalis = 'auksini';
else if (vieta === 2) medalis = 'sidabrini';
else if (vieta === 3) medalis = 'bronzinis';

console.log(`  ${vardas} gavo ${medalis} medali`);


