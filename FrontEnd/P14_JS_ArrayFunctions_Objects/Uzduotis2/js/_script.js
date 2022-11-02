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
function arrDoubled (){
let numbers2 = new Array();
    for (let i = 0; i < numbers.length; i++) {
        numbers2[i]= numbers[i]*2;    
    }

    return numbers2;
};


console.log(arrDoubled());

console.log(`2.2 uzdavinys`);
function arrMultiplied (array, multiplaer){
let numbers2 = new Array();
    for (let i = 0; i < array.length; i++) {
            numbers2[i]= array[i]*multiplaer;    
    }    
    return numbers2;
};

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

const names = budgets.map(function(elementOfbudgets) { //elementOfNumbers2 is an element of numbers2
    return elementOfbudgets.name;
});

console.log(names);



