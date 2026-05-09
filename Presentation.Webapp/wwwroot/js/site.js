// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(function() {
    var $headers = $('.accordion-header');
    var $contents = $('.accordion-content');
    
    if ($headers.length) {
        $headers.first().addClass('active');
        $contents.first().show();
    }
    
    $headers.on('click', function() {
        var $this = $(this);
        var isActive = $this.hasClass('active');
        
        $headers.removeClass('active');
        $contents.stop(true, true).slideUp(300);
        
        if (!isActive) {
            $this.addClass('active');
            $this.next('.accordion-content').stop(true, true).slideDown(300);
        }
    });
});
