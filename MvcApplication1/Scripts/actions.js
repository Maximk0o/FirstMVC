$(function () {
    $('div.taskbox').click(function () {

        if (! $(this).hasClass("clicked")) {
            $('div.clicked').removeClass('clicked');
            $(this).addClass('clicked');
        } else {
            $(this).removeClass('clicked');
        }

    });
});