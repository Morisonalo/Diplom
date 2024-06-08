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
using System.Xml.Linq;

namespace HabitTracker.Windows
{
    /// <summary>
    /// Логика взаимодействия для Habit.xaml
    /// </summary>
    public partial class Habit : Window
    {
        public Habit()
        {
            InitializeComponent();
            DataContext = this;
            var habits = App.Context.Diplom_Users_Habit.Where(p => p.ID_Users == App.CurrentUser.ID_Users).ToList(); 
            LViewHabits.ItemsSource = habits; 

        }
        public List <Diplom_Type_habit> habits1 { get; set; } = App.Context.Diplom_Type_habit.ToList();

        private void ButtonAddHabit1_Click(object sender, RoutedEventArgs e)
        {
            var hab = App.Context.Diplom_Habit.FirstOrDefault(p => p.ID_Habit == IdHabit.Text);

            if (NameHabit.Text == "" || AmountDay.Text == "" || TypeHabit.Text == "") //Проверка заполнения всех полей
            {
                MessageBox.Show("Заполните все поля!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
            }
            if (hab != null) //Проверка заполнения всех полей
            {
                MessageBox.Show("Привычка с таким кодом уже существует", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                IdHabit.Text = string.Empty;
                return;
            }
            try
            {
                var types = App.Context.Diplom_Type_habit.ToList();//Переменная со списком жанров
                var type = TypeHabit.SelectedItem as Diplom_Type_habit; //Переменная с выбранным элементом списка жанров
                var typeName = $"{type.Name}";//Переменная с названием жанра (берем по предыдущей переменной)
                var typeId = types.Where(x => x.Name == typeName).FirstOrDefault().ID_Habit;

                var USHAB1 = new Diplom_Habit //Переменная с фильмом, данные которого введены
                {
                    ID_Habit = IdHabit.Text,
                    Name = NameHabit.Text,
                    Type_habit = typeId,
                };
                App.Context.Diplom_Habit.Add(USHAB1); //Добавление нового фильма в таблицу фильмов
                App.Context.SaveChanges(); //Сохранить изменения в контексте

                DateTime thisDay = DateTime.Today;

                var USHAB = new Diplom_Users_Habit //Переменная с фильмом, данные которого введены
                {
                    ID_Users = App.CurrentUser.ID_Users,
                    ID_Habit = IdHabit.Text,
                    Date_start = thisDay,
                    Attempt = 1,
                    Amount_of_day = int.Parse(AmountDay.Text),
                    Record = 0,
                };
                App.Context.Diplom_Users_Habit.Add(USHAB); //Добавление нового фильма в таблицу фильмов
                App.Context.SaveChanges(); //Сохранить изменения в контексте
                MessageBox.Show("Привычка добавлена!", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);//Уведомление о добавлении
                var habits = App.Context.Diplom_Users_Habit.Where(p => p.ID_Users == App.CurrentUser.ID_Users).ToList();
                LViewHabits.ItemsSource = habits;
            }
            catch //Уведомление при фатальных ошибках добавления
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonAddHabit_Click_1(object sender, RoutedEventArgs e)
        {
            HabitAddShadow.Visibility = Visibility.Collapsed;
        }

        private void BtnRedaktFilm_Click(object sender, RoutedEventArgs e)
        {
            var currentService = (sender as Button).DataContext as DataBase.Diplom_Users_Habit; //Создание переменной выбранного сервиса

            if (MessageBox.Show("Вы уверены, что хотите сбросить прогресс?" , "Внимание", 


                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            //Если во всплывающем окне вы согласились удалить услугу

            {
                currentService.Date_start = DateTime.Now;
                currentService.Attempt = currentService.Attempt + 1;
                App.Context.SaveChanges();//Сохранить изменения в базе
                var habits = App.Context.Diplom_Users_Habit.Where(p => p.ID_Users == App.CurrentUser.ID_Users).ToList();
                LViewHabits.ItemsSource = habits;
            }

        }

        private void LViewHabits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Habit1_Click(object sender, RoutedEventArgs e)
        {
            new Habit().Show();
            this.Close();
        }

        private void Matrix_Click(object sender, RoutedEventArgs e)
        {
            new Matrix().Show();
            this.Close();
        }
    }
}
