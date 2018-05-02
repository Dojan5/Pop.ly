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