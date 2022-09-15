using System;
namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
  
        public EuropeanParrot()
        {
     
        }

        public virtual double GetSpeed()
        {
            
          return GetBaseSpeed();
                   
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}

