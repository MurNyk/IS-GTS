using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IS_GTS
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int CurrentUserID { get; set; } = 0;
        public static string CurrentUserName { get; set; } = "Гость";
        public static string CurrentUserLogin { get; set; } = "";
        public static int CurrentUserRole { get; set; } = 0;
    }
}