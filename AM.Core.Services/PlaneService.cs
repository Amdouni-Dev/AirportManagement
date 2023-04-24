using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService : IPlaneService
    {
        IRepository<Plane> repository;
        public PlaneService(IRepository<Plane> repository)
        {
            this.repository = repository;
        }
        public void Add(Plane plane)
        {
            repository.Add(plane);
            repository.Commit();
        }

        public void Delete(Plane plane)
        {
            repository.Delete(plane);
            repository.Commit();
        }

        public IList<Plane> GetAll()
        {
            return repository.GetAll();
        }
    }
}
