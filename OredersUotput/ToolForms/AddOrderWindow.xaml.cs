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

namespace OredersUotput.ToolForms
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        public AddOrderWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MyContext myContext = new DB.MyContext();
                DB.Order myOrder = new DB.Order()
                {

                    Structure = tbStructure.Text,
                    Price = Convert.ToInt32(tbPrice.Text),
                    Client= tbClient.Text
                };
                try 
                {
                    myContext.orders.Add(myOrder);
                    myContext.SaveChanges();
                    MessageBox.Show("Order was added.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbClient.Clear();
            tbPrice.Clear();
            tbStructure.Clear();
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
