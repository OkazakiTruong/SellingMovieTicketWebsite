var headerMenu = document.querySelector(".header-nav")
var isOpen = false;

function openMenu() {
    if (isOpen) {
        headerMenu.style.display = "none";
        isOpen = false
    } else {
        headerMenu.style.display = "flex";
        isOpen = true
    }
}