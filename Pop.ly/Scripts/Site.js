﻿$(document).ready(function () {
    $('#TrailerOverlay').on('shown.bs.modal', function () {
        $('#TrailerToggle').trigger('focus')
    });

    //$('.SingleMovie').hover(function () {
    //    $(this).children('.SingleMovieDetails').fadeToggle(180);
    //    //$(this).animate({ 'zoom'  }, 100).children('.SingleMovieDetails').fadeToggle(100);
    //});
    //Owl Carousel
    $(".owl-carousel").owlCarousel({
        responsiveClass: true,
        responsive: {
            0: {
                items: 4
            },
            600: {
                items: 6
            },
            1080: {
                items: 7
            },
            1600: {
                items: 10
            }
        },
        margin: 10,
        slideBy: 4,
        center: true,
        loop: true,
        nav: true,
        navText: ['<i class="fa fa-angle-left" aria-hidden="true"></i>', '<i class="fa fa-angle-right" aria-hidden="true"></i>'],
    });
    
});

//Ajax function handling adding new items to the cart
function AddToCart(id) {
    $.ajax({
        url: "/ShoppingCart/AddToCart/?movieID=" + id,
        type: "get"
    });
    $('#AddToCart').removeClass("btn-secondary").addClass("btn-success").html("<i class=\"fas fa-check\"></i> Added");
    setTimeout(function() {
        $('#AddToCart').removeClass("btn-success").addClass("btn-secondary").html("<i class=\"fas fa-shopping-cart\"></i> Add to cart");
    },1500);
}

//Ajax function handling removing items from the cart
function RemoveFromCart(index) {
    $.ajax({
        url: "/ShoppingCart/RemoveFromCart/?index=" + index,
        type: "get"
    });
    var ID = "#CartRow" + index;
    $(ID).remove();
  
};

//Toggles the filter pane on the movie browse page
function toggleNav() {
    if (document.getElementById("toggleSideNav").value == "O")
    {
        document.getElementById("mySidenav").style.width = "250px";
        document.getElementById("main").style.marginLeft = "250px";
        document.getElementById("toggleSideNav").value = "C";
    }
    else {
        document.getElementById("mySidenav").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";
        document.getElementById("toggleSideNav").value = "O";
    }
}
