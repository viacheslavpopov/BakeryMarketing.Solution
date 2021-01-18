$(document).ready(function(){
    // Activate Carousel
    $("#homeCarousel").carousel({
        interval: 5000
    })
    // Enable Carousel Indicators
    $("#item1").click(function(){
        $("#homeCarousel").carousel(0);
    });
    $("#item2").click(function(){
        $("#homeCarousel").carousel(1);
    });
    $("#item3").click(function(){
        $("#homeCarousel").carousel(2);
    });
    // Enable Carousel Controls
    $(".carousel-control-prev").click(function(){
        $("#homeCarousel").carousel("prev");
    });
    $(".carousel-control-next").click(function(){
        $("#homeCarousel").carousel("next");
    });
});