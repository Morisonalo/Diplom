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
    /// Логика взаимодействия для MatrixAdd4.xaml
    /// </summary>
    public partial class MatrixAdd4 : Window
    {
        public MatrixAdd4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TbNameNote4.Text == "" || TbDiscriptionNote4.Text == "") //Проверка заполнения всех полей
            {
                MessageBox.Show("Заполните все поля!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            try
            {


                var note = new Diplom_Note //Переменная с фильмом, данные которого введены
                {
                    Name = TbNameNote4.Text,
                    Discription = TbDiscriptionNote4.Text,
                    Date = DateTime.Now,
                    ID_Users = App.CurrentUser.ID_Users,
                    ID_Type_Note = 4,
                };
                App.Context.Diplom_Note.Add(note); //Добавление нового фильма в таблицу фильмов
                App.Context.SaveChanges(); //Сохранить изменения в контексте

                MessageBox.Show("Привычка добавлена!", "Уведомление");
                new Matrix().Show();
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
