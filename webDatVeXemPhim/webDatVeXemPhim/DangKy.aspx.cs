using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string userName = Request.Form["txtUsername"];
                string userEmail = Request.Form["txtEmail"];
                string userPassword = Request.Form["txtPassword"];
                List<MovieTicket> movieTickets = new List<MovieTicket>();
                List<buyedHistory> buyedHistory = new List<buyedHistory>();

                List<user> list = Application["userList"] as List<user>;

                bool flag = true;
                foreach (user u in list)
                {
                    if (u.UserEmail == userEmail || u.Username == userName)
                    {
                        flag = false;
                        txtThongBaoFromServer.InnerHtml = "Tài khoản đã tồn tại!";
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(new user(userName, userEmail, userPassword, movieTickets,buyedHistory,0));
                    txtThongBaoFromServer.InnerText = "Tạo tài khoản thành công!";
                }

            }

        }
    }
}