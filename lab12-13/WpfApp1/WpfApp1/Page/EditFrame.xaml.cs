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
    /// Interaction logic for EditFrame.xaml
    /// </summary>
    public partial class EditFrame : Page
    {
        public EditFrame()
        {
            InitializeComponent();
            UnitOfWork db = new UnitOfWork();
            CustomerGrid.ItemsSource = db.Customers.GetItemList().ToList();
            OrderGrid.ItemsSource = db.Orders.GetItemList().ToList();
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {

            UnitOfWork context = new UnitOfWork();

            var item = (Customer)this.CustomerGrid.SelectedItem;

            var customer = context.Customers.GetItem(item.CustomerId);
            if (Name.Text != null && Name.Text != "")
                customer.Name = Name.Text;
            if (Email.Text != null && Email.Text != "")
                customer.Email = Email.Text;
            if (Age.Text != null && Age.Text != "")
                customer.Age = Convert.ToInt32(Age.Text);
            context.Customers.Update(customer);
            context.Save();
        }

        private void EditOrder_Click(object sender, RoutedEventArgs e)
        {
            using (ShopBase context = new ShopBase())
            {
                var item = (Order)this.OrderGrid.SelectedItem;
                var customer = context.Orders.Where(p => p.OrderId == item.OrderId).FirstOrDefault();
                if (Product.Text != null && Product.Text != "")
                    customer.ProductName = Product.Text;
                if (Description.Text != null && Description.Text != "")
                    customer.Description = Description.Text;
                if (Quantity.Text != null && Quantity.Text != "")
                    customer.Quantity = Convert.ToInt32(Quantity.Text);
                if (PurchaseDate.SelectedDate != null)
                    customer.PurchaseDate = (DateTime)(PurchaseDate.SelectedDate);
                context.SaveChanges();
                OrderGrid.ItemsSource = context.Orders.ToList();
            }

        }
    }
}
