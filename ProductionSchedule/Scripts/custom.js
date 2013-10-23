var backgroundColours = ['#bcbdaf', '#bbdb9c', '#85aec4', '#ffe294'];

$('div.allocation').each(function (index) {
    $(this).css({ backgroundColor: backgroundColours[index] });
});

$('span.allocation').each(function (index) {
    var hours = $(this).html();
    /*$(this).html(hours.replace(/(\D*)(\d*\.)(\d*)/, '<span style="font-size:16px;">$1</span><span style="font-size:22px;">$2</span><span style="font-size:14px;">$3</span>'));*/
});