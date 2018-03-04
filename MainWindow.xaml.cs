using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Practice02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocusFirstName(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text == "First Name*")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBox_LostFocusFirstName(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            var oldVal = txtBox.Text;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "First Name*";
            }
        }

        private void TextBox_GotFocusLastName(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text == "Last Name*")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBox_LostFocusLastName(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            var oldVal = txtBox.Text;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "Last Name*";
            }
        }

        private void TextBox_GotFocusEmail(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text == "Email Address*")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBox_LostFocusEmail(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            var oldVal = txtBox.Text;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "Email Address*";
            }
        }

        private void TextBox_GotFocusPassword(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text == "Set a Password*")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBox_LostFocusPassword(object sender, KeyboardFocusChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            var oldVal = txtBox.Text;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "Set a Password*";
            }
        }

        private bool Validated(string textBoxValue)
        {
            return !textBoxValue.Contains("*") && textBoxValue.Length > 0;
        }

        private bool ToEnableButton()
        {
            var template = mainWindow.Template;
            var firstNameTB = template.FindName("firstNameTextBox", mainWindow) as TextBox;
            var lastNameTB = template.FindName("lastNameTextBox", mainWindow) as TextBox;
            var emailTB = template.FindName("emailTextBox", mainWindow) as TextBox;
            var birthdayDP = template.FindName("birthdayDatePicker", mainWindow) as DatePicker;
            return Validated(firstNameTB.Text) && Validated(lastNameTB.Text) && Validated(emailTB.Text) && birthdayDP.SelectedDate != null;
        }
    }
}
