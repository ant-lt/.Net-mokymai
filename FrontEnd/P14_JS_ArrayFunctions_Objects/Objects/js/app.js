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



// NESTING ARRAYS AND OBJECTS
const student = {
    firstName: 'David',
    lastName: 'Jones',
    strengths: ['Music', 'Art'],
    exams: {
        midterm: 10,
        final: 9
    },
    // fullName function returns a string
    // public string fullName()
    fullName: function() {
        return this.firstName + ' ' + this.lastName;
    },
    // logFullName logs into REPL fullname
    // public void logFullName()
    logFullName: function() {
        console.log(this.firstName, this.lastName);
    }
};

console.log(student.fullName());

const studentAvgExamMarkCount = 2;
const studentAvgExamMark = (student.exams.midterm + student.exams.final) / studentAvgExamMarkCount;

console.log(student.strengths[1]);

const shoppingCart = [
    {
        product: 'Jenga',
        price: 6.88,
        quantity: 1
    },
    {
        product: 'Warcraft TableTop',
        price: 49.99,
        quantity: 3
    },
    {
        product: 'Pandemic',
        price: 39.99,
        quantity: 2
    }
];

console.log(shoppingCart);

const game = {
    player1: {
        username: 'Blue',
        playingAs: 'X'
    },
    player2: {
        username: 'Red',
        playingAs: 'O'
    },
    board: [
        ['O', null, 'X'],
        [null, 'X', 'O'],
        ['X', 'O', null]
    ]
}





// OBJECTS AND REFFERENCE TYPES
const pallete2 = pallete; // Assigning a refference
pallete2.green = '#ebf876';
pallete2.blue = '#30336b';
console.log(pallete);
console.log(pallete2);






// ARRAY/OBJECT EQUALITY
// Rule of thumb for beginners: objects and arrays are refference types -> Everything else is value type
let nums = [1,2,3];
let mysteryNums = [1,2,3];

console.log(nums===mysteryNums);
console.log(nums==mysteryNums);

// nums = 5sd1gfd85
// mysteryNums = dfgh15df1

let moreNums = nums;
console.log(moreNums==nums);


const user2 = {
    username: 'Brownie45',
    email: 'browny85@gmail.com',
    notifications: []
};

// [] is not equal to []. Points to different addresses.
console.log(user2.notifications == []);
// ! -> casting to boolean
// ! -> inverse logic (NOT)
// user2.notifications.length -> 0
// 0 -> falsy
// !falsy -> truthy
console.log(!user2.notifications.length);
console.log(!user2.notifications.length > 0);
console.log(user2.notifications.length === 0);


const movieReviews = {
    Arrival: 9.5,
    Alien: 9.5,
    Amelie: 9.5,
    "In Bruges": 9.5,
    Amadeus: 9.5
};

movieReviews['Lord of the Rings'] = 9.8;

for(let propKey of Object.keys(movieReviews)) {
    console.log(`${propKey} -> ${movieReviews[propKey]}`);
}

const movieRatings = Object.values(movieReviews);
let totalRating = 0;
for(let propValue of movieRatings) {
    console.log(propValue);
    totalRating += propValue;
}

console.log(totalRating);
console.log(totalRating/movieRatings.length);

// Užduotis nr. 2

const child = {
    name: 'Susan',
    toysArray: ['doll', 'teddy bear', 'Robocop Destructor 9000X'],
    yearsOld: 5,
    birthday: true,
    totalToys: null,
    friends: [
        {
            name: 'Simon',
            currAction: 'Playing football'
        },
        {
            name: 'Mia',
            currAction: 'Fighting samurais'
        },
        {
            name: 'Emma',
            currAction: 'Brushing hair'
        }
    ]
}

function doBirthdayParty(name) {
    if(child.name === name && child.birthday) {
        // let [toysArray, yearsOld, friends] = child;
        let birthdayToy = child.toysArray.shift();
        console.log(`Toy that was taken: ${birthdayToy}`);
        child.toysArray.push('New toy');
        child.yearsOld++;
        child.totalToys = child.toysArray.length;

        console.log(child);
        for(let friend of child.friends) {
            console.log(`${friend.name}: ${friend.currAction}`);
        }
    }
}

