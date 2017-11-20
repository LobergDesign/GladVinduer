$(window).load(function () {
    $("[data-custom-loader]").addClass("fade-out");
});
$(document).ready(function () {
 
    $('.carousel').carousel({
        interval: 4000
    });

    // Word toggle
    slideIn();
    var counter = 1,
        int = setInterval(function () {
            $("[data-word-toggle] div").attr("class", "show-" + counter);
            if (counter === 3) {
                counter = 1;
            } else {
                counter++;
            }
        }, 3000);


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
    $(".center-content").addClass("data-show-visible");
   
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
    //if ($(window).scrollTop() + $(window).height() > ($(document).height() - 50)) {
  
    //    $("[data-show-footer]").addClass("footer-active");
    //} else {
    //    $("[data-show-footer]").removeClass("footer-active");
    //}
});

function slideIn() {
    $(".data-show-visible").each(function (i, el) {
        var el = $(el);
        if (el.visible(true)) {
            el.addClass("done");
        }
    });
}


