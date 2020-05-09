"use strict";

const jsBtn = document.querySelector("#jsBtn"), // poga
  newItemAdd = document.querySelector("#new-item-add"), // Input lauks
  todoList = document.querySelector("#todo-list"); // UL saraksts

jsBtn.onclick = function () {
  console.log("poga ir nospiesta");
  // Iegūstam input lauka vērtību, ko ieraksta cilvēks
  let newItemAddValue = newItemAdd.value;
  let str = newItemAddValue.trim();

  if (!str) {
    // ja lauks ir tukšs
    alert("Nav ievadīts tekst");
    newItemAdd.classList.add("is-invalid");
    newItemAdd.focus();
  } else {
    // ja lauks ir aizpildīts
    newItemAdd.value = "";
    newItemAdd.classList.remove("is-invalid");
    renderOperation(newItemAddValue);
  }
};
const generateId = () => `id${Math.round(Math.random() * 1e8).toString(16)}`;

const renderOperation = (newItemAddValue) => {
  const listItem = document.createElement("li");
  listItem.classList.add("list-group-item");
  listItem.innerHTML = `<button id="${generateId()}" type="button" class="btn btn-sm btn-outline-danger list-delete">x</button> ${newItemAddValue}`;
  todoList.prepend(listItem);
};

const deleteOperation = (event) => {
  let target = event.target;
  if (target.classList.contains("list-delete")) {
    target.closest(".list-group-item").remove();
  }
};

todoList.addEventListener("click", deleteOperation);
