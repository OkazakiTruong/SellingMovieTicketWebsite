using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webDatVeXemPhim
{
    public partial class GioHang : System.Web.UI.Page
    {
        private float FeePay = 0;
        private void hienThongTinDangNhap()
        {
            user userLogin = Session["userLogin"] as user;
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
            hienThongTinDangNhap();
            hienThiThongTin();
            user userLogin = Session["userLogin"] as user;
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

        public void hienThiThongTin()
        {
            int totalTicket = 0;
            int totalfee = 0;
            List<user> listU = Application["userList"] as List<user>;
            List<Movie> listM = Application["movieList"] as List<Movie>;
            user userLogin = Session["userLogin"] as user;
            string html = "";
            foreach (user u in listU)
            {
                if (u.Username == userLogin.Username)
                {
                    for (int i = 0; i < u.MovieTicket.Count; i++)
                    {
                        totalTicket += u.MovieTicket[i].NumberOfTicket;
                        for(int j = 0; j < listM.Count; j++)
                        {
                            if(u.MovieTicket[i].Id == listM[j].Id) 
                            {
                                html += "<div class='movie-tickets'>" +
                                    "<div class='movie-ticket-left'>" +
                                    "<img src='"+listM[j].Img+"'/>" +
                                    "<div class='movie-ticket-content'>" +
                                    "<h3 class='movie-name main-color'>"+listM[j].MovieName+"</h3>" +
                                    "<p class='ticket-number'>Số lượng: <span>"+u.MovieTicket[i].NumberOfTicket+"</span></p>" +
                                    "<p class='movie-price'>Giá: <span>"+listM[j].MovieNewPrice+"</span></p>" +
                                    "</div>"+
                                    "</div>" +
                                    "<div class='movie-ticket-right'>" +
                                    "<a href ='XoaVePhim.aspx?id=" + listM[j].Id+ "' class='btn-delete-ticket'><i class='ti-close'></i></a>" +
                                    "</div>" +
                                    "</div>";

                                totalfee += listM[j].MovieNewPrice * u.MovieTicket[i].NumberOfTicket;
                                FeePay = totalfee;
                            }
                        }
                    }
                    break;
                }
            }
            if(totalfee > 0)
            {
                btnPay.Visible = true;
            }
            else
            {
                btnPay.Visible = false;
            }
            hienVeDaMuaUser.InnerHtml = html;
            //hien so luong ve
            soLuongVeFromServer.InnerText = totalTicket.ToString();
            //hien thi tong so tien
            feeFromServer.InnerText = totalfee.ToString();
             /*tính thuế*/
            /*float tax = calculateTax(totalfee);
            taxFromServer.InnerText = tax.ToString();
            float feeEnd = totalfee + tax;
            feeFromServer.InnerText = feeEnd.ToString();*/

        }
        private float calculateTax(int totalFee)
        {
            const float taxPercent = 0.1f;
            float tax = 0;
            tax = totalFee * taxPercent;
            return tax;
        }

        protected void btnPay_ServerClick(object sender, EventArgs e)
        {
            String dateTime = DateTime.Now.ToString("HH:mm ;dd/MM/yyyy");
            user uLogin = Session["userLogin"] as user;
            if (uLogin.Username != null)
            {
                    List<user> listU = Application["userList"] as List<user>;
                    for (int i = 0; i < listU.Count; i++)
                    {
                        if (uLogin.Username == listU[i].Username)
                        {
                            if (listU[i].MovieTicket != null)
                            {
                                listU[i].BuyedHistories.Add(new buyedHistory(listU[i].MovieTicket,FeePay, dateTime));
/*                                Response.Redirect("BuyHis.aspx");*/
                            }   
                        }
                    }                
            }
        }
    }
}