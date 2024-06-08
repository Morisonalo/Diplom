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

namespace HabitTracker.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ButtonAutho_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = App.Context.Diplom_Users.FirstOrDefault(p => p.Login == Login.Text && p.Password == Password1.Text); //Сравниваем значение текстовых блоков со значениями в таблице User

            if (currentUser != null) //Такой пользователь найден в таблице User
            {
                App.CurrentUser = currentUser; //ПРИСВАИВАЕМ ЗНАЧЕНИЕ ПЕРЕМЕННОЙ
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else //Если пользователя нет
            {
                MessageBox.Show("Пользователь с такими данными не найден.", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void TextBlockReg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }
    }
}
