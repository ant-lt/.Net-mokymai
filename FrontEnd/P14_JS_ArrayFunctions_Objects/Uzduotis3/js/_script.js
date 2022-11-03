let numbers = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

console.log(`3 uzdavinys su includes & filter`);

//antra uzduotis
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


console.log(`3.1 uzdavinys`);

function getBudgetPeople(budgetArr) {
  return budgetArr.map(ele => ele.name);
}


const budgetExercise = getBudgetPeople(budgets);
console.log(budgetExercise);


function isPersonInArray(nameArr, lookupName) {
  return nameArr.includes(lookupName)
      ? getGenderBasedGreet(lookupName)
      : `Unfotunately Name is not in our list`;
}

function getGenderBasedGreet(name) {
  // Alternative: can be used with endswith
  let lastChar = name.charAt(name.length-1); // name[name.length-1]
  if(lastChar === 's') {
      return `Welcome Mr. ${name}`;
  }
  return `Welcome Miss. ${name}`;
}

  console.log(isPersonInArray(budgetExercise, 'Edvinas'));
  console.log(isPersonInArray(budgetExercise,"Sandra"));
  console.log(isPersonInArray(budgetExercise,"Rytis"));
  console.log(isPersonInArray(budgetExercise,"Vitas"));

  
  console.log(`3.2 uzdavinys`);

  function arrCountTwos(arr) {
    return arr.filter(n => n === 2).length;
}

console.log(arrCountTwos(numbers));

