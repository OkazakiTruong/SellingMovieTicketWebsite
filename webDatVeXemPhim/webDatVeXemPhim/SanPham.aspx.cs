using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hienThiSanPham();

            user userLogin = Session["userLogin"] as user;
            if (userLogin.Username != null)
            {
                headerLogin.InnerHtml =
                    "<p class= 'header-login-left'>Xin chào, " + userLogin.Username + "</p>" +
                    "<a class = 'header-straight-dash'>|</a>" +
                    "<a class = 'header-login-right' href='DangXuat.aspx' >Đăng xuất</a>"
                    ;
            }
            hienSoLuongSanPhamTrongGio(userLogin);
        }
        private void hienSoLuongSanPhamTrongGio(user userLogin)
        {
            int countSLMovieTicket = 0;
            List<user> list = Application["userList"] as List<user>;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Username == userLogin.Username)
                {
                    if (list[i].MovieTicket == null) { }
                    else
                    {
                        for (int j = 0; j < list[i].MovieTicket.Count; j++)
                        {
                            countSLMovieTicket += list[i].MovieTicket[j].NumberOfTicket;
                        }
                        numberOfMovieTicketInCart.InnerText = countSLMovieTicket.ToString();
                    }

                }

            }
        }
        public void hienThiSanPham()
        {
            string html = "";
            List<Movie> list = Application["movieList"] as List<Movie>;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    html += "<div class='movie'>" +
                    "<a href='movieChiTiet.aspx?id=" + list[i].Id + "'><img class ='img1' src = '" + list[i].Img + "'/></a>" +
                    "<div class=movie-discription'>" +
                    "<h4 class='movie-name'><a href='movieChiTiet.aspx?id=" + list[i].Id + "'>" + list[i].MovieName + "</a></h4>" +
                    "<p class='movie-new-price'>" + list[i].MovieNewPrice + "<span style='font-size:10px'>đ<span></p>"
                    + "<p class='movie-old-price'>" + list[i].MovieOldPrice + "<span style='font-size:10px'>đ<span></p>"
                    + "</div>" +
                    "</div>";
                }
                else
                {
                    html += "<div class='movie'>" +
                    "<a href='movieChiTiet.aspx?id=" + list[i].Id + "'><img src = '" + list[i].Img + "'/></a>" +
                    "<div class=movie-discription'>" +
                    "<h4 class='movie-name'><a href='movieChiTiet.aspx?id=" + list[i].Id + "'>" + list[i].MovieName + "</a></h4>" +
                    "<p class='movie-new-price'>" + list[i].MovieNewPrice + "<span style='font-size:10px'>đ<span></p>"
                    + "<p class='movie-old-price'>" + list[i].MovieOldPrice + "<span style='font-size:10px'>đ<span></p>"
                    + "</div>" +
                    "</div>";
                }
                
            }
            moviesContainer.InnerHtml = html;
        }

        protected void btnFind_ServerClick(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string html = "";
                string name = findNameInput.Value.Trim();
                int soluong = 0;
                List<Movie> list = Application["movieList"] as List<Movie>;
                for (int i = 0; i < list.Count; i++)
                {

                    if (String.Compare(list[i].MovieName.ToLower(), name.ToLower()) == 0)
                    {
                        html += "<div class='movie'>" +
                        "<a href='movieChiTiet.aspx?id=" + list[i].Id + "'><img src = '" + list[i].Img + "'/></a>" +
                        "<div class=movie-discription'>" +
                        "<h4 class='movie-name'><a href='movieChiTiet.aspx?id=" + list[i].Id + "'>" + list[i].MovieName + "</a></h4>" +
                        "<p class='movie-new-price'>" + list[i].MovieNewPrice + "<span style='font-size:10px'>đ<span></p>"
                        + "<p class='movie-old-price'>" + list[i].MovieOldPrice + "<span style='font-size:10px'>đ<span></p>"
                        + "</div>" +
                        "</div>";
                        soluong++;
                    }
                }

                moviesContainer.InnerHtml = html;
                soLuongFromServer.InnerText = "Tìm thấy " + soluong + " kết quả";
            }

        }

        protected void btnRadioFind_ServerClick(object sender, EventArgs e)
        {
            /*tìm theo giá kiểu 1*/
            /*            if (IsPostBack)
                        {
                            string html = "";
                            int soluong = 0;
                            List<Movie> list = Application["movieList"] as List<Movie>;
                            if (priceRadio1.Checked)
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (String.Compare(list[i].MovieType,"kinh dị"))
                                    {
                                        html += "<div class='movie'>" +
                                        "<a href='movieChiTiet.aspx?id=" + list[i].Id + "'><img src = '" + list[i].Img + "'/></a>" +
                                        "<div class=movie-discription'>" +
                                        "<h4 class='movie-name'><a href='movieChiTiet.aspx?id=" + list[i].Id + "'>" + list[i].MovieName + "</a></h4>" +
                                        "<p class='movie-new-price'>" + list[i].MovieNewPrice + "<span style='font-size:10px'>đ<span></p>"
                                        + "<p class='movie-old-price'>" + list[i].MovieOldPrice + "<span style='font-size:10px'>đ<span></p>"
                                        + "</div>" +
                                        "</div>";
                                        soluong++;
                                    }
                                }
                                moviesContainer.InnerHtml = html;
                                soLuongFromServer.InnerText = "Tìm thấy " + soluong + " kết quả";
                            }

                        }*/
            /*tìm theo giá kiểu 2*/
            //if (IsPostBack)
            //{
            //    string html = "";
            //    int soluong = 0;
            //    List<Movie> list = Application["movieList"] as List<Movie>;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i].MovieNewPrice >= int.Parse(minPrice.Value) && list[i].MovieNewPrice <= int.Parse(maxPrice.Value))
            //        {
            //            html += "<div class='movie'>" +
            //            "<a href='movieChiTiet.aspx?id=" + list[i].Id + "'><img src = '" + list[i].Img + "'/></a>" +
            //            "<div class=movie-discription'>" +
            //            "<h4 class='movie-name'><a href='movieChiTiet.aspx?id=" + list[i].Id + "'>" + list[i].MovieName + "</a></h4>" +
            //            "<p class='movie-new-price'>" + list[i].MovieNewPrice + "<span style='font-size:10px'>đ<span></p>"
            //            + "<p class='movie-old-price'>" + list[i].MovieOldPrice + "<span style='font-size:10px'>đ<span></p>"
            //            + "</div>" +
            //            "</div>";
            //            soluong++;
            //        }
            //    }
            //    moviesContainer.InnerHtml = html;
            //    soLuongFromServer.InnerText = "Tìm thấy " + soluong + " kết quả";
            //}
            /*sap xep theo gia tu thap den cao*/
            //if (IsPostBack)
            //{
            //    List<Movie> list = Application["movieList"] as List<Movie>;
            //    for (int i = 0; i < list.Count-1; i++)
            //    {
            //        for(int j=i+1; j < list.Count; j++)
            //        {
            //            if(list[i].MovieNewPrice > list[j].MovieNewPrice)
            //            {
            //                Movie temp = list[i];
            //                list[i] = list[j];
            //                list[j] = temp;
            //            }
            //        }
            //    }
            //    hienThiSanPham();
            //}
        }
    }
}