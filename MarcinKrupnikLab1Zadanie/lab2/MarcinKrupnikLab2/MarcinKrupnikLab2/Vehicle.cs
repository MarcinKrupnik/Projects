using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2
{
    abstract class Vehicle
    {
        protected int vehicleNumber, yearOfProduction;
        protected string name;
        /// <summary>
        /// metoda pobierająca rok produkcji
        /// </summary>
        /// <returns></returns>
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }
        public virtual int GetYearOfProduction()
        {
            return yearOfProduction;
        }
        public virtual string GetName()
        {
            return name;
        }
        /// <summary>
        /// metoda usta
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetVehicleNumber(int n)
        {
            vehicleNumber = n;
        }
        public abstract string StartVehicle();
        public abstract string StopVehicle();
    }
}
