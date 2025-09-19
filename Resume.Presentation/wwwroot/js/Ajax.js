$(document).ready(function () {
    $(".nav__item a").on("click", function (e) {
        e.preventDefault();

        var url = $(this).data("url");

        $.get(url, function (data) {
            $("#mainContent").html(data);

            // فعال‌کردن لینک
            $(".nav__item a").removeClass("active");
            $(e.target).addClass("active");
        });
    });
});
