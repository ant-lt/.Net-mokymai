const showValues = () => {
  lbl_mokymai_key.innerHTML = sessionStorage.mokymai_key ?? '-';
  lbl_kitas_raktas.innerHTML = sessionStorage.kitas_raktas ?? '-';
  lbl_mokymai_localStorage.innerHTML = localStorage.mokymai_localStorage ?? '-';
  document.querySelector('#lbl_json_localStorage').innerHTML =
    localStorage.json_localStorage ?? '-';
};

document.addEventListener('DOMContentLoaded', showValues);

btn_setSessionStorage.addEventListener('click', () => {
  sessionStorage.setItem('mokymai_key', 'kazkokia nusetinta reiksme');
  txt_setSessionStorage.innerHTML = 'irasyta sekmingai';
  txt_setSessionStorage.style.color = `green`;
});
//--------------------------------------
btn_setSessionStorage1.addEventListener('click', () => {
  sessionStorage.setItem('kitas_raktas', 'kazkokia kito rakto reiksme');
  txt_setSessionStorage1.innerHTML = 'irasyta sekmingai';
  txt_setSessionStorage1.style.color = `green`;
});
//--------------------------------------
btn_setLocalStorage.addEventListener('click', () => {
  const asmuo = { vardas: `Agne`, pavarde: `Agniene` };
  localStorage.setItem('mokymai_localStorage', asmuo);
  txt_setLocalStorage.innerHTML = 'irasyta sekmingai';
  txt_setLocalStorage.style.color = `green`;
});
//--------------------------------------
btn_json_localStorage.addEventListener('click', () => {
  const asmuo = { vardas: `Agne`, pavarde: `Agniene` };
  localStorage.setItem('json_localStorage', JSON.stringify(asmuo));
  txt_json_localStorage.innerHTML = 'irasyta sekmingai';
  txt_json_localStorage.style.color = `green`;
});
//--------------------------------------
btn_get_mokymai_key.addEventListener('click', () => {
  const val = sessionStorage.getItem('mokymai_key');
  txt_get_mokymai_key.innerHTML = val ?? `??nieko nera??`;
});
//--------------------------------------
btn_get_kitas_raktas.addEventListener('click', () => {
  const val = sessionStorage.getItem('kitas_raktas');
  txt_get_kitas_raktas.innerHTML = val ?? `??nieko nera??`;
});
//--------------------------------------
btn_get_mokymai_localStorage.addEventListener('click', () => {
  const val = localStorage.mokymai_localStorage; //Object-like access
  txt_get_mokymai_localStorage.innerHTML = val ?? `??nieko nera??`;
});
//--------------------------------------
btn_get_json_localStorage.onclick = () => {
  const val = localStorage.json_localStorage; //Object-like access
  txt_get_json_localStorage.innerHTML = val ?? `??nieko nera??`;
};
//--------------------------------------
btn_remove_mokymai_key.onclick = () => {
  sessionStorage.removeItem('mokymai_key');
  showValues();
};
//--------------------------------------
btn_remove_kitas_raktas.onclick = () => {
  sessionStorage.removeItem('kitas_raktas');
  showValues();
};
//--------------------------------------
btn_remove_mokymai_localStorage.onclick = () => {
  localStorage.removeItem('mokymai_localStorage');
  showValues();
};
//--------------------------------------
btn_remove_json_localStorage.onclick = () => {
  localStorage.removeItem('json_localStorage');
  showValues();
};
//--------------------------------------
btn_clearSessionStorage.onclick = () => {
  sessionStorage.clear();
  showValues();
};
//--------------------------------------
btn_clearLocalStorage.onclick = () => {
  localStorage.clear();
  showValues();
};
//--------------------------------------
btn_loop.onclick = () => {
  const keys = Object.keys(sessionStorage);
  const lst = document.querySelector('#lst_loop');
  for (const key of keys) {
    lst.innerHTML += `<li>${key}: ${sessionStorage.getItem(key)}</li>`;
  }
};
//--------------------------------------
window.addEventListener('storage', (event) => {
  showValues();
  console.log(event.key + '  changed to value ' + event.newValue);
});
//--------------------------------------
const saveFormData = (key, value) => {
  const json = sessionStorage.getItem('formData'); //nuskaitome rakta is sessionSorage
  const obj = JSON.parse(json); //nuskaityta string verciame i objekta
  const o = Object.assign({}, obj); //padarome objekta jeigu obj yra undefined
  o[key] = value; //pakeiciam o properti, jeigu tokio propercio objekte nera - sukuriamas naujas
  sessionStorage.setItem('formData', JSON.stringify(o)); //graziname pakeistas reiksmes i sessionSorage
};
f_name.addEventListener('change', (e) => {
  saveFormData('name', e.target.value);
});
f_mail.addEventListener('change', (e) => {
  saveFormData('mail', e.target.value);
});
f_msg.addEventListener('change', (e) => {
  saveFormData('message', e.target.value);
});
document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(sessionStorage.getItem('formData')));
  f_name.value = o.name ?? ``;
  f_mail.value = o.mail ?? ``;
  f_msg.value = o.message ?? ``;
});