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
using WpfApp1.Repository;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddFrame.xaml
    /// </summary>
    public partial class AddFrame : Page
    {
        public AddFrame()
        {
            InitializeComponent();
        }

        private void SaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            UnitOfWork context = new UnitOfWork();
                try
                {
                    Customer customer = new Customer();
                    customer.Name = Name.Text;
                    customer.Email = Email.Text;
                    customer.Age = Convert.ToInt32(Age.Text);

                    context.Customers.Create(customer);
                    context.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Name.Text = "";
                Email.Text = "";
                Age.Text = "";
        }

        private void SaveOrders_Copy_Click(object sender, RoutedEventArgs e)
        {
            UnitOfWork context = new UnitOfWork();
                try
                {

                    Order order = new Order();
                    order.ProductName = Product.Text;
                    order.Description = Description.Text;
                    order.Quantity = Convert.ToInt32(Quantity.Text);
                    order.PurchaseDate = (DateTime)PurchaseDate.SelectedDate;
                order.Customer = context.Customers.GetCustomerByEmail(CustomerEmail.Text);
                    context.Orders.Create(order);
                context.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Product.Text = "";
                Description.Text = "";
                Quantity.Text = "";
                PurchaseDate.SelectedDate = null;
                CustomerEmail.Text = "";
        }
    }
}
