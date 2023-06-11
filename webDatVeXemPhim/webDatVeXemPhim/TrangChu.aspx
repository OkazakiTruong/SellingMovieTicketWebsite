<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="webDatVeXemPhim.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/TrangChu.css" />
    <link rel="stylesheet" href="icon/themify-icons-font/themify-icons-font/themify-icons/themify-icons.css"/>
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
                        <li class="nav-item"><a href="TrangChu.aspx" class ="main-color">Trang chủ</a></li>
                        <li class="nav-item"><a href="SanPham.aspx">Sản phẩm</a></li>
                        <li class="nav-item"><a href="GioiThieu.aspx">Giới thiệu</a></li>
                    </ul>
                </div>
                <div class="header-cart-icon" style="color:white"><a href ="GioHang.aspx"><i class="cart-icon ti-shopping-cart"><p id="numberOfMovieTicketInCart" runat="server"></p></i></a></div>
            </div>
        </div>
        <!--header end-->
        <div id="body">
        <!--body start-->
            <div class="banner-wrapper">
                <div class="banner">
                    <img src="img/slider/john_wick_3.jpeg"/>
                </div>
            </div>

            <div class="new-movies">   
                 <div class="session-header">
                    <h2>Vé phim mới</h2>
                </div>
                <div class ="flex-center">
                <div class="movies-container">
                    <%=hienNewMovies()%>
                </div>
                </div>
            </div>

            <div class="hot-movies" style="background-color:black">   
                 <div class="session-header">
                    <h2>Vé phim hot</h2>
                </div>
                <div class ="flex-center">
                <div class="movies-container">
                    <%=hienHotMovies()%>
                </div>
                </div>
            </div>

            <div class="About-Us">
                <div class="session-header">
                    <h2>About Us</h2>
                </div>
                <div class ="About-main-contain">
                    <img src ="img/slider/aboutUs.jpg"/>
                    <div class="About-content">
                        <h4 class="About-content-title">Về chúng tôi</h4>
                        <p>HOU Movies là sản phẩm của sinh viên đại học mở nhằm cung cấp dịch vụ đặt vé xem phim trực tuyến tới mọi người một cách nhanh chóng và thuận tiện nhất</p>
                    </div>
                </div>
                <%--<div id="thongBaoSoNguoiThamGiaTrangWeb" runat="server" style ="text-align:center ;padding-top:20px"></div>--%>
                <%--<div id="thongBaoDiaChiIPNguoiThamGia" runat="server" style="text-align:center ;padding-top:20px"></div>--%>
            </div>
        </div>
         <!--body end-->
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
    <script src ="js/openMenu.js"></script>
</body>
</html>
