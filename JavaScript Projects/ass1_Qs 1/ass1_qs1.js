//Defining nested functions to output books, and authors

function OutputBooks(books)
{ 
           document.write("<br>"+"<b class='title'>"+books[i].title+"</b>"+"<br>");
           document.write("<br>"+"<b>"+books[i].publisher+"</b>"+"<br>"+"<br>");
           OutputAuthor();  
           function OutputAuthor()
           {
            var count=books[i].author.length;
            for(var j=0;j<count;j++)
            {
                document.write("Author's Name: "+books[i].author[j].firstName+" "+books[i].author[j].lastName+"<br>");
            }
           }      
}


//Defining the multidimensional array books

var books=[
    {  
    title: "Data Structures and Algorithm Analysis in C++",  
    publisher: "Pearson",  
    author: [{firstName:"Mark",lastName:"Weiss"}],  
    },

    {  
    title:"Foundations of Finance",  
    publisher: "Pearson",  
    author: [{firstName:"Arthur",lastName:"Keown"},{firstName:"John",lastName:"Martin"}],  
    },

    {  
     title: "Literature for Composition",  
     publisher: "Longman",  
     author: [{firstName:"Sylvan",lastName:"Barnet"},{firstName:"William",lastName:"Cain"},{firstName:"William",lastName:"Burto"}],  
    },
    ];

//Showing the output

var i;
document.write("<div class='box'>");
for(i=0; i<books.length;i++){
    OutputBooks(books);
}
document.write("</div>");