using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Klokke
{
    public class ClockInfo
    {
        
        public static DispatcherTimer Time = new DispatcherTimer();
        public Stopwatch StopWatch = new Stopwatch();
        public static readonly Stopwatch Lap = new Stopwatch();
        public static readonly Stopwatch CountDown = new Stopwatch();
        public static string Format => "HH:mm:ss";
    }
}
