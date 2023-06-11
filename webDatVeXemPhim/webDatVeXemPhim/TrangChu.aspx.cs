using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

            string ip = getClientIP();
            //thongBaoSoNguoiThamGiaTrangWeb.InnerText = "Số người đang truy cập trang web là: " + Application["countPeople"];
            /*thongBaoDiaChiIPNguoiThamGia.InnerText = "Địa chỉ ip người tham gia web là: " + ip;*/
        }
        protected string getClientIP()
        {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (!string.IsNullOrEmpty(ipAddress))
                {
                    string[] addresses = ipAddress.Split(',');
                    if (addresses.Length != 0)
                    {
                        return addresses[0];
                    }
                }

                return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        private void hienSoLuongSanPhamTrongGio(user userLogin)
        {
            int countSLMovieTicket = 0;
            List<user> list = Application["userList"] as List<user>;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Username == userLogin.Username)
                {
                    if(list[i].MovieTicket == null) { } else
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

        protected void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
        public string hienNewMovies()
        {
            string html = "";
            List<Movie> list= Application["MovieList"] as List<Movie>;
            for(int i = 0; i < 8; i++)
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
            return html;
        }
        public string hienHotMovies()
        {
            string html = "";
            List<Movie> list = Application["MovieList"] as List<Movie>;
            for (int i = 8; i < 16; i++)
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
            return html;
        }
    }
}