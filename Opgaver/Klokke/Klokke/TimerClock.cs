using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace Klokke
{
    public class TimerClock : ClockInfo
    {
        public TimeSpan ts;
        //TimeSpan tsMod;
        public TimeSpan TimerAmount { get { return ts - StopWatch.Elapsed; } }
        readonly DispatcherTimer timer = new DispatcherTimer();
        public TimerClock()
        {
            InitializeDispatcherTimer();
            StopWatch = new Stopwatch();
        }
        public TimerClock(TimeSpan values)
        {
            InitializeDispatcherTimer();
            StopWatch = new Stopwatch();
            ts = values;
        }

        public void InitializeDispatcherTimer() => timer.Tick += new EventHandler(DispatcherTimer);

        public void DispatcherTimer(object sender, EventArgs e)
        {
            if (ts < StopWatch.Elapsed)
            {
                timer.Stop();
                StopWatch.Reset();
                MessageBox.Show(string.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds) + " Timer is up");
            }
        }

        public void Pause()
        {
            StopWatch.Stop();
            timer.Stop();
        }
        public void Resume()
        {
            StopWatch.Start();
            timer.Start();
        }

        public string TimerFormat() => string.Format("{0:00}:{1:00}:{2:00}",
                    TimerAmount.Hours, TimerAmount.Minutes, TimerAmount.Seconds);
    }
}
