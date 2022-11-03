let numbers = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

console.log(`2 uzdavinys su map()`);

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


console.log(`2.1 uzdavinys`);
function arrDouble(arr) {
  return arr.map(function(arrEle) {
      return arrEle * 2;
  });
}

console.log(arrDouble(numbers));

console.log(`2.2 uzdavinys`);
function arrMultiplied(arr, multiplier) {
  return arr.map(arrEle => arrEle * multiplier);
}

console.log(arrMultiplied(numbers, 3));

console.log(`2.3 uzdavinys`);
function getBudgets (){
    let viso = 0;
    budgets.forEach(function(budget) {
       viso += budget.budget   
    });
    return viso;
};

console.log(getBudgets());


console.log(`2.4 uzdavinys`);

const names = budgets.map(function(elementOfbudgets) { 
    return elementOfbudgets.name;
});

console.log(names);



