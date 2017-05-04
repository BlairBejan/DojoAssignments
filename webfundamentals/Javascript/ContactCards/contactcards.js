$(document).ready(function(){
  $(".contactinfo").submit(function(){
    var name = "<h3>" + $(".name1").val() +  " " + $(".name2").val() + "</h3>";
    var description = "<p>" + $(".description").val() + "</p>";
    $(".Contacts").append("<div>" + name + "<h3>Click for description</h3>" + "</div>");
    $(document).on("click", "div", function(){
      $("div h3").hide();
      $(".Contacts").append(description);
    });
    return false;
  });
});
