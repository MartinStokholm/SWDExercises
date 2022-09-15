using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot.ParrotTypes
{
    public class African : Parrot
    {
        public African(int numberOfCoconuts, double voltage, bool isNailed) 
            : base(numberOfCoconuts, voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }
   
}
