using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2Zadanie
{
    public abstract class Potion
    {
        protected int hp, mana , power;

        public virtual int GetHp()
        {
            return hp;
        }
        public virtual int GetMana()
        {
            return mana;
        }
        public virtual int GetPower()
        {
            return power;
        }
    }
}
