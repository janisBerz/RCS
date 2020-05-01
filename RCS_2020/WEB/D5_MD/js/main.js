//1. Konstantas
//1. Izveidojam konstantu g (brīvā kritiena paātrinājums) un piešķiram vērtību 9.8
const g = 9.8;

//2. Izveidot mainīgo m (massa) = 80
let m = 80;

//3. Aprēķināt svaru ņūtonos, atbildi ierakstīt mainīgajā
let k = m * g;

//4. Izvadīt rezultātu konsolē
console.log("Forece in Newtons: " + k);

//2. Tipu mainīšana
//1. Izveidojiet 2 string mainīgos ar vērtībām «12.5» un «-5.7»
let a = "12.5";
let b = "-5.7";

//2. Apvienojiet šos mainīgos kā rindas un izvadiet konsolē
console.log(a + b);

//3. Pārvērtiet šos mainīgos par skaitļiem un ierakstiet atpakaļ mainīgajos
a = Number(a);
b = Number(b);

//4. Izvadiet šo mainīgo summu konsolē
console.log("Sum: " + (a + b));

//3. Matemātiskās darbības
// 1. Dots šāds vienādojums: (8 + 15) / ((14 – 9) * (7.8 – 15 * 14)). Izpildiet to ar JavaScript un rezultātu izvadiet konsolē
let calcA = (8 + 15) / ((14 - 9) * (7.8 - 15 * 14));
console.log("Result: " + calcA);

// 2. Katru vienādojuma skaitli ierakstiem mainīgajā, piem. let a = 8; let b = 15; u.t.t Ja skaitlis atkārtojas, tad nevajag veidot vairākus mainīgos
let c = 8;
let d = 15;
let e = 14;
let f = 9;
let g = 7.8;

// 3. Aizvietojiet vienādojumā skaitļus ar mainīgajiem, pārbaudiet vai rezultāts sakrīt ar 1. rindas rezultātu
let calcB = (c + d) / ((e - f) * (g - d * e));
console.log("Is equal: " + (calcA == calcB));

// 4. Izveidojiet 2 rindas – «12» un «40».

let stringOne = "12";
let stringTwo = "40";

// 5. Apvienojiet šīs rindas ar «+» zīmi un izvadiet rezultātu konsolē
console.log(stringOne + stringTwo)

// 6. Apvienojiet šīs rindas ar «+» zīmi, sākotnēji izlaižot caur funkciju Number, un izvadiet rezultātu konsolē
let sum = Number(stringOne) + Number(stringTwo);

console.log(sum);

// 7. Paskaidrojiet 5. un 6. punkta rezultātu atšķirību

// Funkcija "Number" konvertē  "stringOne" ar tipu string uz tipu integer un tas pats notiek ar "stringTwo". Kad konvertācija veikta abus mainīgos var matemātiski saskaitīt.