doBirthdayParty('Susan');


// Uzduotis 3
const person = {
    name: 'Rosa',
    age: 120,
    alive: false,
    interests: ['swimming', 'cards']
}

function alterPerson(person, newName) {
    person.name = newName;
    person.age = Math.floor(Math.random() * 101) + 20;

    if(person.age < 100) {
        person.alive = true;
        person.interests.push('enjoying life');
        console.log(person.interests);
    }
}

alterPerson(person, 'Susan');


// Uzduotis 4
const arr2 = [
    "I",
    "study",
    "JavaScript",
    "right",
    "now"
];

arr2.splice(0,3,'Lets','dance');

console.log(arr2.join(' '));


// Uzduotis 5
let first = ['slice', 'splice', 'concat'];
let second = ['push', 'pop', 'shift', 'unshift'];
let firstSecond = first.concat(second);
firstSecond.push('length', 7, {
    subject: 'methods'
});

console.log(firstSecond);




// CALLBACKS
// A callback is a function passed to another function as an argument to parameter which is invoked in our outer function.

function messageUserAboutClick() {
    alert('Wow, a button was clicked!');
}

let btnRunFunction = document.querySelector('button');
btnRunFunction.addEventListener('click', messageUserAboutClick); // messageUserAboutClick is a Callback
btnRunFunction.addEventListener('click', function() { // Annon function is callback
    console.log('Ohh wow, a function in REPL');
    setTimeout(messageUserAboutClick, 3000); // Run messageUserAboutClick after 3000 milliseconds
});

// setTimeout(messageUserAboutClick, 3000);


function greet() {
    console.log('Hello handsome!');
}

function callFunc(func1) {
    func1(); // Callback
}

callFunc(greet);



// Uzduotis 6
let accords = ["D", "G", "C", "C7", "F"];

function updateAccord(accord) {
    if(!accord.endsWith('7')) {
        accord += '7';
    }
    return accord;
    // console.log(accord);
}

for (let i = 0; i < accords.length; i++) {
    console.log(updateAccord(accords[i]));
}

// accords.forEach(function(accord) {
//     console.log(accord);
//     accord = updateAccord(accord);
// });




// .FOREACH
// .forEach is a syntax sugar to help avoid using keyword function through our whole application. It is quite a bit slower than forOf.
const numbers2 = [20,21,22,23,24,25,26,27];
numbers2.forEach(function(num) {
    console.log(num * 2);
});

numbers2.forEach(num => console.log(num * 2));

function printTriple(n) {
    console.log(n * 3);
}

numbers2.forEach(printTriple);

// MAP()
// Creates a new array based on our callback function
const doubles = numbers2.map(function(elementOfNumbers2) { //elementOfNumbers2 is an element of numbers2
    return elementOfNumbers2 * 2;
});

console.log(numbers2);
console.log(doubles);

const numDetail = numbers2.map(function(n) { // n is just a name for our element
    return {
        value: n,
        isEven: n % 2 === 0
    };
})

const fakeNumDetails = numbers2.map(function() {
    return {
        value: 10,
        isEven: 10 % 2 === 0
    };
})

console.log(numDetail);
console.log(fakeNumDetails);

// FILTER()
// Creates an array with all elements which pass callback test/function
// Main thing to remember is that your function HAS to return boolean
const filteredOddNumbersNA = numbers2.filter(function(n) { 
    return n % 2 === 1
});
const filteredOddNumbers = numbers2.filter(n => n % 2 === 1);
const filteredEvenNumbers = numbers2.filter(n => n % 2 === 0);

console.log(filteredOddNumbersNA);
console.log(filteredOddNumbers);
console.log(filteredEvenNumbers);




// SOME() AND EVERY()
// EVERY returns a boolean 
const words2 = [
    "dog",
    "dig",
    "log",
    "bag",
    "wag",
];

const all3Letters = words2.every(word => word.length === 3);
const allEndInG = words2.every(word => {
    const last = word.length-1;
    return word[last] === 'g';
});

console.log(all3Letters);
console.log(allEndInG);

const someStartWithD = words2.some(word => word[0] === 'd');
console.log(someStartWithD);
