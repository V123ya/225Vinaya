// There are 2 syntaxes for creating an empty array:
let arr = new Array();
let arr = [];

//Almost all the time 2nd syntax is used. We can supply initial elements in the brackets: 
let fruits = ['apple','Mango', 'cherry'];

// We can get an Element by its square brackets:
let fruits = ['apple','Mango', 'cherry'];
console.log( fruits[0]);
console.log( fruits[1]);
console.log( fruits[2]);

//We can Replace an element
fruits[2]="pear"; //now["apple","Mango","pear"]

//...Or add a new one to the array:
fruits[3]='pine';  //now["apple","Mango","pear","pine"]

//The total count of the elements in the array is the length:
let fruits = ["apple","Mango","pear"];
console.log( fruits.length);
                            

         //Methods to work at end of the array(pop,push):
//Extract the last element of the array :
let fruits = ['apple','Mango', 'cherry'];
console.log(fruits.pop());// removing cherry 
console.log(fruits); // o/p : ['apple','Mango'];

//Add the element at the end of the array:
let fruits = ['apple','Mango'];
console.log(fruits.push());// Adding cherry 
console.log(fruits); // o/p : ['apple','Mango','Cherry'];

           //Methods to work at beginning of the array(shift,unshift):
//Extract the first element of the array :
let fruits = ['apple','Mango', 'cherry'];
console.log(fruits.shift());// removing apple 
console.log(fruits); // o/p : ['Mango','cherry'];

//Add the element at the first of the array:
let fruits = ['apple','Mango'];
console.log(fruits.unshift());// Adding cherry 
console.log(fruits); // o/p : ['Cherry''apple','Mango'];

