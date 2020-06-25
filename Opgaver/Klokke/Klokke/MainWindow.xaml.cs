using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;

namespace Klokke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TimeDisplay.Text = Display.TimeNow();
        public MainWindow()
        {
            InitializeComponent();

        }

        TimeSpan t;
        private void LiveTime_Tick(object sender, EventArgs e) => TimeDisplay.Content = Display.TimeNow();
        private void LiveTime_Tick2(object sender, EventArgs e) => Watch.Content = Display.TimeNow();


        /// <summary>
        /// Counter
        /// </summary>
        public void Updater(EventHandler e)
        {
            ClockInfo.Time.Tick += e;
            ClockInfo.Time.Start();
        }

        /// <summary>
        /// Updater and timer controller
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EditList.ItemsSource = WatchList.Items;
            ClockInfo.Time.Interval = TimeSpan.FromSeconds(1);
            Updater(LiveTime_Tick);
            Updater(LiveTime_Tick2);
            Updater(CountDownTimer);
            Updater(AlarmBib);

        }

        #region Stopwatch Code
        TimeSpan lap;
        Stopwatch stopwatch = new Stopwatch();
        /// <summary>
        /// Display Time
        /// </summary>
        public void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan sw = stopwatch.Elapsed;
            lap = ClockInfo.Lap.Elapsed;
            StopWatchDisplay.Content = string.Format("{0:00}:{1:00}:{2:00}", sw.Hours, sw.Minutes, sw.Seconds);
            LapDisplay.Content = string.Format("{0:00}:{1:00}:{2:00}", lap.Hours, lap.Minutes, lap.Seconds);
        }
        private void Lap_Click(object sender, RoutedEventArgs e)
        {
            ClockInfo.Lap.Restart();
            LapTimer.Items.Add(LapDisplay.Content);
        }
        /// <summary>
        /// Start timer
        /// </summary>
        private void StopwatchStart_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            ClockInfo.Lap.Start();
            Updater(Timer_Tick);
        }
        /// <summary>
        /// Stop timer
        /// </summary>
        private void StopwatchStop_Click(object sender, RoutedEventArgs e)
        {
            LapTimer.Items.Clear();
            stopwatch.Stop();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopwatchReset_Click(object sender, RoutedEventArgs e) => stopwatch.Restart();
        #endregion

        #region Countdown Code
        /// <summary>
        /// Counts down each second, and makes sure there are no letters in the textboxes
        /// </summary>
        TimeSpan form;
        private int currentSelection;
        readonly List<TimerClock> list = new List<TimerClock>();
        private void CountDownTimer(object sender, EventArgs e)
        {
            form = t - ClockInfo.CountDown.Elapsed;
            if (form.Hours < 0 && form.Minutes < 0 && form.Seconds < 0)
            {
                ClockInfo.CountDown.Stop();
                CountDown.Content = string.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);
            }
            if (Regex.IsMatch(Hours.Text, "[^0-9]") || Regex.IsMatch(Minutes.Text, "[^0-9]") || Regex.IsMatch(Seconds.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Hours.Text = "0";
                Minutes.Text = "0";
                Seconds.Text = "0";
            }
            else
            {
                    for (int i = 0; i < list.Count; i++)
                        if (list[i].StopWatch.IsRunning && i != CountDownList.SelectedIndex)
                            CountDownList.Items[i] = list[i].TimerFormat();
            }
        }
        private void AddTimer_Click(object sender, RoutedEventArgs e)
        {
            CountDownList.Items.Clear();
            list.Add(new TimerClock(form));
            foreach (var item in list)
                CountDownList.Items.Add(item.TimerFormat());
        }

        private void StartCountdown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list[CountDownList.SelectedIndex].Resume();
            }
            catch
            {
                for (int x = 0; x < list.Count; x++)
                    list[x].Resume();
            }
        }
        private void StopCountdown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list[CountDownList.SelectedIndex].Pause();
            }
            catch
            {
                for (int x = 0; x < list.Count; x++)
                    list[x].Pause();
            }
        }
        private void ResetCountdown_Click(object sender, RoutedEventArgs e)
        {
            CountDownList.Items.Clear();
            try
            {
                list[CountDownList.SelectedIndex].StopWatch.Reset();
            }
            catch
            {
                for (int x = 0; x < list.Count; x++)
                    list[x].StopWatch.Reset();
            }
        }
        private void PlusCountdown_Click(object sender, RoutedEventArgs e)
        {
            if (CountDownList.SelectedIndex != -1)
                list[CountDownList.SelectedIndex].ts += new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Minutes.Text), Convert.ToInt32(Seconds.Text));
            else
                t += new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Minutes.Text), Convert.ToInt32(Seconds.Text));
        }

        private void MinusCountdown_Click(object sender, RoutedEventArgs e)
        {
            if (CountDownList.SelectedIndex != -1)
                list[CountDownList.SelectedIndex].ts -= new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Minutes.Text), Convert.ToInt32(Seconds.Text));
            else
                t -= new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Minutes.Text), Convert.ToInt32(Seconds.Text));
        }
        #endregion

        #region Watch code
        /// <summary>
        /// When alarm is done, let me know
        /// </summary>
        private void AlarmBib(object sender, EventArgs e)
        {
            if (WatchList.Items.Contains($"{DateTime.Now.DayOfWeek.ToString()} - {Display.TimeNow()}"))
                MessageBox.Show(SelvText.Text);

        }
        private void WatchAdd_Click(object sender, RoutedEventArgs e)
        {
            WatchList.Items.Add($"{DayOfWeek.Text} - {Hours1.Text}:{Minutes1.Text}:{Seconds1.Text} ({SelvText.Text})");
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            WatchList.Items.Remove(EditList.Text);
            WatchList.Items.Add(EditList.Text = $"{DayOfWeek.Text} - {Hours1.Text}:{Minutes1.Text}:{Seconds1.Text} ({SelvText.Text})");
        }
        #endregion

    }
}
