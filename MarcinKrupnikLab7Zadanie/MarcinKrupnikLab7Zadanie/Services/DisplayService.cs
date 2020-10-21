using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;

namespace MarcinKrupnikLab7Zadanie.Services
{
    public class DisplayService : IDisplayService
    {
        private static List<Display> displays = new List<Display>();

        public bool Delete(int id)
        {
            var display = displays.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (display == null)
            {
                return false;
            }

            displays.Remove(display);
            return true;
        }

        public List<Display> Get()
        {
            return displays;
        }

        public int Post(Display display)
        {
            int id;
            if (displays.Count() == 0)
            {
                id = 0;
                display.Id = id;
            }
            else
            {
                id = displays.Max(x => x.Id);
                display.Id = ++id;
            }
            displays.Add(display);

            return id;
        }

        /// <summary>
        /// Aktualizacja wyświetlacza o podanym Id.
        /// </summary>
        /// <param name="battery"></param>
        /// <param name="Id">Id pizzy do aktualizacji.</param>
        /// <returns></returns>
        public bool Put(Display display, int Id)
        {
            var displayToUpdate = displays.Where(x => x.Id.Equals(Id)).SingleOrDefault();
            if (displayToUpdate == null)
            {
                return false;
            }

            displayToUpdate.Name = display.Name;
            displayToUpdate.Cost = display.Cost;
            displayToUpdate.Description = display.Description;
            return true;
        }
    }
}

