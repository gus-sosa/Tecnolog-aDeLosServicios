$(document).ready(function(){
    console.log("document ready");
})
$("img.img-circle").click(function() {
    var id = $(this).closest("a").attr("href");
    $(id).toggle("slow", function() {
        $(this).attr("style", "");
    });
});