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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FIndFrame.xaml
    /// </summary>
    public partial class FIndFrame : Page
    {
        public FIndFrame()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            using(ShopBase context = new ShopBase())
            {
                if (Age.Text != null && Age.Text != "" && Name.Text != null && Name.Text != "")
                {
                    int age = Convert.ToInt32(Age.Text);
                    CustomerGrid.ItemsSource = context.Customers
                        .Select(x => x)
                        .Where(x => x.Name == Name.Text)
                        .Where(x => x.Age == age).ToList();
                }
                else if (Name.Text != null && Name.Text != "")
                {
                    CustomerGrid.ItemsSource = context.Customers
                        .Select(x => x)
                        .Where(x => x.Name == Name.Text).ToList();
                }
            }
        }
    }
}
