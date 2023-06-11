using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDatVeXemPhim
{
    public class buyedHistory
    {
        private List<MovieTicket> ticketList = new List<MovieTicket>();
        private float fee;
        private string dateOfExcution;

        public buyedHistory(float fee, string dateOfExcution)
        {
            this.fee = fee;
            this.dateOfExcution = dateOfExcution;
        }

        public buyedHistory(List<MovieTicket> ticketList, float fee, string dateOfExcution)
        {
            this.ticketList = ticketList;
            this.fee = fee;
            this.dateOfExcution = dateOfExcution;
        }

        public float Fee { get => fee; set => fee = value; }
        public string DateOfExcution { get => dateOfExcution; set => dateOfExcution = value; }
        public List<MovieTicket> TicketList { get => ticketList; set => ticketList = value; }
    }
}