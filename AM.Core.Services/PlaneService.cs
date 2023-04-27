using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService:Service<Plane> , IPlaneService
    {
        //IRepository<Plane> repository;
        //public PlaneService(IRepository<Plane> repository)
        //{
        //    this.repository = repository;
        //}
     // readonly  IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork):base(unitOfWork) 
        {
            //this.unitOfWork = unitOfWork;
            //repository = unitOfWork.GetRepository<Plane>();
        }
        //public void Add(Plane plane)
        //{
        //    repository.Add(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public void Delete(Plane plane)
        //{
        //    repository.Delete(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public IList<Plane> GetAll()
        //{
        //    return repository.GetAll();
        //}
    }
}
