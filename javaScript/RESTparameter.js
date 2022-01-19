//The 3rd argument,manyMoreArgs,will be an array that contains
//the 3rd, 4th, 5th, 6th ...nth -as many argumrents that the user includes.

function myFun(a,b,c, ...manyMoreArgs) {
    console.log("a",a)
    console.log("b", b)
    console.log("c",c)
    console.log("manyMoreArgs",manyMoreArgs)
   }


    //Another type of using REST(seperate program)
    
    myFun("one", "two", "there", "four", "five", "six")

    function fun1(...theArgs) {
        console.log(theArgs.length)
    }
    fun1()     //0
    fun1(5)    //1
    fun1(5,6,7) //3