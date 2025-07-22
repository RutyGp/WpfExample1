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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for Examples.xaml
    /// </summary>
    public partial class Examples : Window
    {
        public Examples()
        {
            InitializeComponent();
        }

      
        private void UserConrtolClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            if (b.Name == "btnContacts")
                myFrame1.Navigate(new UCContactsPage());
            else myFrame2.Navigate(new UCContactsPage());
        }
    }
}
