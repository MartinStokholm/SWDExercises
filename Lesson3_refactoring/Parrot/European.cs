using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class European
    {


        public European()
        {
          
        }

        public double GetSpeed()
        {

            return GetBaseSpeed();
        }

        private double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}
