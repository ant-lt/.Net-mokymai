const registrationForm = document.querySelector('#registration-form');
const registrationFormSbmBtn = document.querySelector('#registration-form-submit');
const errorEle = document.querySelector(".error-message");

function sendData() {
    let data = new FormData(registrationForm);
    let obj = {};

    console.log(data);

    // #1 iteracija -> obj {name: 'asd'}
    // #2 iteracija -> obj {type: 'asd'}
    data.forEach((value, key) => {
        // console.log(`${key}(Key): ${value}(Value)`);
        obj[key] = value
    });

    fetch('https://localhost:7227/api/User/register', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj) // naudojame nes objekte neturim .json metodo
    })
    .then( async res => {
        console.log(res.status);
        if (res.ok)
        {
            window.location.href = "./index.html";            
        }

        console.log(res);
        var resBody = await res.json();
        errorEle.textContent = resBody.message;

    })
    .catch((klaida) => console.log(klaida));
}
registrationFormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    sendData();
})