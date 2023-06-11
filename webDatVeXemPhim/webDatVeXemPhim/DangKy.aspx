<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="webDatVeXemPhim.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" href="style/DangKy.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

</head>
<body>
       <div id="container">
        <div id="header">
            <div class ="logo"><a href="TrangChu.aspx">HOU Movies</a></div>
            <div class ="header-title">Đăng ký</div>
        </div>
         <div id ="body">
        <div class="dangKy">   
                <h2 class="dangKy-title main-color">ĐĂNG KÝ</h2>
             <form runat="server" method="post" onsubmit ="return kiemTra();" action="DangKy.aspx">
                <div class="dangKy-content">
               <div class="dangKy-inputs"><lable for="txtUsername">Tài khoản</lable><input type="text" id="txtUsername" name="txtUsername"/></div>
               <div class="dangKy-inputs"><lable for="txtEmail">Email</lable><input type="text" id="txtEmail" name="txtEmail"/></div>
               <%--<div class="dangKy-inputs"><lable for="txtPhoneNumber">Phone Number: </lable><input type="number" id="txtPhoneNumber" name="txtPhoneNumber"/></div>--%>
               <div class="dangKy-inputs"><lable for="txtPassword">Mật khẩu</lable><input type="password" id="txtPassword" name="txtPassword"/></div>
               <div class="dangKy-inputs"><lable for="txtRePassword">Nhập lại mật khẩu</lable><input type="password" id="txtRePassword" name="txtRePassword"/></div>
               <div class="dangKy-hienMK"><input type="checkbox" id="cbShowPass" onchange="showPass()"/> <label for="cbShowPass">Hiện mật khẩu</label></div>           
                </div>
                <div class="dangKy-btn">
                <button type="submit" name="btnDangKy" id="btnDangKy">Đăng Ký</button>
                <button type="reset"name="btnHuy" id="btnHuy">Hủy</button>
                </div>
            </form>
            <div id="txtThongBaoFromClient" class="main-color"></div>
            <div id="txtThongBaoFromServer" class="main-color" runat="server"></div>
            <div class="txtDangNhap">Bạn đã có tài khoản? <a href ="DangNhap.aspx">Đăng nhập</a> ngay!</div>
        </div>
        </div>
         <div id="footer">
            <div class="footer-contain">
                <div class="footer-left"> 
            <div class="logo"><a href="TrangChu.aspx">HOU Movies</a></div>
            <p class="padding-top10">Một sản phẩn của sinh viên HOU</p>
            <p>Mang đến trải nghiệm đặt vé xem phim nhanh chóng, thuận tiện</p>
                </div>
            <div class="footer-right">
            <p class="main-color">Thông tin liên hệ</p>
            <p class ="padding-top10" >Địa chỉ: <span>Số 96 phố Định công</span> </p>
            <p >Số điện thoại: <span>0977354956</span> </p>
            <p>Email: <span>buiquangtruong@gmail.com</span> </p>
            </div>
            </div>          
        </div>
    </div>
    <script src ="js/DangKy.js"></script>
</body>
</html>
