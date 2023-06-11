using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class DangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* DateTime timeLogin = (DateTime)Session["login"];
             DateTime timeLogout = DateTime.Now;
             TimeSpan time = timeLogout.Subtract(timeLogin);
             int sercon = time.Seconds;
             int minute = time.Minutes;
             int hour = time.Hours;

             ThongBaoFromServer.InnerText = "Bạn đã đăng nhập " + hour + " giờ, " + minute + " phút, " + sercon + " giây.";
             */
            Session.Abandon();
            Response.Redirect("~/TrangChu.aspx");
        }
    }
}