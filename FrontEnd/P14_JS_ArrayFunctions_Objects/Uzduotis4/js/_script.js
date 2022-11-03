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

const moniesNegative = monies.some(n => n < 0);
console.log(moniesNegative);

console.log(`4.2 uzdavinys`);

function belowHundred (numbersArray){

  if (monies.some(n => n <= 100)) {
  const filteredNumbersUpTo100 = numbersArray.filter(n => n  <= 100);

  if (filteredNumbersUpTo100.length === numbersArray.length) {
    return "All numbers are above 100";
  }
  else {
    return filteredNumbersUpTo100;
  }
  }
  else {
    return "No numbers";
  }
}

console.log(belowHundred(monies));

console.log(`4.3 uzdavinys`);

function symbolified (namesArray){
  const filteredNamesUpTo3 = namesArray.filter(n => n.length  >= 3 );

  console.log(filteredNamesUpTo3);


  let newStr = filteredNamesUpTo3.replace('a','@');
  console.log(newStr);
}

symbolified(names);
