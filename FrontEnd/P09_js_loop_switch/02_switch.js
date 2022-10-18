console.log('HELLO SWITCH');
let data = new Date('2022-01-01');
switch (data.getDay()) {
  case 0:
    day = 'Sekmadienis';
    break;
  case 1:
    day = 'Pirmadienis';
    break;
  case 2:
    day = 'Antradienis';
    break;
  case 3:
    day = 'Treciadienis';
    break;
  case 4:
    day = 'Ketvirtadienis';
    break;
  case 5:
    day = 'Penktadienis';
    break;
  case 6:
    day = 'Sestadienis';
    break;
  default:
    day = '';
}
console.log(` day=${day}`);

//--------------------
let d = data.getDay();
switch (d) {
  case 1:
  case 2:
  case 3:
  case 4:
  case 5:
    txt = 'Darbo diena';
    break;
  case 0:
  case 6:
    txt = 'Savaitgalis';
    break;
  default:
    txt = 'kita';
}
console.log(` --- ${d} ${typeof d}`);
console.log(` txt=${txt}`);
//--------------------
console.log('----------------------');
let x = '0';
//daromas ==, o ===
switch (x) {
  case 0:
    txt = 'isjungta';
    break;
  case 1:
    txt = 'ijungta';
    break;
  case '0':
    txt = 'NULIS';
    break;
  default:
    txt = 'nezinoma';
}
console.log(` reiksme=${txt}`);
