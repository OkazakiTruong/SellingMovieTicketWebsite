using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class GioiThieu : System.Web.UI.Page
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
    }
}