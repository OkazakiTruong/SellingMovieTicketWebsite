var userName = document.getElementById("txtUsername");
var userEmail = document.getElementById("txtEmail");
var userPassword = document.getElementById("txtPassword");
var userRePassword = document.getElementById("txtRePassword");
var userPhoneNumber = document.getElementById("txtPhoneNumber")
var thongBao = document.getElementById("txtThongBaoFromClient")
var cbShowPass = document.getElementById("cbShowPass")



function kiemTra() {
    var html = "";
    if (userName.value.trim() === "" || userEmail.value.trim() === "" || userPassword.value.trim() === "" || userRePassword.value.trim() === "") {
        html = "<p>Không được bỏ trống! Vui lòng nhập đầy đủ thông tin</p>"
        thongBao.innerHTML = html;
        return false
    } else {
        /*kiểm tra email*/
        /*^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$*/
        //if (!/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/.test(userEmail.value)) {
        //    thongBao.innerText = "định dạng email không đúng!";
        //    return false
        //}
        /*kiểm tra khớp mật khẩu*/
        if (userPassword.value.trim() !== userRePassword.value.trim()) {
            html = "<p>Mật khẩu không trùng khớp! Vui lòng nhập lại</p>"
            thongBao.innerHTML = html;
            return false
        }
        
        /*kiểm tra password*/
        /*"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"*/
        //if (!/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/.test(userPassword.value)) {
        //    thongBao.innerText = "mật khẩu phải ít nhất có 8 ký tự! Trong đó phải có ít nhất 1 số, 1 chữ thường,1 chữ in hoa và không có ký tự đặc biệt";
        //    return false
        //} else {
        //    if (/^(?=.*[@$!%*?&])$/.test(userPassword.value)) {
        //        thongBao.innerText = "mật khẩu phải ít nhất có 8 ký tự! Trong đó phải có ít nhất 1 số, 1 chữ thường,1 chữ in hoa và không có ký tự đặc biệt";
        //        return false
        //    }
        //}
        
       
        /*kiểm tra định dạng số điện thoại*/
        //if (!/^(?=0)+[0-9]{8}$/.test(userPhoneNumber.value)) {    
        //           thongBao.innerHTML = "định dạng số điện thoại sai!"
        //           return false          
        //}

       
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