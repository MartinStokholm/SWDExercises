using System;
namespace Parrot
{
    public class AfricanParrot : Parrot
    {
        private readonly int _numberOfCoconuts;
 
        public AfricanParrot( int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public double GetSpeed()
        {
     
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
               
        }

        public double GetLoadFactor()
        {
            return 9.0;
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}

