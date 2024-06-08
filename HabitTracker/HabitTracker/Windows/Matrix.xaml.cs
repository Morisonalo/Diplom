using HabitTracker.DataBase;
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

namespace HabitTracker.Windows
{
    /// <summary>
    /// Логика взаимодействия для Matrix.xaml
    /// </summary>
    public partial class Matrix : Window
    {
        
        public Matrix()
        {
            InitializeComponent();
            DataContext = this;
           
            var matrix = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 1).ToList();
            SpisokDataGrid.ItemsSource = matrix;
            var matrix2 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 2).ToList();
            SpisokDataGrid2.ItemsSource = matrix2;
            var matrix3 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 3).ToList();
            SpisokDataGrid3.ItemsSource = matrix3;
            var matrix4 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 4).ToList();
            SpisokDataGrid4.ItemsSource = matrix4;


            //var matrix = App.Context.Diplom_User_Matrix.Where(p => p.ID_User == App.CurrentUser.ID_Users).ToList();
        }
     

        private void AddMatrix1_Click(object sender, RoutedEventArgs e)
        {
            new MatrixAdd().Show();
            this.Close();
           
        }

        private void SpisokDataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SpisokDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddMatrix2_Click(object sender, RoutedEventArgs e)
        {
            new MatrixAdd2().Show();
            this.Close();
        }

        private void AddMatrix3_Click(object sender, RoutedEventArgs e)
        {
            new MatrixAdd3().Show();
            this.Close();
        }

        private void AddMatrix4_Click(object sender, RoutedEventArgs e)
        {
            new MatrixAdd4().Show();
            this.Close();
        }

        private void BtnDelete1_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokDataGrid.SelectedItem is Diplom_Note user)
            {
           
                App.Context.Diplom_Note.Remove(user);
                App.Context.SaveChanges();
                var matrix = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 1).ToList();
                SpisokDataGrid.ItemsSource = matrix;
            }

        }

        private void BtnDelete2_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokDataGrid2.SelectedItem is Diplom_Note user)
            {

                App.Context.Diplom_Note.Remove(user);
                App.Context.SaveChanges();
                var matrix2 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 2).ToList();
                SpisokDataGrid2.ItemsSource = matrix2;
            }
        }

        private void BtnDelete3_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokDataGrid3.SelectedItem is Diplom_Note user)
            {

                App.Context.Diplom_Note.Remove(user);
                App.Context.SaveChanges();
                var matrix3 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 3).ToList();
                SpisokDataGrid3.ItemsSource = matrix3;
            }
        }

        private void BtnDelete4_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokDataGrid4.SelectedItem is Diplom_Note user)
            {

                App.Context.Diplom_Note.Remove(user);
                App.Context.SaveChanges();
                var matrix4 = App.Context.Diplom_Note.Where(p => p.ID_Type_Note == 4).ToList();
                SpisokDataGrid4.ItemsSource = matrix4;
            }
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

        private void User_Click(object sender, RoutedEventArgs e)
        {
            new User().Show();
            this.Close();
        }

        private void Timer_Click(object sender, RoutedEventArgs e)
        {
            new Timer().Show();
            this.Close();
        }

        private void Habit_Click(object sender, RoutedEventArgs e)
        {
            new Habit().Show();
            this.Close();
        }

        private void Matrix1_Click(object sender, RoutedEventArgs e)
        {
            new Matrix().Show();
            this.Close();
        }
    }

       

        



      



}
    


