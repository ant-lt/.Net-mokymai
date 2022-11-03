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

const names = budgets.map(function(elementOfbudgets) { 
  return elementOfbudgets.name;
});

console.log(names);

function isPersonInArray (namesArray, personName ){
let greeting='';
  if (namesArray.includes(personName)) {
    let index= namesArray.indexOf(personName);
   
   if ( namesArray[index].slice(-1) =='s'){
      greeting = 'Welcome Mr. '+ personName;
    }
    else { 
      greeting = 'Welcome Miss. '+ personName;
    }
    
}
else {
    greeting = 'Unfotunately '+ personName +' is not in our list ';
}
      return greeting;
  };

  console.log(isPersonInArray(names,"Sandra"));
  console.log(isPersonInArray(names,"Rytis"));
  console.log(isPersonInArray(names,"Vitas"));

  console.log(`3.2 uzdavinys`);

  const filteredNumbers = numbers.filter(n => n  === 2).length;

console.log("Dvejetų yra = " + filteredNumbers + " vienetai.");

