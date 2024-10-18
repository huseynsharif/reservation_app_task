using ReservationSystem.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.repos
{
    internal class ReservationRepository : GenericJsonRepository<Reservation>
    {
        public override string FilePath { get; set; } = @"reservations.json";

        public override int GetLastId()
        {
            List<Reservation> list = GetAll();
            if (list.Count > 0)
            {
                return list.Last().id;
            }
            else
            {
                return 0;
            }
        }
    }
}
