function kirjaudu() {
    event.preventDefault(); // Estä lomakkeen oletustoiminto (sivun uudelleenlataus)
  
    var nimiElementti = document.getElementById("nimi");
    var nimi = nimiElementti.value;
  
    var tervetuloElementti = document.getElementById("tervetulo_teksti");
    tervetuloElementti.textContent = "Tervetuloa, " + nimi + "!";
  }
  