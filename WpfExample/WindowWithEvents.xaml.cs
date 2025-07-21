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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for WindowWithEvents.xaml
    /// </summary>
    public partial class WindowWithEvents : Window
    {
        public WindowWithEvents()
        {
            InitializeComponent();
        }



     
            private string selectedOption = "";

            

            private void SubmitButton_Click(object sender, RoutedEventArgs e)
            {
                string username = UsernameTextBox.Text;
                string password = UserPasswordBox.Password;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedOption))
                {
                    ResultTextBlock.Text = "יש למלא את כל השדות.";
                }
                else
                {
                    ResultTextBlock.Text = $"שלום {username}, בחרת את: {selectedOption}";
                }
            }

            private void RadioButton_Checked(object sender, RoutedEventArgs e)
            {
                if (Option1Radio.IsChecked == true)
                {
                    selectedOption = "אופציה 1";
                }
                else if (Option2Radio.IsChecked == true)
                {
                    selectedOption = "אופציה 2";
                }
                MessageBox.Show(selectedOption, "בחירת אופציה", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        }
    }

