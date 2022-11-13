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

    if (!logUser) {
        //document.querySelector(".todo-section").style.display = "none";
        //document.querySelector(".not-logged-in").style.display = "block";
        alert('Jūs nesate prisijungę! Prisijunkite.');
        window.location.href = "../index.html";
    };

    if (logUser) {
        document.querySelector(".loged-in-user").innerText = "Prisijungusio vartotojo " + logUser.FirstName + " " + logUser.LastName+ " TO DO:";
        console.log(logUser);
        //user_name.innerHTML = user.FirstName + " " + user.LastName;

        function createTbodyTr(arr) {
            document.querySelector("tbody").innerHTML = "";
            arr.forEach((obj) => {
              let trEl = document.createElement("tr");
        
              let tdTodoContent = document.createElement("td");
              let tdType = document.createElement("td");
              let tdEndDate = document.createElement("td");
        
              let updateObj = {
                key: logUser.FirstName + logUser.LastName,
                content: obj.content,
                type: obj.type,
                end_date: obj.end_date,
              };
        
              // inputs
        
              let inputTodoContent = document.createElement("input");
              inputTodoContent.setAttribute("value", obj.content);
              inputTodoContent.setAttribute("class", "todo-content-input");
        
              let inputTodoType = document.createElement("input");
              inputTodoType.setAttribute("value", obj.type);
              inputTodoType.setAttribute("class", "todo-type-input");
        
              let inputTodoEndDate = document.createElement("input");
              inputTodoEndDate.setAttribute("value", obj.end_date);
              inputTodoEndDate.setAttribute("class", "todo-end-date");
        
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
        
              // Input events
        
              document.querySelector(".todo-content-input").addEventListener("input", (e) => {
                updateObj.content = e.target.value;
              });
        
              document.querySelector(".todo-type-input").addEventListener("input", (e) => {
                updateObj.type = e.target.value;
              });
        
              document.querySelector(".todo-end-date").addEventListener("input", (e) => {
                updateObj.end_date = e.target.value;
              });
        
              // HTTP req events
        
              document.querySelector(".delete-btn").addEventListener("click", async () => {
                console.log('delete btn');      
                console.log(obj.id);                

                await  fetch(urlToDo + obj.id, {
                    method: 'delete',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    }
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
        

              document.querySelector(".update-btn").addEventListener("click", async () => {
                console.log('Update-btn');
                console.log(updateObj);
                console.log(obj.id);

              await  fetch(urlToDo + obj.id, {
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
              (el) => el.key === logUser.FirstName + logUser.LastName,
            );
        
            if (filteredTodos.length > 0) {
              document.querySelector("table").style.display = "block";
        
              createTbodyTr(filteredTodos);
            }
          }
        
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
            console.log(e.target.value);
            newTodoObj.end_date = e.target.value;
        });
        
        newTodoObj.key = logUser.FirstName + logUser.LastName;
        
        document.querySelector(".add-new-todo").addEventListener("click", async (e) => {
            e.preventDefault();
         
           console.log(newTodoObj);
          
           
           await fetch(urlToDo, {
                method: 'post',
                headers: {
                    'Accept': 'application/json, text/plain',
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


