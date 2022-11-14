const url = 'https://testapi.io/api/Vitas/resource/users';


const onRegisterSubmit = (e) => {
    e.preventDefault();
//    console.log(e);
    const formElem = e.target;
    const formData = new FormData(formElem);
    let obj = {};

   // console.log(formData.get('first_name')); // vardas
   // console.log(formData.get('last_name')); // pavarde
   // console.log(formData.get('email')); // el.paštas

    formData.forEach((value, key) => {
     //   console.log(`${key}(Key): ${value}(Value)`);
        obj[key] = value
    });
    // const data = Object.fromEntries(formData);
    // console.log(data);
    fetch(url, {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(res => {
        if (res.ok) {
            console.log(res.json());
            console.log(obj);
            localStorage.setItem('TODOLOGUSER', JSON.stringify(obj));
            window.alert('Naujas vartotojas sukurtas sėkmingai!');        
            window.location = '../todo/to_do_app_page.html';            
        }
        else {
            console.log(res.status);
        }
})

    .catch((klaida) => console.log(klaida));
  };

  form_register.addEventListener('submit', onRegisterSubmit);
