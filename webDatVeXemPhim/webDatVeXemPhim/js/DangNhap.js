var userName = document.getElementById("txtUsername")
var userPassword = document.getElementById("txtPassword")
var thongBao = document.getElementById("txtThongBaoFromClient")
var cbShowPass = document.getElementById("cbShowPass")

function kiemTra() {
    var html = ""
    if (userName.value.trim() == "" || userPassword.value.trim() == "") {
        html += "<p>Không được bỏ trống</p>"
        thongBao.innerHTML = html;
        return false;
    }
}

function showPass() {
    if (cbShowPass.checked) {
        userPassword.setAttribute('type', 'text')
        userRePassword.setAttribute('type', 'text')
    } else {
        userPassword.setAttribute('type', 'password')
        userRePassword.setAttribute('type', 'password')
    }
}

