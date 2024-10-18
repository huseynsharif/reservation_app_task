using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.entitites
{
    internal class Reservation
    {
        public int id;
        public string Name;
        public string Surname;
        public int serviceId;

        public Reservation(string name, string surname, int serviceId)
        {
            Name = name;
            Surname = surname;
            this.serviceId = serviceId;
        }
    }
}
