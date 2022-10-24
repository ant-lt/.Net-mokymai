function changeFirstLi() {
    const ul = document.getElementsByTagName('ul')[0];
    const kavos_li = ul.getElementsByTagName('li')[0];
    kavos_li.innerHTML += ` Kitas gerimas`;
  }
  //-------------------
  function addMilkLi() {
    const ul = document.getElementsByTagName('ul')[0];
    ul.innerHTML += `<li class="drink milk">Milk</li>`;
  }
  //-------------------
  function countLi() {
    const ul = document.getElementsByTagName('ul')[0];
    const li_count = ul.children.length;
    return `ul has ${li_count} items`;
  }
  //-------------------
  function changeCoffee() {
    const li = document.getElementsByClassName('coffee')[0];
    li.innerHTML = `Karštas šokoladas`;
  }
  //-------------------
  function changeMilkToAlmindDrink() {
    const list_of_li = document.getElementsByClassName('milk');
    for (const li of list_of_li) {
      li.innerHTML = 'Migdolu gerimas';
    }
  }
  //-------------------
  function changeStyleOfWater() {
    const list_of_li = document.getElementsByClassName('water');
    for (const li of list_of_li) {
      li.style.backgroundColor = 'blue';
    }
  }
  //-------------------
  function changeStyleOfMilk() {
    const list_of_li = document.getElementsByClassName('milk');
    for (const li of list_of_li) {
      if (li.classList.contains('pretty_milk')) {
        li.classList.remove('pretty_milk');
      } else {
        li.classList.add('pretty_milk');
      }
    }
  }
  //-------------------
  function changeStyleOfTea() {
    const ul_of_tea_types = document.querySelector('#tea_types');
    const list_of_tea_types_li = ul_of_tea_types.children;
    const li_of_tea = ul_of_tea_types.parentElement;
    if (!li_of_tea.classList.contains('pretty_tea')) {
      li_of_tea.classList.add('pretty_tea');
    }
    for (const li of list_of_tea_types_li) {
      li.style.margin = '5px';
      li.style.padding = '10px';
      switch (li.innerHTML) {
        case 'Juoda arbata':
          li.style.backgroundColor = '#923c01';
          break;
        case 'Zalia arbata':
          if (!li.classList.contains('pretty_green_tea')) {
            li.classList.add('pretty_green_tea');
          }
          break;
      }
    }
  }
