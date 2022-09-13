using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using CompressionStocking;
using Timer = System.Timers.Timer;

namespace CompressionStockingApplication
{
    class StubCompressionCtrl : ICompressionCtrl
    {
        public void Compress()
        {
            Console.WriteLine("StubCompressionCtrl::Compress() called");
            SetupTimer(5000);
        }

        public void Decompress()
        {
            Console.WriteLine("StubCompressionCtrl::Decompress() called");
        }

        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"Timer event triggered at {DateTime.Now}");
            source.Stop();
        }

        public void SetupTimer(double ms)
        {
            Timer newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = ms;
            newTimer.Start();
        }
    }

    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            var compressionStockingstocking = new StockingCtrl(new StubCompressionCtrl());
            ConsoleKeyInfo consoleKeyInfo;
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)  compressionStockingstocking.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  compressionStockingstocking.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
