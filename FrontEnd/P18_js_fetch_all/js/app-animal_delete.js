const animalForm = document.querySelector('#animal-form');
const animalFormSbmBtn = document.querySelector('#animal-form-submit');

function sendData() {
    let data = new FormData(animalForm);
    let obj = {};

  
    console.log(data);

    // #1 iteracija -> obj {name: 'asd'}
    // #2 iteracija -> obj {type: 'asd'}
    data.forEach((value, key) => {
        // console.log(`${key}(Key): ${value}(Value)`);
        obj[key] = value
    });

    const url = 'https://testapi.io/api/Vitas/resource/Animals/'+obj.id;

    fetch(url, {
        method: 'delete',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj) // naudojame nes objekte neturim .json metodo
    })
    .then( obj => console.log(obj))
    .catch((klaida) => console.log(klaida));
}
animalFormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    sendData();
})