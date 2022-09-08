using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;

namespace CompressionStockingApplication
{

    class StubCompressionCtrl : ICompressionCtrl
    {
        public void Compress()
        {
            Console.WriteLine("StubCompressionCtrl::Compress() called");
        }

        public void Decompress()
        {
            Console.WriteLine("StubCompressionCtrl::Decompress() called");
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
