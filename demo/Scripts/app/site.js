$(document).ready(function () {
    $("#categories").click(function () {
        $('#categories li.active').removeClass('active');
        $(this).addClass('active');       
    });
});