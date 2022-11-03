// SOME

const budgets = [
  {
    name: "Rytis",
    budget: 50,
  },
  {
    name: "Saulė",
    budget: 230,
  },
  {
    name: "Paulius",
    budget: 1500,
  },
  {
    name: "Gytis",
    budget: 92,
  },
  {
    name: "Sandra",
    budget: 7,
  },
];

const names = budgets.map((person) => person.name);
const monies = budgets.map((person) => person.budget);

console.log(`4 uzdavinys su some & every`);

console.log(`4.1 uzdavinys`);

if(monies.some(n => n < 0)) {
  console.log(`Found a budget account with a negative value.`);
}


console.log(`4.2 uzdavinys`);

function belowHundred(arr) {
  if(arr.some(belowHundredCondition)) {
      return arr.filter(belowHundredCondition);
  }
  return `All numbers are above 100`;
};

function belowHundredCondition(num) {
  return num < 100;
}

console.log(belowHundred(monies));

console.log(`4.3 uzdavinys`);

// arr.every() condition has to return a boolean value.
function symbolified(arr) {
  if(arr.every(n => n.length >= 3)) {
      if(arr.some(symbolifiedCondition)) {
          let newArr = arr.filter(symbolifiedCondition);
          return newArr.map(function(ele) {
              return ele.replace('a', '@');
          });
      }
  }
}

function symbolifiedCondition(word) {
  return word.includes('a');
}

console.log(symbolified(names));
