var arry = [1, 5, 1, 3, 4, 3, 5];

var Fin = arry => arry.filter((item, index) => arry.indexOf(item) !== index)
var duplicateElements = Fin(arry);

console.log(duplicateElements);


