using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IBtnHandler
    {
        void StartBtnPushed();
        void StopBtnPushed();
    }


    public class StockingCtrl : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;

        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            _compressionCtrl.Compress();
        }

        public void StopBtnPushed()
        {
            _compressionCtrl.Decompress();
        }


    }
}
