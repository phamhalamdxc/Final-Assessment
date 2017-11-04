$(function() {
  $('.side-nav li:has("ul")').children('ul:not(:has(li.active))').hide(); //hide submenu
  $('.side-nav li:has("ul")').addClass('hasChildren'); // add class to li ul child
  $('.side-nav li:has("ul") > a').click(function(evt){
    evt.preventDefault();
    $(this).closest('li').toggleClass( "active" ); // add active class to clicked menu item
    $(this).closest('li').children('ul').slideToggle(); //toggle submenu
  });
});
