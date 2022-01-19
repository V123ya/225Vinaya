//copy by reference
let fruits = ["banana"];
let arr = fruits;//copy by reference(two variable reference the same array)
console.log(arr === fruits);//true
arr.push("Pear"); //modify the array by reference
console.log(fruits); //Banana,Pear - 2 iteams now



//Loops
let arr = ["Pine","Banana","Pear"];
for(let i=0;i<arr.length;i++) {
    console.log(arr[i]);
}


//But for arrays there is another form of loop, for..of:
let fruits = ["Pine","Banana","Pear"];

//iterates over array elements:
for(let fruit of fruits) {
 console.log(fruits)
}