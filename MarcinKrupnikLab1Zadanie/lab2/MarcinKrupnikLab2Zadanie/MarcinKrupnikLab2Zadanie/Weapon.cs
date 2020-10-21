using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2Zadanie
{
    public abstract class Weapon
    {
        protected int strange, atc, range;

        public virtual int GetStrength()
        {
            return strange;
        }
        public virtual int GetRange()
        {
            return range;
        }
        public virtual int GetAtc()
        {
            return atc;
        }
    }
}
