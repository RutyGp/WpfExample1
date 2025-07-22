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
using static System.Net.Mime.MediaTypeNames;

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for UserControlExample.xaml
    /// </summary>
    public partial class UserControlExamplePage : Page
    {
        public UserControlExamplePage()
        {
            InitializeComponent();
            //List<ContantDetails> contacts = new List<ContantDetails>();
            //contacts.Add(new ContantDetails { ContactName = "אבי", ContactType = true, ContactImage = "Images/boy3.jpg" });
            //contacts.Add(new ContantDetails { ContactName = "אבי", ContactType = true, ContactImage = "Images/boy1.jpg" });
            ////   )
            ////{
            ////    new ContantDetails { ContactName = "אבי", ContactType = true, ContactImage = "Images/boy1.jpg" },
            ////    new ContantDetails { ContactName = "רוני", ContactType = false, ContactImage = "Images/boy2.jpg" },
            ////    new ContantDetails { ContactName = "דני", ContactType = true, ContactImage = "Images/boy3.jpg" },
            ////    new ContantDetails { ContactName = "מיכל", ContactType = false, ContactImage = "Images/boy1.jpg" },
            ////};

            //foreach (var contact in contacts)
            //{
            //    MyContactsUserControl userControl = new MyContactsUserControl(contact);
            //    ContactsPanel.Children.Add(userControl);
            //}
        }
    }
}
