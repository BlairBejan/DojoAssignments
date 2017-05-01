"use strict";
$(document).ready(function(){
  $("img").click(function(){
    $(this).hide(this);
  });
  $("button").click(function(){
    $("img").show();
  });
});
