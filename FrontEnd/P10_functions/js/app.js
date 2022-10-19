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
