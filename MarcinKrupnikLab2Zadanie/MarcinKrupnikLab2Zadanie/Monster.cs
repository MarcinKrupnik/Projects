using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2Zadanie
{
    public abstract class Monster
    {
        protected int hp, atc, arm;

        public virtual int GetHp()
        {
            return hp;
        }
        public virtual int GetArm()
        {
            return arm;
        }
        public virtual int GetAtc()
        {
            return atc;
        }
    }
}
