const animalForm = document.querySelector('#animal-form');
const animalFormSbmBtn = document.querySelector('#animal-form-submit');

function sendData() {
    let data = new FormData(animalForm);
    let obj = {};

    // #1 iteracija -> obj {name: 'asd'}
    // #2 iteracija -> obj {type: 'asd'}
    data.forEach((value, key) => {
        // console.log(`${key}(Key): ${value}(Value)`);
        obj[key] = value
    });

    const urlFetchAnimal = 'https://testapi.io/api/Vitas/resource/Animals' + obj.id;
    const optionsFetchAnimal = {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    }

    fetch(urlFetchAnimal, optionsFetchAnimal)
    .then((response) => console.log(response.json()))
    .catch((error) => {
        console.log(`Request failed with error: ${error}`);
    })

}


animalFormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    sendData();
})