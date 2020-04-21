using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace ToDo_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Да это уже не mvvm но мне надоело делать лабу поэтому решил по простому
        public MainWindow()
        {
            this.InitializeComponent();
            List<string> styles = new List<string> { "Orange", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Orange";
            this.DataContext = this;
        }
        private void button1_Click(object sender, RoutedEventArgs e) => this.Resources["buttonBrush"] = new SolidColorBrush(Colors.LimeGreen);

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri("Styles\\" + style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        public static RoutedCommand GreetUserCommand = new RoutedUICommand("Here", "GreetUser", typeof(MainWindow));

        private void GreetUser_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtSomeText.Text == null || txtSomeText.Text == "")
            e.CanExecute = false;
            else
                e.CanExecute = true;
        }

        private void GreetUser_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Im RoutedUICommand");
        }

        private void txtSomeText_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }
    }
}
