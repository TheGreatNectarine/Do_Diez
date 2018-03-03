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

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text.Length != 0)
            {
                txtBox.Text = string.Empty;
            }
        }
    }
}
