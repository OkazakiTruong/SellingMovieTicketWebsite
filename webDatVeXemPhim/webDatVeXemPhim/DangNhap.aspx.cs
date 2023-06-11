using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack)
            {
                
                string userName = Request.Form["txtUsername"];
                string userPassword = Request.Form["txtPassword"];

                List<user> list = Application["userList"] as List<user>;

                bool flag = false;
                bool khoaMK = false;
               
                if (list != null && list.Count > 0)
                {
                    foreach (user u in list)
                    {
                        if (u.Username == userName)
                        {
                            if (u.FailLogin < 3)
                            {
                                if (u.Password == userPassword)
                                {
                                    user userLogin = new user(u.Username, u.UserEmail, u.Password);
                                    Session["userLogin"] = userLogin;
                                    DateTime timeLogin = DateTime.Now;
                                    Session["login"] = timeLogin;
                                    flag = true;
                                    u.FailLogin = 0;
                                    
                                }
                                else
                                {
                                /*khóa đăng nhập khi nhập sai quá nhiều*/
/*                                    u.FailLogin++;*/
                                    if (u.FailLogin >= 3)
                                    {
                                        txtThongBaoFromServer.InnerText = "Tài khoản của bạn do đã nhập sai quá nhiều lần nên đã bị khóa! Vui lòng liên hệ admin để đc hỗ trợ";
                                        khoaMK = true;
                                    }
                                }
                            }
                            else
                            {
                                txtThongBaoFromServer.InnerText = "Tài khoản của bạn do đã nhập sai quá nhiều lần nên đã bị khóa! Vui lòng liên hệ admin để đc hỗ trợ";
                                khoaMK = true;
                            }
                           
                        }
                    }
                }

                if (flag)
                {
                    Response.Redirect("TrangChu.aspx");


                }
                else
                {
                    if (!khoaMK)
                    {
                        txtThongBaoFromServer.InnerText = "Tài khoản hoặc mật khẩu không chính xác!";
                    }    
                }
               


            }
        }


    }
}