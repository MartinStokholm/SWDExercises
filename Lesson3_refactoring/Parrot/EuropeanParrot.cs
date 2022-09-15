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
             
           // throw new Exception("Should be unreachable");
      
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}

