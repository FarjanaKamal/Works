function ckeckForEmptyFields(requiredfield){
    var flag = 'false';
    var msg = "The following fields can't be empty: ";
    for (var i=0; i<requiredfield.length; i++){
        Value=requiredfield[i].value;
        if(Value==="" || Value==null){
          var inputName=requiredfield[i].name;
          msg += inputName +", ";
          flag='true';
        }         
    } 
    if(flag=='true'){
        var Message=document.getElementById("Message");
        Message.style.display = "block";
        document.getElementById("msg").innerHTML=msg;
    }
    else{
        var Message=document.getElementById("Message");
        Message.style.display = "none";
        document.getElementById("form").submit();
    }  
}

window.onload = function() { 
    var RegisterForm = document.getElementById("form");   
    RegisterForm.addEventListener("submit",function(event){
    event.preventDefault();
    var requiredfield = document.querySelectorAll(".RequiredField");
    ckeckForEmptyFields(requiredfield)  
    })
            
}