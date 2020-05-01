"use strict"

const jsBtn = document.querySelector("#jsBtn"),
    newItemAdd = document.querySelector("#new-item-add"),
    toDoList = document.querySelector("#todo-list");

    jsBtn.onclick = function () {
        console.log('Poga nospieta');
        let newItemAddValue = newItemAdd.value;

        if (!newItemAddValue) {
            console.warn('Ievadi tekstu');
        } else {
            renderOperation(newItemAddValue);

        }

    }

    const renderOperation = (newItemAddValue) => {
        const listItem = document.createElement('li');
        listItem.classList.add('list-group-item');
        listItem.innerHTML = `<button type="button" class= btn btn-sm btn-outline-danger list-dellete>X</button> ${newItemAddValue}`;
        toDoList.prepend(listItem);

    }