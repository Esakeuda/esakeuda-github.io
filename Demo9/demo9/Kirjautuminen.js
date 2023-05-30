document.addEventListener("DOMContentLoaded", tarkistaKirjautuminen);

function tarkistaKirjautuminen() {
  if (localStorage.getItem("kirjautunut") === "kyllä") {
    document.getElementById("tervetulo_teksti").textContent += " " + localStorage.getItem("nimi");
    document.getElementById("kirjautumis_lomake").style.display = "none";
    document.getElementById("kirjaudu_ulos_nappi").style.display = "block";
  } else {
    document.getElementById("kirjautumis_lomake").style.display = "block";
    document.getElementById("kirjaudu_ulos_nappi").style.display = "none";
  }
}

function kirjaudu() {
  localStorage.setItem("nimi", document.getElementById("nimi").value);
  localStorage.setItem("kirjautunut", "kyllä");
  tarkistaKirjautuminen();
}

function kirjauduUlos() {
  localStorage.removeItem("nimi");
  localStorage.removeItem("kirjautunut");
  tarkistaKirjautuminen();
}
