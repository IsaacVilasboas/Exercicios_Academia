function toggleFontColor() {
    var paragraph = document.getElementById("p");
    if (paragraph.style.color === "black" || paragraph.style.color === "") {
        paragraph.style.color = "white";
    } else {
        paragraph.style.color = "black";
    }
}
function toggleBgColor() {
    var paragraph = document.getElementById("p");
    if (paragraph.style.backgroundColor === "white" || paragraph.style.backgroundColor === "") {
        paragraph.style.backgroundColor = "black";
    } else {
        paragraph.style.backgroundColor = "white";
    }
}
let Fonte = 16; 

function Aumentar() {
    Fonte += 2;
    atualizarFonte();
}

function Diminuir(){
    Fonte -= 2;
    atualizarFonte();
}

function atualizarFonte(){
    let p = document.getElementById('p');
    p.style.fontSize = Fonte + 'px';
    document.getElementById('fonte').textContent = Fonte;

}

function Maiusculo(){
    let p = document.getElementById("p")

    p.innerHTML = p.innerHTML.toUpperCase();
}


function Minusculo(){
    let p = document.getElementById("p")

    p.innerHTML = p.innerHTML.toLowerCase();
}
