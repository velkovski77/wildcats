$(document).ready(function () {
    $('#fade').list_ticker({
        speed: 9000,
        effect: 'fade'
    });
    $('#slide').list_ticker({
        speed: 9000,
        effect: 'slide'
    });

    //limit  text to show
  
    	$(function(){
    	    var $elem = $('.textinspan'); 		// The element or elements with the text to hide
    	    var $limit = 300;		// The number of characters to show
    	    var $str = $elem.html();	// Getting the text
    	    var $strtemp = $str.substr(0,$limit);	// Get the visible part of the string
    	    $str = $strtemp + '<span class="hide">' + $str.substr($limit,$str.length) + '</span>';	// Recompose the string with the span tag wrapped around the hidden part of it
    	    $elem.html($str);		// Write the string to the DOM 
    	})
    

});

