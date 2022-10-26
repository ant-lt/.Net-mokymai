const fitBitData = {
    totalSteps: 308727,
    // totalSteps: 308727, // We just override ANYTHING with the same name
    totalKms: 387.7,
    avgCalorieBurn: 400,
    workoutsThisWeek: '5 of 7',
    avgGoodSleep: '2:13',
    45: 'forty five',
    '79 trombones': 'great song'
};

console.log(fitBitData.totalSteps);
// console.log(fitBitData.45); // Throws error. Needs a different syntax to access property.

// Dot syntax
let dataDotSyntax = {a:1, b:2, c:3};
console.log(dataDotSyntax.a);

// Square bracket syntax
const numbers = {
    100: 'one hundred',
    16: 'sixteen'
};

console.log(numbers[100]); // 100 gets converted to '100' string
console.log(numbers['100']);
console.log(fitBitData['avgCalorieBurn']);
console.log(fitBitData['79 trombones']);

const pallete = {
    red: '#eb4d4b',
    yellow: '#f9ca24',
    blue: '#30336b'
};

console.log(pallete.blue);

// Lets user pick random color
let mysteryColor = 'blue';
console.log(pallete[mysteryColor]);




// ADDING AND UPDATE PROPERTIES
const userReviews = {};
// userReviews['colorEnabled'] = true;
userReviews['queenBee49'] = 4.0;
userReviews.mrSmith78 = 3.5;

userReviews['queenBee49'] += 0.5;
userReviews.mrSmith78++;

console.log(userReviews);






// NESTING 