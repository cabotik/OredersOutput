using OredersUotput.DB;
using OredersUotput.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ViewOrdersWindow.xaml
    /// </summary>
    public partial class ViewOrdersWindow : Window
    {
        public ObservableCollection<OrderView> OrderViews { get; set; }
        public ViewOrdersWindow()
        {
            InitializeComponent();
            

            LBOrders();
        }
        private void LBOrders()
        {
           DB.MyContext my = new DB.MyContext();
            OrderViews = new ObservableCollection<OrderView>();
            foreach (var i in my.orders)
            { 
                OrderViews.Add(new OrderView()
                { 
                    OrderId = Convert.ToInt32(i.OrderId),
                    Client = i.Client
                });
            }
            lbOrder.ItemsSource = OrderViews;
        }
    }
}
