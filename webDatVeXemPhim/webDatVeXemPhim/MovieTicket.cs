using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDatVeXemPhim
{
    public class MovieTicket
    {
        private int id;
        private int numberOfTicket;

        public MovieTicket(int  id, int numberOfTicket)
        {
            this.id = id;
            this.numberOfTicket = numberOfTicket;
        }

        public int Id { get => id; set => id = value; }
        public int NumberOfTicket { get => numberOfTicket; set => numberOfTicket = value; }
    }
}