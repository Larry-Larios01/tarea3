using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Add(T t);
        bool Delete(T t);
        List<T> Read();
        int Update(T t);
    }
}
