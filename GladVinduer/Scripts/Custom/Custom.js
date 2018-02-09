

var biggerLarge = $(window).width() > 1024;
var smallerLarge = $(window).width() < 1024;
var small = $(window).width() < 768;

$(window).load(function () {
    $(".load-overlay").addClass("fade-out");
    $(".main-container").addClass("fade-in");
});





$(document).ready(function () {


    $('.carousel').carousel({
        interval: 4000
    });

    slideIn();

    // Word toggle
    var counter = 1,
        int = setInterval(function () {
            $("[data-word-toggle] div").attr("class", "show-" + counter);
            if (counter === 3) {
                counter = 1;
            } else {
                counter++;
            }
        }, 3000);

    if (biggerLarge) {
        // add class to header
        var s = $("[data-headline-effect]");
        var pos = s.position();
        $(window).scroll(function () {
            var windowpos = $(window).scrollTop();
            if (windowpos >= pos.top & windowpos <= 300) {
                s.removeClass("scroll");
            } else {
                s.addClass("scroll");
            }
        });
    }

    $(".center-content").addClass("data-show-visible");

    // menu icon
    $("[data-menu-toggle]").click(function () {
        $(this).toggleClass("active");

        $(this).parent().next().toggleClass("active");
    });

});


// show on scroll/window
$.fn.visible = function (partial) {

    var $t = $(this),
        $w = $(window),
        viewTop = $w.scrollTop(),
        viewBottom = viewTop + $w.height(),
        _top = $t.offset().top,
        _bottom = _top + $t.height(),
        compareTop = partial === true ? _bottom : _top,
        compareBottom = partial === true ? _top : _bottom;

    return compareBottom + 150 <= viewBottom && compareTop >= viewTop;

};
$(window).scroll(function (event) {

    slideIn();

});

function slideIn() {
    $(".data-show-visible").each(function (i, el) {
        var el = $(el);
        if (el.visible(true)) {
            el.addClass("done");
        }
    });
}

$(function () {
    $('[data-match-height]').matchHeight();
});
