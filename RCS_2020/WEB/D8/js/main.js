"use strict"

console.log(document.body);

// for (let node of document.body.childNodes) {
//     console.log(node)
//     if (node.nodeName == 'UL') {
        
//     }
// }


let header = document.getElementById("vv");

header.innerText = "<span> blah blah </span>";

let element = document.querySelector("h1");
element.style.fontSize = "10";
let elements = document.querySelectorAll("ul li")

element.innerHTML = "juris";


for (let elem of elements){
    console.log('elem :>> ', elem);
    elem.style.color = "#0c0";
}


let par = document.querySelector("p");

par.style.fontStyle = "italic";

function hide() {
    let opacity = Number(document.body.style.opacity);
    opacity -= 0.01;

    if(opacity <= 0) opacity = 0;
    document.body.style.opacity = opacity;
    if (opacity > 0) setTimeout(hide, 5)
}

document.body.style.opacity = 1;

hide()

console.log(element.hasAttribute("id"));

element.innerHTML.querySelector

