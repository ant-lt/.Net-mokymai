console.log('---hello uzduotis 3 -----');

let a = -5;
let b = -6;
let c = -2;
let d = 0;
let f = -11;


if (parseInt(a) > parseInt(b) && parseInt(a)> parseInt(c) && parseInt(a)> parseInt(b) && parseInt(a) > parseInt(f)) {
    console.log(a);
}
else if (parseInt(b) > parseInt(a) && parseInt(b) > parseInt(c) && parseInt(b) > parseInt(c) && parseInt(b) > parseInt(d) && parseInt(b) > parseInt(f)) {
    console.log(b);
}
else if (parseInt(c) > parseInt(a) && parseInt(c) > parseInt(b) && parseInt(c) > parseInt(d) && parseInt(c) > parseInt(f) )
{
    console.log(c);
}
else if ( parseInt(d) > parseInt(a) && parseInt(d) > parseInt(c) && parseInt(d) > parseInt(b) && parseInt(d) > parseInt(f))
{
    console.log(d);
}
else {
    console.log(f);
}


/* nenaudodami ciklų parašykite programą, kuri randa didžiausią skaičių iš 5 */
a = -5;
b = -6;
c = -2;
d = 0;
f = -11;
if (a > b && a > c && a > d && a > f) {
  console.log(a);
} else if (b > a && b > c && b > d && b > f) {
  console.log(b);
} else if (c > a && c > b && c > d && a > f) {
  console.log(c);
} else if (d > a && d > b && d > c && d > f) {
  console.log(d);
} else {
  console.log(f);
}