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
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Service service { get; set; }

        public Reservation(string name, string surname, Service service)
        {
            Name = name;
            Surname = surname;
            this.service = service;
        }
    }
}
