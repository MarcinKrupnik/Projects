using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinKrupnikLab7Zadanie.Repositories
{
    internal interface IApplicationDbGeneric<T> where T : class
    {
        void Save();
        void Create(T entity);
    }
}
