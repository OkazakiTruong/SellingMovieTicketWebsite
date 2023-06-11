<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="webDatVeXemPhim.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href ="style/GioHang.css"/>
    <link rel ="stylesheet" href ="icon/themify-icons-font/themify-icons-font/themify-icons/themify-icons.css" />
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
                        <li class="nav-item"><a href="SanPham.aspx">Sản phẩm</a></li>
                        <li class="nav-item"><a href ="GioiThieu.aspx">Giới thiệu</a></li>
                    </ul>
                </div>
                <div class="header-cart-icon" style="color:white"><a href ="GioHang.aspx"><i class="cart-icon ti-shopping-cart"><p id="numberOfMovieTicketInCart" runat="server"></p></i></a></div>
            </div>
        </div>
        <!--body start-->
            <div id="body">
                <div class ="body-top">
                <div class="body-title main-color">Giỏ hàng của bạn</div>
                <div class="body-title-two" runat="server">Bạn đang có <span id="soLuongVeFromServer" runat ="server"></span> vé trong giỏ</div>
                <div class="body-top-line"><hr /></div>
                </div>

                <div class="body-box">
                    <div class ="box-left">
                        <div class="box-left-top" runat="server" id="hienVeDaMuaUser">
                        </div>
                        <div class="box-left-bottom">
                            <div class="box-left-bottom-policy">
                                <h4 class="main-color">Chính sách:</h4>
                                <p>Vé sau khi mua sẽ được đổi trả sau 40 ngày</p>
                                <p>Vé sau khi mua sẽ được đổi trả sau 40 ngày</p>
                                <p>Vé sau khi mua sẽ được đổi trả sau 40 ngày</p>
                                <p>Vé sau khi mua sẽ được đổi trả sau 40 ngày</p>
                                <p>Vé sau khi mua sẽ được đổi trả sau 40 ngày</p>
                            </div>
                        </div>
                    </div>
                    <div class="box-right">
                        <div class="movies-ticket-info main-color">Thông tin đơn hàng</div> 
                        <%--<div class="total-fee">Tiền phải trả(VND): <span id="feeShouldPayFromServer" class="main-color" runat="server"></span></div>
                        <div class="total-fee">Thuế(VND): <span id="taxFromServer" class="main-color" runat="server"></span></div>--%>
                        <div class="total-fee">Tổng tiền(VND): <span id="feeFromServer" class="main-color" runat="server"></span></div>
                        <div class="box-right-btn">
                            <button id="btnPay" runat="server" onserverclick="btnPay_ServerClick">Thanh toán</button>
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
