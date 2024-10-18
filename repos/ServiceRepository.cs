using ReservationSystem.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.repos
{
    internal class ServiceRepository : GenericJsonRepository<Service>
    {
        public override string FilePath { get; set; } = @"services.json";

        public override int GetLastId()
        {
            return GetAll().Last().id;
        }
    }
}
