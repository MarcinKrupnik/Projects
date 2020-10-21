using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab2Zadanie
{
    public abstract class Blessing
    {
        protected int rig, pro, div;

        public virtual int GetRig()
        {
            return rig;
        }
        public virtual int GetPro()
        {
            return pro;
        }
        public virtual int GetDiv()
        {
            return div;
        }
    }
}
