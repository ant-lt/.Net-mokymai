// 1 uzduotis su  forEach 

let numbers = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

console.log(`1 uzdavinys su forEach`);

 //let list_of_p = document.getElementsByClassName('result-paragraph')[0];
let list_of_p =document.getElementsByTagName('p')[0];
let result="";

for (let i = 0; i < numbers.length; i++) {


    list_of_p.textContent  += `<p> Index Nr: ${i} value: ${numbers[i]} </p>\r\n`;
    console.log(`<p> Index Nr: ${i} value: ${numbers[i]} </p> `);

}



console.log(`1 uzdavinys su foreach ir calback funkcija`)

function getUzdavinis1 (){
    let list_of_p =document.getElementsByTagName('p')[0];
    numbers.forEach(function(value,index) {
        list_of_p.textContent  += `<p> Index Nr: ${index} value: ${value} </p>\r\n`
    });
    
};
getUzdavinis1();

