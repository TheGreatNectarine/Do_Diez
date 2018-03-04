using System;
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
            DataContext = new SignInViewModel(ShowResultView);
        }

        private void ShowResultView()
        {
            var data = DataContext as SignInViewModel;
            var user = new Person(data.FirstName, data.LastName, data.Email, data.DateOfBirth);
            var adult = DateTime.Today.Year - user.DateOfBirth.Year > 18 ? "Yes" : "No";
            var bday = user.IsBirthday ? "Happy Birthday":"";
            MessageBox.Show($"Name: {user.FirstName}\n" +
                            $"Surname: {user.LastName}\n" +
                            $"Email: {user.Email}\n" +
                            $"Date of birth: {user.DateOfBirth}\n" +
                            $"Adult: {user.IsAdult}\n" +
                            $"Sign: {user.SunSign}\n" +
                            $"Chinese Sign: {user.ChineseSign}\n" +
                            $"{bday}");
        }

        private void ShowView(UIElement element)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(element);
        }
    }
}
