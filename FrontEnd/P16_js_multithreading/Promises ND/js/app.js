// Uzd1

const networkRequest = () => { setTimeout(() => { console.log('Async Code');
}, 2000);
};
console.log('Hello World'); networkRequest(); console.log('The End');

// Uzd2 

//Asynchronous
setTimeout(asynchroChangeText, 3000);

function asynchroChangeText() {
  alert("Asynchronous");
  p = document.getElementsByTagName('p')[0];
  p.innerHTML = "Asynchronous - Text changed!";
  p.style.backgroundColor = 'red';
}


//Synchronous

setTimeout(() => {
  alert("Synchronous");
  p = document.getElementsByTagName('p')[0];
  p.innerHTML = "Synchronous - Text changed!";
  p.style.backgroundColor = 'yellow';
}
  , 2000);














