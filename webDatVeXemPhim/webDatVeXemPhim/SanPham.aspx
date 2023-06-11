<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="webDatVeXemPhim.SanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/SanPham.css" />
    <link rel="stylesheet" href="icon/themify-icons-font/themify-icons-font/themify-icons/themify-icons.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

</head>
<body>
    <form id="form1" runat="server">
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
                        <li class="nav-item"><a href="SanPham.aspx" class ="main-color" >Sản phẩm</a></li>
                        <li class="nav-item"><a href="GioiThieu.aspx">Giới thiệu</a></li>
                    </ul>
                </div>
                <div class="header-cart-icon" style="color:white"><a href ="GioHang.aspx"><i class="cart-icon ti-shopping-cart"><p id="numberOfMovieTicketInCart" runat="server"></p></i></a></div>
            </div>
        </div> 
        <!--header end-->
       <!--body start-->
       <div id="body">
        <div class="body-title main-color">
        <h1>Vé xem phim</h1>
        <div id="soLuongFromServer" runat="server"></div>
        </div>
        <div class="body-content">
             <div class="body-box">
            <div class ="box-left">
                <div class="find-movie-with-name">
                    <label for="findNameInput">Tìm kiếm:</label>
                    <input type="text" id="findNameInput" runat="server"/>
                    <button type="button" runat="server" id="btnFind" onserverclick="btnFind_ServerClick">Tìm kiếm</button>
                </div>
            <%--  <div class="find-movie-with-price">
                    <label>Tìm kiếm theo giá</label>
                    <div><input type="radio" name="priceMovies" id="priceRadio1" runat="server"/>10.000đ-100.000đ</div>
                    <div><input type="radio" name="priceMovies"/>10.000đ-100.000đ</div>
                    <div><input type="radio" name="priceMovies"/>10.000đ-100.000đ</div>
                    <label>min price:</label><input type="number" id="minPrice" runat="server" min="0"> - 
                    <label>max price:</label><input type="number" id="maxPrice" runat="server" min="0"/>
                    <button type="button" runat="server" id="btnRadioFind" onserverclick="btnRadioFind_ServerClick">Tìm kiếm</button>
                </div>--%>
            </div>
            <div class="movies-container" id="moviesContainer" runat="server">
            </div>
        </div>
        </div>  
       </div>
       <!--footer start-->
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
    </form>
    <script src="js/openMenu.js"></script>
</body>
</html>
