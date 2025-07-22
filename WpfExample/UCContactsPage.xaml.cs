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
    /// Interaction logic for UCContactsPage.xaml
    /// </summary>
    public partial class UCContactsPage : Page
    {
        public UCContactsPage()
        {
            InitializeComponent();
            List<ContantDetails> contacts = new List<ContantDetails>();
            contacts.Add(new ContantDetails { ContactName = "אבי", ContactType = true, ContactImage = "Images/boy1.jpg" });
            contacts.Add(new ContantDetails { ContactName = "רוני", ContactType = false, ContactImage = "Images/boy2.jpg" });
            contacts.Add(new ContantDetails { ContactName = "דני", ContactType = true, ContactImage = "Images/boy3.jpg" });

            foreach (ContantDetails contact in contacts) 
            {
                MyContactsUserControl userControl = new MyContactsUserControl(contact);
                this.spContacts.Children.Add(userControl);
            }

           }
    }
}
