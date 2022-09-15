using System;

namespace Parrot
{
    public class NorwegianBlueParrot
    {
        private readonly bool _isNailed;

        private readonly double _voltage;

        public NorwegianBlueParrot( double voltage, bool isNailed)
        {

            _voltage = voltage;
            _isNailed = isNailed;
        }

        public virtual double GetSpeed()
        {
            
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
            

           // throw new Exception("Should be unreachable");
        }

        public double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}

