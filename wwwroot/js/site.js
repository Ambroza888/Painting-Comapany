﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//no jquery

$(function() {
    var $blocks = $('.animBlock.notViewed');
    var $window = $(window);
  
    $window.on('scroll', function(e){
      $blocks.each(function(i,elem){
        if($(this).hasClass('viewed')) 
          return;
          
        isScrolledIntoView($(this));
      });
    });
  });
  
  function isScrolledIntoView(elem) {
    var docViewTop = $(window).scrollTop();
    var docViewBottom = docViewTop + $(window).height();
    var elemOffset = 0;
    
    if(elem.data('offset') != undefined) {
      elemOffset = elem.data('offset');
    }
    var elemTop = $(elem).offset().top;
    var elemBottom = elemTop + $(elem).height();
    
    if(elemOffset != 0) { // custom offset is updated based on scrolling direction
      if(docViewTop - elemTop >= 0) {
        // scrolling up from bottom
        elemTop = $(elem).offset().top + elemOffset;
      } else {
        // scrolling down from top
        elemBottom = elemTop + $(elem).height() - elemOffset
      }
    }
    
    if((elemBottom <= docViewBottom) && (elemTop >= docViewTop)) {
      // once an element is visible exchange the classes
      $(elem).removeClass('notViewed').addClass('viewed');
      
      var animElemsLeft = $('.animBlock.notViewed').length;
      if(animElemsLeft == 0){
        // with no animated elements left debind the scroll event
        $(window).off('scroll');
      }
    }
  }

  
  // < ----- Button for clicking to open MODAL LOGIN ---- >
  var modal = document.getElementById('id01'); 
  
  window.onclick = function(event) { 
      if (event.target == modal) { 
          modal.style.display = "none"; 
      } 
  } 
