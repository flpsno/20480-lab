function cadastrar(nome) {

    sessionStorage.setItem("nome", nome);

    var online = navigator.onLine;
    
    if (online) {
        location.href = "comrede.html";
    } else {
        location.href = "offline.html";
    }
}