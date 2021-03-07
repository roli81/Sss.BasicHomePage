$(document).ready(function() {


    if (!localStorage.getItem("popupShowed")) {
        $.magnificPopup.open({
            items: {
                src: '#cookie-banner'
            },
            type: 'inline'
        });
        localStorage.setItem("popupShowed", true);
    }



  
    $(window).scroll(function (e) {

        console.log($(this).scrollTop());



        if ($(this).scrollTop() > 0) {
    
            $('#headerCarousel').slideUp(200, function () {

           
            });

            $('footer').fadeOut(200,
                function () {

                });

        } else {
            $('#headerCarousel').slideDown(200, function () {
              
            });

            $('footer').fadeIn(200,
                function () {

                });

        }



    });


});
                        