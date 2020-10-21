using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2
{
    class Tram : Vehicle, IPantograph
    {
        bool pantographIsDown;
        bool pantographIsUp;
        public Tram(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            pantographIsDown = false;
        }
        public string Bell()
        {
            return "Tramwaj dzwoni!";
        }

        public string PantographDown()
        {
            if(pantographIsDown == false)
            {
                pantographIsDown = true;
                return "Opuszczono pantograf;";
            }
            else
            {
                return "Pantograf jest już opuszczony";
            }
        }

        public string PantographUp()
        {
            if (pantographIsDown == false)
            {
                pantographIsDown = true;
                return "Podniesiono pantograf;";
            }
            else
            {
                return "Pantograf jest już podniesiony";
            }
        }

        public override string StartVehicle()
        {
            if (pantographIsDown == false)
            {
                return "Tramwaj odjeżdża";
             }
            else
            {
                return "Pantograf jest opuszczony";
            }
        }

        public override string StopVehicle()
        {
            if (pantographIsUp == false)
            {
                return "Tramwaj zatrzymał się";
            }
            else
            {
                return "Pantograf jest podniesiony";
            }
        }
    }
}
