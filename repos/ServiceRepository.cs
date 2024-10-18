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
            List<Service> list = GetAll();
            if (list.Count>0)
            {
                return list.Last().id;
            }
            else
            {
                return 0;
            }
        }

        public int GetIdByTitle(string title)
        {

            List<Service> list = GetAll();
            Service service = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].title.Equals(title))
                {
                    service = list[i];
                }
            }

            if (service==null)
            {
                return -1;
            }
            else
            {
                return service.id;
            }
        }

        public void Update(Service service)
        {
            List<Service> list = GetAll();

            list[service.id-1] = service;

            WriteToJson(list);

        }
    }
}
