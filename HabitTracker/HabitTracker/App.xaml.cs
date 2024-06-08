using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HabitTracker
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DataBase.user187_dbEntities Context
        { get; } = new DataBase.user187_dbEntities();

        public static DataBase.Diplom_Users CurrentUser = null;
    }
}
