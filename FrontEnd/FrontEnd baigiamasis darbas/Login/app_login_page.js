const urlUsers = 'https://testapi.io/api/Vitas/resource/users';
const optionsGet = {
    method: 'get',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
}

const saveToLocalStorage = (obj) => {
    localStorage.setItem('TODOLOGUSER', JSON.stringify(obj));
};


const onLoginSubmit = async (e) => {
    e.preventDefault();
    const formElem = e.target;
    const formData = new FormData(formElem);

    console.log(formData.get('first_name')); // vardas
    console.log(formData.get('last_name')); // pavarde

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

        const userLogData = {
            ID: foundUsers[0].id,
            FirstName: foundUsers[0].first_name,
            LastName: foundUsers[0].last_name,
            Email: foundUsers[0].email
        }


       saveToLocalStorage(userLogData);

       
        window.location = '../todo/to_do_app_page.html';
        
      } else {
        document.querySelector(".popup-auth-error").style.display = "block";

        document.querySelector(".close-poup")?.addEventListener("click", () => {
        document.querySelector(".popup-auth-error").style.display = "none";
        window.location = '../login/login_page.html';
        });
    }

  };

  form_login.addEventListener('submit', onLoginSubmit);
  