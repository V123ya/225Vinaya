
function checkGender() {  
            if(document.getElementById('Male').checked) { 
                document.getElementById("result").innerHTML 
                    = " Gender : Male"; 
            } 
            else if(document.getElementById('Female').checked) { 
                document.getElementById("result").innerHTML 
                    = "Gender : Female";
                       
            }
            else { 
                document.getElementById("result").innerHTML 
                    = "Gender : Other"; 
            } 
        } 