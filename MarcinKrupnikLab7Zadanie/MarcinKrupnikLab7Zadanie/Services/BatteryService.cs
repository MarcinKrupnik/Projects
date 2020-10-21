using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;

namespace MarcinKrupnikLab7Zadanie.Services
{
    public class BatteryService : IBatteryService
    {
        private static List<Battery> batteries = new List<Battery>();

        public bool Delete(int id)
        {
            var battery = batteries.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (battery == null)
            {
                return false;
            }

            batteries.Remove(battery);
            return true;
        }

        public List<Battery> Get()
        {
            return batteries;
        }

        public int Post(Battery battery)
        {
            int id;
            if (batteries.Count() == 0)
            {
                id = 0;
                battery.Id = id;
            }
            else
            {
                id = batteries.Max(x => x.Id);
                battery.Id = ++id;
            }
            batteries.Add(battery);

            return id;
        }

        /// <summary>
        /// Aktualizacja wyświetlacza o podanym Id.
        /// </summary>
        /// <param name="battery"></param>
        /// <param name="Id">Id pizzy do aktualizacji.</param>
        /// <returns></returns>
        public bool Put(Battery battery, int Id)
        {
            var batteryToUpdate = batteries.Where(x => x.Id.Equals(Id)).SingleOrDefault();
            if (batteryToUpdate == null)
            {
                return false;
            }

            batteryToUpdate.Name = battery.Name;
            batteryToUpdate.Cost = battery.Cost;
            batteryToUpdate.Description = battery.Description;
            return true;
        }

        
    }
}
