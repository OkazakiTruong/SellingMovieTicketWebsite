using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class movieChiTiet : System.Web.UI.Page
    {
        private void hienUserDangNhap()
        {
            user userLogin = Session["userLogin"] as user;
            hienSoLuongSanPhamTrongGio(userLogin);
            if (userLogin.Username != null)
            {
                headerLogin.InnerHtml =
                    "<p class= 'header-login-left'>Xin chào, " + userLogin.Username + "</p>" +
                    "<a class = 'header-straight-dash'>|</a>" +
                    "<a class = 'header-login-right' href='DangXuat.aspx' >Đăng xuất</a>";
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {    
            //hien user dang dang nhap
            hienUserDangNhap();
            

            //lấy id từ url
            int id = int.Parse(Request.QueryString["id"]);

            List<Movie> list = Application["movieList"] as List<Movie>;
            foreach (Movie movie in list)
            {
                if (movie.Id == id)
                {
                    movieImg.InnerHtml = "<img src='" + movie.Img + "'/>";
                    movieNameFromServer.InnerText = movie.MovieName;
                    movieTitleFromServer.InnerText = movie.MovieTitle;
                    movieDescriptionFromServer.InnerText = movie.MovieDescription;
                    movieNationalFromServer.InnerText = movie.MovieNational;
                    movieTimeFromServer.InnerText = movie.MovieTime.ToString();
                    movieYearFromServer.InnerText = movie.MovieYear.ToString();
                    movieTypeFromServer.InnerText = movie.MovieType;
                    break;
                }
            }
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
        protected void AddItemToCart_ServerClick(object sender, EventArgs e)
        {
            user userlogin = Session["userLogin"] as user;
            if (userlogin.Username == null)
            {
                popupContainer.Style.Add(HtmlTextWriterStyle.Display, "flex");
            }
            else
            {
                int id = int.Parse(Request.QueryString["id"]);
                int numberOfTicket =int.Parse(numberTicket.Value.ToString());
                List<user> users = Application["userList"] as List<user>;
                MovieTicket ticket = new MovieTicket(id, numberOfTicket);
                for(int i = 0; i < users.Count; i++)
                {
                    if(users[i].Username == userlogin.Username)
                    {
                        bool flagExist = false;
                        for (int j = 0; j < users[i].MovieTicket.Count; j++)
                        {                          
                            if(users[i].MovieTicket[j].Id == id)
                            {
                                users[i].MovieTicket[j].NumberOfTicket += numberOfTicket;
                                flagExist = true;
                            }      
                        }
                        if (!flagExist)
                        {
                            users[i].MovieTicket.Add(ticket);
                        }
                    }
                }
                Application["userList"] = users;
                hienSoLuongSanPhamTrongGio(userlogin);
            }
           


        }
    }
}