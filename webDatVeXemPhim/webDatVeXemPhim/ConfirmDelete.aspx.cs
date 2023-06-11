using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class ConfirmDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string html = "<a href ='XoaVePhim.aspx?id=" + id + "'>OK</a>";
            btnOK.InnerHtml = html;
        }
    }
}