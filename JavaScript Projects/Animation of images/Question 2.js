function removePreview(e) { 
        $("figure img").attr('class', 'Normal');
        $(".Image-preview").attr("src",null); 
        $(".Image-box").hide();      
}

function movePreview(e) {
    $(".Image-box").offset({
        left: e.pageX,
        top: e.pageY + 20
      });
}    
$( document ).ready(function() {
    $("figure img").mouseleave(function(e) {
        removePreview(e);
    });
    $("figure img").mousemove(function(e){
        $(this).attr('class', 'Gray');
        movePreview(e);
        var src =  $(this).attr('src');
        var imgnameset = src.split('-');
        var filename = imgnameset[imgnameset.length-2];
        filename+="-large.jpg"; 
        $(".Image-box").show(); 
        $(".Image-preview").attr("src", filename); 
        $("figcaption").html( $(this).attr("alt") );
    });    
});