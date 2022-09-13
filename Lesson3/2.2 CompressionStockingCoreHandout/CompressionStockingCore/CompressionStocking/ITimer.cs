using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CompressionStocking
{
    public interface ITimer
    {
        public void SetupTimer(double ms);
        public void DisplayTimeEvent(object source, ElapsedEventArgs e);


    }
}
