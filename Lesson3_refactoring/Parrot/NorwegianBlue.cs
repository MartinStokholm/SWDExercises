using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class NorwegianBlue
    {
        private double _voltage;
        private bool _isNailed;


        public NorwegianBlue(double voltage, bool isNailed)
        {
            _voltage = voltage;
            _isNailed = isNailed;
        }
        public double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }
        private double GetBaseSpeed()
        {
            return 12.0;
        }
    }
   

}
