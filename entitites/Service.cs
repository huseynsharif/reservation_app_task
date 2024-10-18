using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.entitites
{
    internal class Service
    {
        public int id;
        public string title;
        public double price;

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
