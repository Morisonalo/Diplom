using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HabitTracker.Windows
{
    /// <summary>
    /// Логика взаимодействия для Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        private DispatcherTimer _timer;
        private DateTime _endTime;
        private TimeSpan _initialDuration = TimeSpan.FromMinutes(25); // Длительность таймера - 20 минут
        private TimeSpan _remainingDuration;
        private double _totalStrokeLength = 628; // Длина окружности (2 * PI * радиус для окружности)
        private bool _isRunning = false;

        public Timer()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += Timer_Tick;
            ResetTimer();
        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (_isRunning)
            {
                _timer.Stop();
                _remainingDuration = _endTime - DateTime.Now;
                startStopButton.Content = "Start";
            }
            else
            {
                _endTime = DateTime.Now.Add(_remainingDuration);
                _timer.Start();
                startStopButton.Content = "Stop";
            }
            _isRunning = !_isRunning;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _isRunning = false;
            startStopButton.Content = "Start";
            ResetTimer();
        }

        private void ResetTimer()
        {
            _remainingDuration = _initialDuration; // Сбросить время до 20 минут
            UpdateUI(_remainingDuration);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var remainingTime = _endTime - DateTime.Now;
            if (remainingTime <= TimeSpan.Zero)
            {
                remainingTime = TimeSpan.Zero;
                _timer.Stop();
                _isRunning = false;
                startStopButton.Content = "Start";
            }
            UpdateUI(remainingTime);
        }

        private void UpdateUI(TimeSpan remainingTime)
        {
            double progress = remainingTime.TotalSeconds / _initialDuration.TotalSeconds;
            progressCircle.StrokeDashOffset = _totalStrokeLength * progress;
            timeText.Text = remainingTime.ToString(@"mm\:ss");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Authorization().Show();
            this.Close();
        }

        private void Matrix_Click(object sender, RoutedEventArgs e)
        {
            new Matrix().Show();
            this.Close();
        }

        private void Habit_Click(object sender, RoutedEventArgs e)
        {
            new Habit().Show();
            this.Close();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            new User().Show();
            this.Close();
        }
    }



    
}
