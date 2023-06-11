using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class XoaVePhim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lay thong tin can thiet de xoa ticket thong qua url
            user userLogin = Session["userLogin"] as user;
            List<user> listU = Application["userList"] as List<user>;
            int idMovie = int.Parse(Request.QueryString["id"]);
            if (userLogin.Username != null)
            {
                foreach(user u in listU)
                {
                    if (u.Username == userLogin.Username)
                    {
                        for(int i = 0; i < u.MovieTicket.Count; i++)
                        {
                            if(u.MovieTicket[i].Id == idMovie)
                            {
                                u.MovieTicket.RemoveAt(i);
                            }
                        }
                        break;
                    }     
                }
            }
            Response.Redirect("GioHang.aspx");
                
        }
    }
}