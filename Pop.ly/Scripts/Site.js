$(document).ready(function () {
    $('#TrailerOverlay').on('shown.bs.modal', function () {
        $('#TrailerToggle').trigger('focus')
    });
    $('.MovieRibbonLeftControl').mouseover(function () {
        $(this).siblings('.MovieRibbonContent').animate({ right: "300px" })
    });
    $('.MovieRibbonRightControl').mouseover(function () {
        $(this).siblings('.MovieRibbonContent').animate({left: "300px"})
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