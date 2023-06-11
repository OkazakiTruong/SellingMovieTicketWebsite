using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class BuyHis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string hienHistory()
        {
            List<Movie> listMovie = Application["movieList"] as List<Movie>;
            string html = "";
            user uLogin = Session["userLogin"] as user;
            List<user> listU = Application["userList"] as List<user>;
            if (uLogin.Username != null)
            {
                for (int i = 0; i < listU.Count; i++)
                {
                    if (listU[i].Username == uLogin.Username)
                    {
                        foreach (buyedHistory bH in listU[i].BuyedHistories)
                        {
                            foreach(MovieTicket mt in bH.TicketList)
                            {
                                foreach(Movie m in listMovie)
                                {
                                    if(mt.Id == m.Id)
                                    {
                                        html += "<div>Tên sản phẩm: <span>"+m.MovieName+"</span>, Số lượng: <span>"+mt.NumberOfTicket+"</span></div>";
                                    }
                                }
                            }
                            html += "<div>Đơn hàng giá: <span>" + bH.Fee + "</span> ,Thời gian thanh toán: <span>" + bH.DateOfExcution + "</span></div>";
                        }
                    }
                }
            }
            return html;
        }
    }
}