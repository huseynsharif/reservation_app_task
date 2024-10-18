using ReservationSystem.entitites;
using ReservationSystem.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.business
{
    internal class ReservationManager
    {
        private readonly ReservationRepository repository;

        public ReservationManager(ReservationRepository repository)
        {
            this.repository = repository;
        }

        public void Save(Reservation reservation)
        {

            reservation.id = this.repository.GetLastId() + 1;
            this.repository.Add(reservation);

        }

        public List<Reservation> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}
