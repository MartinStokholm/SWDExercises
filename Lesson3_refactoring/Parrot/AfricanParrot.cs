using System;
namespace Parrot
{
    public class AfricanParrot
    {
        private readonly int _numberOfCoconuts;
 
        public AfricanParrot( int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public virtual double GetSpeed()
        {
            
      
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
               

           // throw new Exception("Should be unreachable");
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

