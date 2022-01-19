

    class hotelroom{
        constructor(image,price,RoomID,Roomtype,withview,withAc,food,clubacess)
        {
            this.image= image;
            this.price= price;
            this.RoomID=RoomID;
            this.Roomtype = Roomtype;
            this.withview = withview;
            this.withAc = withAc;
            this.food =food;
            this.clubacess =clubacess;
        }
        
 
   display()
    {
       document.write("<br/>"+ this.image);
       document.write("<br/> the price"+ this.price);
       document.write("<br/> the Id is"+ this.RoomID);
       document.write("<br/> the type is"+ this.Roomtype);
       document.write("<br/> the room view"+ this.withview); 
       document.write("<br/> Room with AC"+ this.withAC);
       document.write("<br/> With food"+ this.food);
       document.write("<br/> with clubacess"+ this.clubacess);

       }
    }

  var h1 = new hotelroom("pm2.png",4000,101,"Executive room","no","yes", "yes");
  var h2 = new hotelroom("pm.png",4500,102,"Junior Suite","no","yes","yes");
  var h3 = new hotelroom("pr3.png",6000,201,"The Suite", "yes",  "yes", "yes");
  var h4 = new hotelroom("s1.png",4600, 202,"Junior Suite", "no",  "yes", "yes");
  var h5 = new hotelroom("s2.png",4100, 202,"Executive room", "no",  "yes", "yes");
  var h6 = new hotelroom("s3.png",5000, 202,"The Suite", "yes",  "yes", "yes");
  var h7 = new hotelroom("jn.png",4600, 202,"Junior Suite", "no",  "yes", "yes");

 /*h1.display();  
  h2.display();
  h3.display();
  h4.display();*/

