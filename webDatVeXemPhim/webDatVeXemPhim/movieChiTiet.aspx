<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movieChiTiet.aspx.cs" Inherits="webDatVeXemPhim.movieChiTiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="style/MovieChiTiet.css" />
<link rel="stylesheet" href="icon/themify-icons-font/themify-icons-font/themify-icons/themify-icons.css"/>
<meta name="viewport" content="width=device-width, initial-scale=1">

</head>
<body>
    <form runat="server" id="from1">
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
                        <li class="nav-item"><a href="GioiThieu.aspx">Giới thiệu</a></li>
                    </ul>
                </div>
                <div class="header-cart-icon" style="color:white"><a href ="GioHang.aspx"><i class="cart-icon ti-shopping-cart"><p id="numberOfMovieTicketInCart" runat="server"></p></i></a></div>
            </div>
        </div>
     <div id ="body">
         <div class="body-title">
             <h2 class="main-color">Thông tin chi tiết</h2>
         </div>
         <div class="movie-detail">
             <div class ="movie-detail-left" id="movieImg" runat="server">
                 
             </div>
             <div class="movie-detail-right" style="flex-grow: 10">
                 <div class="movie-name main-color"><h2 id ="movieNameFromServer" runat ="server"></h2></div>
                 <div class="movie-title"><p id="movieTitleFromServer" runat="server"></p></div>
                 <div class="movie-ticket-control">
                     <div class="btn-added">
                    <input class="minus is-form" type="button" value="-" onclick="minus()"/>
                    <input aria-label="quantity" class="input-qty"  min="1" name="" type="number" value="1" runat="server" id="numberTicket"/>
                    <input class="plus is-form" type="button" value="+" onclick ="plus()"/>
                    </div>
                     <div class="btn-buy">
                         <button type="button" class="btn-buy-item" id="AddItemToCart" runat="server" onserverclick="AddItemToCart_ServerClick">Thêm vào giỏ hàng</button>
                         <button type="button" class="btn-buy-item">Xem Trailer</button>
                     </div>
                 </div>
                 <div class="movie-description">
                     <h3>Nội dung</h3>
                     <p id="movieDescriptionFromServer" runat ="server"></p>
                 </div>
                 <div class="movie-national">
                     <p>Quốc gia: <span id="movieNationalFromServer" runat ="server"></span></p>
                 </div>
                 <div class="movie-time">
                     <p>Thời lượng: <span id="movieTimeFromServer" runat ="server"></span>phút</p>
                 </div>
                 <div class="movie-year">
                     <p>Năm ra mắt: <span id="movieYearFromServer" runat ="server"></span></p>
                 </div>
                 <div class="movie-type">
                     <p>Thể loại: <span id="movieTypeFromServer" runat ="server"></span></p> 
                 </div>
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

        <div class="popup-container" onclick ="closePopup()" id="popupContainer" runat="server">
        <div class="popup">
            <div class="popup-header">
            <i class="icon-cancel ti-close"  onclick ="closePopup()"></i>
            </div>
            <div class="popup-body">
                 <h3 class="main-color">Bạn cần Đăng Nhập để có thể thực hiện chức năng này!</h3>
                 <p>Đã có tài khoản? <a href="DangNhap.aspx" class="main-color">Đăng nhập</a> ngay!</p>
                 <p>Lần đầu truy cập Hou Movies? click <a href="DangKy.aspx" class="main-color">vào đây</a> và đăng ký tài khoản</p>
                 <a onclick ="closePopup()" >Hủy</a>
            </div>           
        </div>
    </div>
    </div>
    </form>
    
     <script src ="js/MovieChiTiet.js"></script>
     <script src="js/openMenu.js"></script>
</body>
</html>
