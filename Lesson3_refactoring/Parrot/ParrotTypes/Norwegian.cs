using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot.ParrotTypes
{
    public class Norwegian : Parrot
    {
        public Norwegian(int numberOfCoconuts, double voltage, bool isNailed) 
            : base(numberOfCoconuts, voltage, isNailed)
        {
       
            
        }

        override public double GetSpeed() 
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }    
    }
}
