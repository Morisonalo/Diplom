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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ButtonAutho_Click(object sender, RoutedEventArgs e)
        {
            var pols = App.Context.Diplom_Users.FirstOrDefault(p => p.Login == Login.Text);


            if (Name1.Text == "" || Surname1.Text == "" || MiddleName.Text == "" || Telephone.Text == "" || Login.Text == "" ||
                Password.Text == "") //Проверка заполнения всех полей
            {
                MessageBox.Show("Заполните все поля!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (pols != null) //Проверка заполнения всех полей
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                var user = new Diplom_Users //Переменная с фильмом, данные которого введены
                {
                    Name = Name1.Text,
                    Surname = Surname1.Text,
                    Middle_name = MiddleName.Text,
                    Telephone = Telephone.Text,
                    Login = Login.Text,
                    Password = Password.Text,
                    ID_Role = 1,
                };
                App.Context.Diplom_Users.Add(user); //Добавление нового фильма в таблицу фильмов
                App.Context.SaveChanges(); //Сохранить изменения в контексте
                MessageBox.Show("Пользователь добавлен!", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);//Уведомление о добавлении
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Close();
            }
            catch //Уведомление при фатальных ошибках добавления
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
