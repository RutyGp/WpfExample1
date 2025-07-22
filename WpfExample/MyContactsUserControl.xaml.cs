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
    /// Interaction logic for MyContactsUserControl.xaml  
    /// </summary>  
    public partial class MyContactsUserControl : UserControl
    {
        public MyContactsUserControl()
        {
            InitializeComponent();
        }

         
        public MyContactsUserControl(ContantDetails contant)
        {
            InitializeComponent();
            this.firstName.Text = contant.ContactName;
            this.Option1Radio.IsChecked = contant.ContactType;
            if (contant.ContactType)
            {
                this.Option1Radio.IsChecked = true;
                this.Option2Radio.IsChecked = false;
            }
            else
            {
                this.Option1Radio.IsChecked = false;
                this.Option2Radio.IsChecked = true;
            }
            this.contactImage.Source = new BitmapImage(new Uri(contant.ContactImage, UriKind.RelativeOrAbsolute));
        }
    }


}
