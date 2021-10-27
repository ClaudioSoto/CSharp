using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP1
{
    class Watch
    {
        private int _status = 0;
        public  TimeSpan time { set; get; }
        private Stopwatch _stopWatch = new Stopwatch();


        public void Start()
        {
            if (this._status != 1)
                this._status = 1;
            else
                throw new InvalidOperationException();
            _stopWatch.Start();

        }

        public void Stop()
        {
            if (this._status != 0)
                this._status = 0;
            else
                throw new InvalidOperationException();
            _stopWatch.Stop();
            this.time = _stopWatch.Elapsed;
        }
    }
}

