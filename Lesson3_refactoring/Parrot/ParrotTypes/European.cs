using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot.ParrotTypes
{
    public class European : Parrot
    {
        public European(int numberOfCoconuts, double voltage, bool isNailed)
            : base(numberOfCoconuts, voltage, isNailed)
        {
            
        }
        
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
  
    }
    
}
