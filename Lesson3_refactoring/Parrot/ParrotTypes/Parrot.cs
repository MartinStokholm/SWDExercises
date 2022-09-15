using System;

namespace Parrot.ParrotTypes
{
    public abstract class Parrot
    {
        public readonly bool _isNailed;
        public readonly int _numberOfCoconuts;
        
        public readonly double _voltage;

        public Parrot(int numberOfCoconuts, double voltage, bool isNailed)
        {
            _numberOfCoconuts = numberOfCoconuts;
            _isNailed = isNailed;
            _voltage = voltage;
        }

        abstract public double GetSpeed();
        
        public double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
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