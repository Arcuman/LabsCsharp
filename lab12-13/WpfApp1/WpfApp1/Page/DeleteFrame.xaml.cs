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
    /// Interaction logic for DeleteFrame.xaml
    /// </summary>
    public partial class DeleteFrame : Page
    {
        public DeleteFrame()
        {
            InitializeComponent();
        }


        private void DeleteCustomer_Copy_Click(object sender, RoutedEventArgs e)
        {
            UnitOfWork context = new UnitOfWork();
            context.Orders.Delete(Convert.ToInt32(ID.Text));
            context.Save();
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            using (ShopBase context = new ShopBase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    Customer customer = context.Customers.Where(p => p.Email == Email.Text).FirstOrDefault();
                    
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    MessageBoxResult result = MessageBox.Show("Are you sure", "Sure?", MessageBoxButton.YesNo);

                    // Process message box results
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            transaction.Commit();
                            break;
                        case MessageBoxResult.No:
                            transaction.Rollback();
                            break;
                    }
                }
            }

        }

    }
}
