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
}

const logUser = JSON.parse(localStorage.getItem('TODOLOGUSER'));

function createTbodyTr(arr) {
    document.querySelector("tbody").innerHTML = "";
    arr.forEach((obj) => {
      let trEl = document.createElement("tr");
      trEl.setAttribute('id','tr'+obj.id);

      let tdTodoContent = document.createElement("td");
      let tdType = document.createElement("td");
      let tdEndDate = document.createElement("td");

      let updateObj = {
        key: logUser.first_name + logUser.last_name,
        content: obj.content,
        type: obj.type,
        end_date: obj.end_date,
      };

      // inputs

      let inputTodoContent = document.createElement("input");
      inputTodoContent.setAttribute("value", obj.content);
      inputTodoContent.setAttribute("class", "todo-content-input");
      inputTodoContent.setAttribute('id','input-content-id'+obj.id);

      let inputTodoType = document.createElement("input");
      inputTodoType.setAttribute("value", obj.type);
      inputTodoType.setAttribute("class", "todo-type-input");
      inputTodoType.setAttribute('id','input-type-id'+obj.id);

      let inputTodoEndDate = document.createElement("input");
      inputTodoEndDate.setAttribute("value", obj.end_date);
      inputTodoEndDate.setAttribute("class", "todo-end-date");
      inputTodoEndDate.setAttribute('id','input-enddate-id'+obj.id);

      // Input append to td

      tdTodoContent.append(inputTodoContent);
      tdType.append(inputTodoType);
      tdEndDate.append(inputTodoEndDate);

      // Buttons

      let deleteBtn = document.createElement("button");
      deleteBtn.innerText = "Pašalinti";
      deleteBtn.setAttribute("class", "delete-btn");

      let updateBtn = document.createElement("button");
      updateBtn.innerText = "Pakeisti";
      updateBtn.setAttribute("class", "update-btn");

      trEl.append(tdTodoContent, tdType, tdEndDate, updateBtn, deleteBtn);

      document.querySelector("tbody").append(trEl);

      // HTTP req events

      deleteBtn.addEventListener("click", () => {
        console.log('delete btn');      
        console.log(obj.id);                

        fetch(urlToDo + obj.id, {
            method: 'delete',
        })
        .then(res => {
            if (res.ok) {
                getTodos();
            }
            else {
                console.log(res.status);
            }
        })
        .catch((err) =>  console.log(err));
    });


    updateBtn.addEventListener("click", () => {              
        console.log('Update-btn');
        console.log(updateObj);
        console.log(obj.id);
        updateObj.content =document.getElementById('input-content-id'+obj.id).value; 
        updateObj.type=document.getElementById('input-type-id'+obj.id).value;
        updateObj.end_date = document.getElementById('input-enddate-id'+obj.id).value;

        console.log(updateObj.type);
        console.log('End date');
        console.log(updateObj.end_date);

        fetch(urlToDo + obj.id, {
            method: 'put',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(updateObj) 
        })
        .then(res => {
            if (res.ok) {
                console.log(res.json());
                getTodos();
            }
            else {
                console.log(res.status);
            }
        })
        .catch((err) =>  console.log(err));
    
    });

    });
}



async function getTodos() {
      
    const response = await fetch (urlToDo, optionsGet);
    const toDoResponse = await response.json();

    console.log('getTodos');
    console.log(toDoResponse.data);

    let filteredTodos = toDoResponse.data.filter(
      (el) => el.key === logUser.first_name + logUser.last_name,
    );

    if (filteredTodos.length > 0) {
      document.querySelector("table").style.display = "block";

      createTbodyTr(filteredTodos);
    }
}


if (!logUser) {
        alert('Jūs nesate prisijungę! Prisijunkite.');
        window.location.href = "../index.html";
};


if (logUser) {
    console.log('User login');
    document.querySelector(".loged-in-user").innerText = "Prisijungusio vartotojo " + logUser.first_name + " " + logUser.last_name+ " TO DO:";
    console.log(logUser);
            
    getTodos();
        

    document.querySelector(".logout").addEventListener("click", () => {
        console.log('logout');
        localStorage.removeItem('TODOLOGUSER');
        window.location.href = "../index.html";
    });

    // display new to do item input form on click
        document.querySelector(".add-todo").addEventListener("click", () => {
        document.querySelector(".add-todo-form").style.display = "block";
    });
        
    // Add new todo
        
    let newTodoObj = {};
        
    document.querySelector("form input[name='content']").addEventListener("input", (e) => {
        newTodoObj.content = e.target.value;
    });
        
    document.querySelector("form input[name='type']").addEventListener("input", (e) => {
        newTodoObj.type = e.target.value;
    });
        
    document.querySelector("form input[name='end-date']").addEventListener("input", (e) => {
        newTodoObj.end_date = e.target.value;
        //console.log(e.target.value);
    });
        
    newTodoObj.key = logUser.first_name + logUser.last_name;
        
    document.querySelector(".add-new-todo").addEventListener("click", (e) => {
        e.preventDefault();
         
        console.log(newTodoObj);
          
           
        fetch(urlToDo, {
                method: 'post',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(newTodoObj)
        })
        .then(res => {
                if (res.ok) {
                    console.log(res.json());
                    getTodos();
                }
                else {
                    console.log(res.status);
                }
        })
        .catch((err) =>  console.log(err));
    });
};


