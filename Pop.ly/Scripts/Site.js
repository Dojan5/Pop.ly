$(document).ready(function () {
    $(function () {
        $('[rel="popover"]').popover({
            container: 'body',
            html: true,
            content: function () {
                var clone = $($(this).data('popover-content')).clone(true).removeClass('invisible');
                return clone;
            }
        }).click(function (e) {
            e.preventDefault();
        });
    });
});

function AddToCart(id) {
    $.ajax({
        url: "/ShoppingCart/AddToCart/?movieID=" + id,
        type: "get"
    });
}

function RemoveFromCart(index) {
    $.ajax({
        url: "/ShoppingCart/RemoveFromCart/?index=" + index,
        type: "get"
    });
    var ID = "#CartRow" + index;
    $(ID).remove();
}
    
});

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.getElementById("main").style.marginLeft = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}

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