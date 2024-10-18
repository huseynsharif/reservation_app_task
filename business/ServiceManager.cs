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

            int serviceId = this.repository.GetIdByTitle(service.title);

            if (serviceId == -1)
            {
                service.id = this.repository.GetLastId() + 1;
                this.repository.Add(service);
            }
            else
            {
                this.repository.Update(service);
            }
        }

        public List<Service> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}
