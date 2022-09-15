using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class Africa
    {
        private readonly int _numberOfCoconuts;

        public Africa(int numberOfCoconuts) 
        {
            _numberOfCoconuts = numberOfCoconuts;

        }
        public double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }


        private double GetBaseSpeed()
        {
            return 12.0;
        }

        private double GetLoadFactor()
        {
            return 9.0;
        }
    }
}
