using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;

namespace MarcinKrupnikLab7Zadanie.Services
{
    public interface IDisplayService
    {
        List<Display> Get();
        int Post(Display display);
        bool Put(Display display, int Id);
        bool Delete(int id);

    }
}
