using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace ToDo_List
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static event EventHandler LanguageChanged;
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var tasks = new List<Task>();
            var formatter = new XmlSerializer(typeof(List<Task>));
            using (var fs = new FileStream("../../DataBase/TasksStorage.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                tasks = (List<Task>)formatter.Deserialize(fs);
            }

            var view = new MainWindow();                 // создали View
            var viewModel = new MainViewModel(tasks); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }

    }
}
