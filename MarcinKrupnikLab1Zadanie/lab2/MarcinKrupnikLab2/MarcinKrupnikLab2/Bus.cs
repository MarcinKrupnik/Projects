using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2
{
    class Bus : Vehicle
    {
        int gasoilLevel;
        public Bus(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
        }
        /// <summary>
        /// Metoda zwracająca informacje o zatankowaniu autobusu.
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus został zatankowany";
        }

        public override string StartVehicle()
        {
            throw new NotImplementedException();
        }

        public override string StopVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
