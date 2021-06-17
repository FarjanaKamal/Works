/* add loop and other code here ... in this simple exercise we are not
   going to concern ourselves with minimizing globals, etc */
   
function Cart(){ 
//initialize a varibale that is for number of carts which is equal to number of titles exist
cartnumber=titles.length;

//Replacing the cart table rows with the for loop
for(var i=0;i<cartnumber;i++){
   //total variable holds the product of price and quantity using the function
   var total=calculatetotal(prices[i].toFixed(2), quantities[i]);
   //calling the  outputCartRow function
   outputCartRow(filenames[i],titles[i],quantities[i], prices[i], total);
}
}

