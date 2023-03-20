const url = 'https://localhost:7227/api/Dishes/dishes';
const options = {
    method: 'get'
}

const response = {};

function loadData() {
    fetch(url, options)
    .then((response) => response.json())
    .then((a) => {
        console.log(a);
        const menuContainer = document.getElementById('menu-items');
        let htmlMenuItem = '';

        a.forEach(element => {
            console.log(element);
            let htmlElement = 
            `<article class="menu-item">
                <section class="menu-item-picture">
                    <img src="placeholder-150.bmp" alt="placeholder image">
                </section>
                <section class="menu-item-info">
                    <section class="menu-item-name">
                        <h3>${element.name}</h3>
                    </section>
                    <section class="menu-item-desc">
                        ${element.country} - ${element.type}
                    </section>
                    <section class="menu-item-price">
                        Aštrumas: ${element.spiceLevel}
                    </section>
                </section>
            </article>`;
            htmlMenuItem += htmlElement;
        });

        menuContainer.innerHTML = htmlMenuItem;
    })
}

loadData();