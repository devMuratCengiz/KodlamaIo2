using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo2.Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T manager);
        void Delete(T manager);
    }
}
