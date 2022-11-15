const urlUsers = 'https://testapi.io/api/Vitas/resource/users';
const urlToDo = 'https://testapi.io/api/Vitas/resource/todo/';

const optionsGet = {
    method: 'get',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
};

const optionsPost = {
    method: 'post',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
};


const saveToLocalStorage = (obj) => {
    localStorage.setItem('TODOLOGUSER', JSON.stringify(obj));
};


