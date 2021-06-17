/* define functions here */

//This function returns the product of prices and quantities
function calculatetotal(price, quantity){
        return price*quantity;
}

// this function is showing each row of the table
function outputCartRow(file, title, quantity, price, total)
{
    document.write("<tr>");
    document.write("<td><img src='ass1_images/"+file+"' ></td>");
    document.write("<td>"+title+"</td>");
    document.write("<td class='center'>"+quantity+"</td>");
    document.write("<td class='right'>"+"$"+price.toFixed(2)+"</td>");
    document.write("<td class='right'>"+"$"+total.toFixed(2)+"</td>");
    document.write("</tr>");      
}

//these functions are to calculate the tax, shipping, and grand total
var subtotal=0;
var grandTotal, tax, shipping;

function calculatesubtotal(price,quantity)
{
//this loop calculate the subtotal
        for(var k=0;k<price.length;k++){
                subtotal+=calculatetotal(price[k], quantity[k]);
        }
        //showing the calculations in the rows
        document.write("<tr class='totals'>");
        document.write("<td colspan='4'>Subtotal</td>");
        document.write("<td>"+"$"+ subtotal.toFixed(2)+"</td>");
        document.write("</tr>");
}

function calculateTax(){
        //tax variable is calculating the 10% as the tax amount.
        tax=((subtotal.toFixed(2))*10)/100;      
        document.write("<tr class='totals'>");
        document.write("<td colspan='4'>Tax</td>");
        document.write("<td>"+"$"+tax.toFixed(2)+"</td>");
        document.write("</tr>");

}

function calculateShipping()
{      
        if(subtotal>1000)
                 shipping=0;
        else
                 shipping=40;       
        document.write("<tr class='totals'>");
        document.write("<td colspan='4'>Shipping</td>");
        document.write("<td>"+"$"+shipping.toFixed(2)+"</td>");
        document.write("</tr>");
        
}

//calculating the summation of subtotal, tax, and shipping
function calculateGrandTotal()
{
        grandTotal=subtotal+tax+shipping;
        document.write("<tr class='totals focus'>");
        document.write("<td colspan='4'>Grand Total</td>");
        document.write("<td colspan='4'>"+"$"+grandTotal.toFixed(2)+"</td>");
        document.write("</tr>");    
      
}
