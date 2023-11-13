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