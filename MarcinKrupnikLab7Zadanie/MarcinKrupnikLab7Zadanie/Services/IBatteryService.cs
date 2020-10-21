using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;

namespace MarcinKrupnikLab7Zadanie.Services
{
    public interface IBatteryService
    {
        List<Battery> Get();
        int Post(Battery battery);
        bool Put(Battery battery, int Id);
        bool Delete(int id);

    }
}
