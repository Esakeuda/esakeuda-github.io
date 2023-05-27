dokument.addEventListener("DOMContentLoaded",onkoKirjautunut);

function onkoKirjautunut(){
    let kirjautunut = "kyllä";
    if(kirjautunut === "kyllä"){
        document.getElementById("tervetulo_teksti").textContent += "Esa";
    }
}

function kirjaudu(){
    localStorage.setItem("nim" , document.getElementById("nimi").value);
}