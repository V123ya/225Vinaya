class Order {
    constructor(name){
        this.name = name;
    }

    GetOrderName() {
        console.log(`${this.name} is the order name`);

    }
}

class Product extends Order {
    constructor(name){
        super(name); // call the super class constructor and pass in the name parameter
    }
     
    GetProductDetails() {
        console.log(`${this.name} is the product`);
    }

}
var P = new Product ('mobile');
P.GetOrderName();
P.GetProductDetails();
