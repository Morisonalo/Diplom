using HabitTracker.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HabitTracker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private User currentUser;

        public MainWindow(User user)
        {
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            User User = new User();
            User.Show();
            this.Close();
        }

        private void Habit_Click(object sender, RoutedEventArgs e)
        {
            Habit habit = new Habit();
            habit.Show();
            this.Close();
        }

        private void Matrix_Click(object sender, RoutedEventArgs e)
        {
           Windows.Matrix matrix = new Windows.Matrix();
           matrix.Show();
           this.Close();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new Authorization().Show();
            this.Close();
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

        private void Timer_Click(object sender, RoutedEventArgs e)
        {
            new Timer().Show();
            this.Close();
        }
    }
}
