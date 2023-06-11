using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDatVeXemPhim
{
    public class user
    {
        private string username;
        private string userEmail;
        private string password;
        private List<MovieTicket> movieTicket;
        private List<buyedHistory> buyedHistories;
        private int failLogin;

        public user() { }
        public user(string username, string userEmail, string password)
        {
            this.username = username;
            this.userEmail = userEmail;
            this.password = password;
        }

        public user(string username, string userEmail, string password, List<MovieTicket> movieTicket)
        {
            this.username = username;
            this.userEmail = userEmail;
            this.password = password;
            this.movieTicket = movieTicket;
        }

        public user(string username, string userEmail, string password, List<MovieTicket> movieTicket, List<buyedHistory> buyedHistories)
        {
            this.username = username;
            this.userEmail = userEmail;
            this.password = password;
            this.movieTicket = movieTicket;
            this.buyedHistories = buyedHistories;
        }

        public user(string username, string userEmail, string password, List<MovieTicket> movieTicket, List<buyedHistory> buyedHistories, int failLogin)
        {
            this.username = username;
            this.userEmail = userEmail;
            this.password = password;
            this.movieTicket = movieTicket;
            this.buyedHistories = buyedHistories;
            this.failLogin = failLogin;
        }

        public string Username { get => username; set => username = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string Password { get => password; set => password = value; }
        public List<MovieTicket> MovieTicket { get => movieTicket; set => movieTicket = value; }
        public List<buyedHistory> BuyedHistories { get => buyedHistories; set => buyedHistories = value; }
        public int FailLogin { get => failLogin; set => failLogin = value; }
    }
}