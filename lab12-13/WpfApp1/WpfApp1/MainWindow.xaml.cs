using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new InfoFrame());
        }

        private void AddLector_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new AddFrame());
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DeleteFrame());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new EditFrame());
        }

        private void RefreshBut_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new InfoFrame());
        }
        private void FindObj_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new FIndFrame());
        }

    }
}
