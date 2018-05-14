$(document).ready(function () {
    //Trailer overlay modal
    $('#TrailerOverlay').on('shown.bs.modal', function () {
        $('#TrailerToggle').trigger('focus')
    });
    //Script handling genre filtering
    $(".GenreFilterButton").on("click", function () {
        var filter = $(this).data("filter");
        $.ajax({
            url: "/Browse/SortByGenre/?Genre=" + filter,
            type: "GET",
        }).done(function (partialViewResult) {
            $("#MovieGrid").html(partialViewResult);
        });
    });
    //Script handling search bar
    $("#searchbar").bind("enterKey",function () {
        var filter = $(this).val();
        $.ajax({
            url: "/Browse/Search/?Q=" + filter,
            type: "GET",
        }).done(function (partialViewResult) {
            $("#MovieGrid").html(partialViewResult);
        });
    });
    //Rating system, stars for now, can be replaced later. See the RatingHandler function
       
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
                items: 9
            }
        },
        margin: 10,
        slideBy: 4,
        center: true,
        loop: true,
        nav: true,
        navText: ['<i class="fa fa-angle-left" aria-hidden="true"></i>', '<i class="fa fa-angle-right" aria-hidden="true"></i>'],
    });
    //Added the stars function
    $(function () {
        $('span.stars').stars();
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
    }, 1500);
    GetCartAmount();
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

//Increments items in the cart
function IncreaseItemQuantity(index) {
    $.ajax({
        url: "/ShoppingCart/IncreaseItemQuantity/?movieID=" + index,
        type: "get"
    });
};
//decrements items in the cart
function DecreaseItemQuantity(index) {
    $.ajax({
        url: "/ShoppingCart/DecreaseItemQuantity/?movieID=" + index,
        type: "get"
    });
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

//Handles selecting the appropriate rating based on integer passed

//Gets the number of cart items and displays it in the menu
function GetCartAmount() {
    $.ajax({
        url: "/GetCartAmount",
        type: "get"
    }).done(function (amount) {
        $("#MenuCartItemCount").html(amount);
    });
}
$.fn.stars = function() {
    return $(this).each(function() {
        //get the value
        var val = parseFloat($(this).html());
        var size = Math.max(0, (Math.min(5, val))) * 16;
        var $span = $ ('<span />').width(size);
        $(this).html($span);
    });
}


