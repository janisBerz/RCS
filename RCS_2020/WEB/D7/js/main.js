"use strict"

function buyMilk(money) {
    let milkPrice = 1.14;
    console.log("Visit the closest shop");
    console.log("Find the milk");

    if (money >= milkPrice) {
        console.log("Buy the milk");
        console.log("Bring the milk home");
    } else {
        console.log("Yu don;t have enough moneyzz");
        console.log("We need to get moneyzzz");
    }
}

buyMilk(123);
console.log();
buyMilk(1);

function foo() {
    console.log(this === undefined)
}
foo();

// let func;
// let x = prompt("Enter a number");
// if (x < 0) func = function () {
//     console.log("Integer is less than zero")
// }; else if (x == 0) func = function () {
//     console.log("Integer is  zero")
// }; else func = function () {
//     console.log("Integer bigger than zero")
// };

// func();

function sum(a, b, c) {
    return a + b + c
}

let sumArrow = (a, b, c) => (a + b + c)

console.log(sumArrow(3, 5, 6))

let array = [];

array = ["Janis", "Juris", "kārlis", "Pēteris", "Jurģis", "Burka", "Žanis"]

console.log(array[1].toUpperCase());

for (let index = 0; index < array.length; index++) {
    const element = array[index];
    console.log(element.toUpperCase());
}

console.log("---------");

array.forEach(element => {
    console.log(element)
});

console.log("---------");

function printArray(params) {
    console.log(`Masīva garums ${array.length}`)

    for (let key in array) {
        console.log(`Elements ar indeksu ${key} - ${array[key]}`)
    }

    console.log("---------");
    for (let key of array) {
        console.log(`Elements - ${key}}`)
    }
}

printArray(array)


let person = {
    firstName: "Janis",
    lastName: "Berzins",
    age: 40,
    hobbies: ['foto', 'travel', 'web'],
    getInfo: function () {
        return `${this.firstName}' hobbies are: ${this.hobbies}`
    },
    familly: {
        brothers: [
            {
                firstName: "Juris",
                age: 33
            },
            {
                firstName: "Karlis",
                age: 45
            }
        ],
        sisters: [
            {
                firstName: "Liene",
                age: 33
            }
        ]
    }
}

console.log('-----------Objects----------');
console.log(person.getInfo());
console.log(person.familly.brothers.brothers);


console.log('-----------JS&HTML----------');

// let integer = document.getElementById('counter');
// console.log(integer);
// let counter = 0;

// function increment() {
//     counter++;
//     integer.innerText = counter;
//     console.log(counter);
//     return;
// }

// function decrement() {
//     counter--;
//     integer.innerText = counter;
//     console.log(counter);
//     return;
// }

let counter = 0;

function updateCounterEl() {
    let counterEl = document.querySelector('#counter');
    //console.log(counterEl);
    counterEl.innerText = counter;
    console.log(counter);
}

function increment() {
    counter++;
    updateCounterEl();
}

function decrement() {
    counter++;
    updateCounterEl();
}