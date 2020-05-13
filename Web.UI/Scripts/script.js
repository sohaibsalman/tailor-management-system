$("#measurement--btns-add").click(function () {
    $("#popup-add_measurement").fadeIn();
});


$("#popup-close").click(function () {
    $("._popup").fadeOut();
});

function hide_popup() {
    alert("asd");
    $("._popup").css("display:", "none");
}