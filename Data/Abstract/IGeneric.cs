using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IGeneric<T>where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();   
        T GetById(int id);  
    }
}
