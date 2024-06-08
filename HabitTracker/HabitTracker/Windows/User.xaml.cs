using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
            Name1.Text = App.CurrentUser.Name;
            Surname1.Text = App.CurrentUser.Surname;
            MiddleName1.Text = App.CurrentUser.Middle_name;
            Telephone1.Text = App.CurrentUser.Telephone;
            if (App.CurrentUser.Photo != null)
            {
                ImageUser.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(App.CurrentUser.Photo);
            }
            
        }
        private byte[] _mainImageData;

        private void SelectPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image |*.png; *.jpg; *.jpeg"; //Открываем проводник и ищем в папках изображения в форматах *.png; *.jpg; *.jpeg
            if (ofd.ShowDialog() == true)
            {
                _mainImageData = File.ReadAllBytes(ofd.FileName);
                ImageUser.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(_mainImageData); //Перенос выбранного на форму
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_mainImageData != null) //Если изображение не пустое
                App.CurrentUser.Photo = _mainImageData; //То передаем его как постер
            App.Context.SaveChanges(); //Сохраняем изменения в базе

        }

        private void ButtonChangeInformation_Click(object sender, RoutedEventArgs e)
        {
            PanelShadow.Visibility = Visibility.Collapsed;
        }

        private void ButtonSaveChangeInformation_Click(object sender, RoutedEventArgs e)
        {
            if (Name2.Text == "" || Surname2.Text == "" || MiddleName2.Text == "" || Telephone2.Text == "" || Password.Text == "" ||
                RepeatPassword.Text == "") //Проверка заполнения всех полей
            {
                MessageBox.Show("Заполните все поля!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (Password.Text != RepeatPassword.Text)
            {
                RepeatPassword.Text = null;
                MessageBox.Show("Повторите пароль снова!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                App.CurrentUser.Name = Name2.Text; //Передача выбранному фильму кода из TextBox
                App.CurrentUser.Surname = Surname2.Text; //Передача выбранному фильму названия из TextBox
                App.CurrentUser.Middle_name = MiddleName2.Text; //Передача выбранному фильму года выпуска из TextBox
                App.CurrentUser.Telephone = Telephone2.Text; //Передача выбранному фильму Id жанра из TextBox
                App.CurrentUser.Password = Password.Text;
               
                
                App.Context.SaveChanges(); //Сохраняем изменения в базе
                MessageBox.Show("Изменения внесены!", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information); //Уведомление об успешном сохранении
                PanelShadow.Visibility = Visibility.Visible;
                Name1.Text = App.CurrentUser.Name;
                Surname1.Text = App.CurrentUser.Surname;
                MiddleName1.Text = App.CurrentUser.Middle_name;
                Telephone1.Text = App.CurrentUser.Telephone;

            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные!", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Name2.Text = App.CurrentUser.Name;
            Surname2.Text = App.CurrentUser.Surname;
            MiddleName2.Text = App.CurrentUser.Middle_name;
            Telephone2.Text = App.CurrentUser.Telephone;
            Login.Text = App.CurrentUser.Login;
        }

        private void Matrix_Click(object sender, RoutedEventArgs e)
        {
            new Matrix().Show();
            this.Close();
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
