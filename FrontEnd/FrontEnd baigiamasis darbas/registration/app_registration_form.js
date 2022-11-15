
const onRegisterSubmit = async (e) => {
    e.preventDefault();
    const formElem = e.target;
    const formData = new FormData(formElem);
    let obj = {};


    formData.forEach((value, key) => {
        obj[key] = value
    });

    const login_first_name = formData.get('first_name');
    const login_last_name = formData.get('last_name');

    const response = await fetch (urlUsers, optionsGet);
    const loginResponse = await response.json();

    console.log(loginResponse.data);

    const foundUsers = loginResponse.data.filter(
        (el) => el.first_name === login_first_name && el.last_name === login_last_name,
    );
    
    console.log(foundUsers);

    if (foundUsers.length > 0) {
        console.log('User found');
        window.alert('Klaida! Vartotojas ' + login_first_name + ' ' + login_last_name + ' jau yra registruotas !');         
    }
    else {

        fetch(urlUsers, {
            method: 'post',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(obj)
        })
        .then(res => {
            if (res.ok) {
                console.log(res.json());
                console.log(obj);

                saveToLocalStorage(obj);
                window.alert('Naujas vartotojas sukurtas sėkmingai!');        
                window.location = '../todo/to_do_app_page.html';            
            }
            else {
                console.log(res.status);
            }
        })
        .catch((klaida) => console.log(klaida));
    }
};

  form_register.addEventListener('submit', onRegisterSubmit);
