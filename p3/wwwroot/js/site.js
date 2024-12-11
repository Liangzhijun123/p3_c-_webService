// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//addition for the jquery
$(function () {
    //for the tabs on people
    $("#accTest").accordion({ collapsible: true, active: false, heightStyle: "content" });
    $("#tabTest").tabs();

    //show up
    $("#pepEverything").fadeIn(1000);

    $(".degree-header").click(function () {
        $(this).next(".course-list").slideToggle(300); // Slide the course list up/down
    });

    // Add hover effect for the degree card
    $(".degree-card").hover(
        function () {
            $(this).css("box-shadow", "0 4px 8px rgba(0,0,0,0.2)");
        },
        function () {
            $(this).css("box-shadow", "none");
        }
    );

    $(function () {
        $(".tabs").tabs();
    });

    $('#aboutTabs .nav-link').on('click', function (e) {
        $('#aboutTabs .nav-link').removeClass('active');
        $(this).addClass('active');
    });

    $("#accordion").accordion({
        collapsible: true, 
        heightStyle: "content",  
        active: false  
    });


})

