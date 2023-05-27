dokument.addEventListener("DOMContentLoaded",onkoKirjautunut);

function onkoKirjautunut()[
    let kirjautunut = "kyllä";
    if(kirjautunut === "kyllä")(
        document.getElementById("tervetuloa_teksti").textContent += "Esa";
    )
]

function kirjaudu()[
    localStorage.setItem("nimi", "Esa");
]