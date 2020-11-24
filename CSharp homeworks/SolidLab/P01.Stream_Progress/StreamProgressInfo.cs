using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable _streamable;

        public StreamProgressInfo(IStreamable objStreamable)
        {
            this._streamable = objStreamable;
        }

        public int CalculateCurrentPercent()
        {
            return (this._streamable.BytesSent * 100) / this._streamable.Length;
        }
    }
}
