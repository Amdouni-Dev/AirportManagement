using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Interfaces
{
    //TP6 --> Q1
    public interface IRepository<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T Get(int id);
        T Get(string id);
        IList<T> GetAll();
        //TP6 Q10
      //  void Commit();
    }
}
