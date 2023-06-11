<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioiThieu.aspx.cs" Inherits="webDatVeXemPhim.GioiThieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/GioiThieu.css" />
    <link rel="stylesheet" href="icon/themify-icons-font/themify-icons-font/themify-icons/themify-icons.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>
<div id="container">
        <div id="header">
            <!--header start-->
            <div class="header-login" id ="headerLogin" runat="server">
                <a id="btn-header-login" class="header-login-left" href="DangNhap.aspx">Đăng nhập</a>
                <a class="header-straight-dash">|</a>
                <a id="btn-header-register" class="header-login-right" href="DangKy.aspx">Đăng ký</a>
            </div>
            <div class="header-nav-bar">
                <div class="menu-icon" onclick="openMenu()"><i class="ti-menu"></i></div>
                <div class="logo"><a href="TrangChu.aspx">HOU Movies</a></div>
                <div class="header-nav">
                    <ul class="header-nav-items">
                        <li class="nav-item"><a href="TrangChu.aspx">Trang chủ</a></li>
                        <li class="nav-item"><a href="SanPham.aspx">Sản phẩm</a></li>
                        <li class="nav-item"><a href="GioiThieu.aspx" class ="main-color">Giới thiệu</a></li>
                    </ul>
                </div>
                <div class="header-cart-icon" style="color:white"><a href ="GioHang.aspx"><i class="cart-icon ti-shopping-cart"><p id="numberOfMovieTicketInCart" runat="server"></p></i></a></div>
            </div>
        </div>
        <!--header end-->
            <div id="body">
                <div class ="container">
                    <div class="body-header"><h1 class="main-color">Về chúng tôi</h1></div>
                    <div class="body-content">
                       <p>HOU Movies là sản phẩm của 2 sinh viên đại học mở gồm: Bùi Quang Trưởng và Kiều Mạnh Cường.</p>
                       <p>Website này được xây dựng nhằm đem đến dịch vụ mua vé xem phim dễ dàng và thuận tiện nhất.</p>
                       <p>Từ đó mang lại trải nhiệm tốt nhất khi đi xem phim tới khách hàng.</p>
                    </div>
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
    <script src="js/openMenu.js"></script>
</body>
</html>
