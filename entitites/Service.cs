using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.entitites
{
    internal class Service
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }

        public Service(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
