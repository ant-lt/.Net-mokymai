const url = 'https://swapi.dev/api/species'
//const url = 'https://api.meteo.lt/v1/places/vilnius'

const options = {}

const rezult = {};



fetch(url, options)
//.then( response => response.json()  )
.then( res => { 
    if( res.ok ){
        console.log( res );
        return res.json(); 
    } else {
        console.log( "Got error. Status : " + res.status ) 
    }

})
.then( data => console.log(data.results[2]));



const loadDataAsync = async () =>{
    try{
        const response = await fetch (url);
        const data = await response.json();
        console.log(data);

        showData( data );

    
    }catch ( error) {
    console.error(error);
    }
}

loadDataAsync();
console.log("Mes dabar esam cia");


const showData = data => {
    //Atlikti cia uzduoti
    let html = `<table>
    <tr>
      <th rowspan="1">Name</th>
      <th rowspan="1">Classification</th>
      <th rowspan="1">Average_height</th>
    </tr>`;
    console.log(data.results);
    
    data.results.forEach( record=> {
        let htmlSegment = `<tr>
        <td>${record.name}</td>
        <td>${record.designation}</td>
        <td>${record.average_height}</td>
      </tr>`;
      html += htmlSegment;
    });

    html+= `</table>`;

    let container = document.querySelector('.container');
        
    container.innerHTML = html;

}


