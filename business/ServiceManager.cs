using ReservationSystem.entitites;
using ReservationSystem.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.business
{
    internal class ServiceManager
    {
        private ServiceRepository repository;

        public ServiceManager(ServiceRepository repository)
        {
            this.repository = repository;
        }

        public void SaveService(Service service)
        {
            service.id = this.repository.GetLastId() + 1;
            this.repository.Add(service);
        }

    }
}
