var numberTicket = document.getElementById("numberTicket");
var popup = document.getElementsByClassName("popup-container");
function closePopup() {
    popup[0].style.display = "none";
}
function openPopup() {
    popup[0].style.display = "flex";
}
function minus() {

    if (numberTicket.value <= 1) {
    } else {
        numberTicket.value--;
    }
}
function plus() {
    numberTicket.value++;
}