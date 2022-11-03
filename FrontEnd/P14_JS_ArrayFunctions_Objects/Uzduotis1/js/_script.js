// 1 uzduotis su  forEach 

let numbers3 = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

console.log(`1 uzdavinys su forEach`);

const bodyEle = document.querySelector('body');

numbers3.forEach(function(num, ind) {
    bodyEle.innerHTML += `<p>Index Nr: ${ind}, value: ${num}</p>`;
});

bodyEle.innerHTML += `<hr/>`;

for(let i = 0; i < numbers3.length; i++) {
    bodyEle.innerHTML += `<p>Index Nr: ${i}, value: ${numbers3[i]}</p>`;
};

