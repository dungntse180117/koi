using Bussinessobject;
using service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoiFish
{
    public partial class MainWindow : Window
    {
        private UserAccountService _service = new();

        public UserAccount? GetUserAccountByEmail { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailAddressTextBox.Text.Trim();
            string pass = PasswordTextBox.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Both email and password are required!", "Field required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var acc = _service.GetUserAccountByEmail(email, pass);

            if (acc == null)
            {
                MessageBox.Show("Invalid email or password!", "Wrong", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (acc.Role == 2)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong permission", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show($"Welcome, {acc.Username}!", "Login Successful", MessageBoxButton.OK, MessageBoxImage.Information);

            Window1 page = new Window1();
            page.Show();
            this.Close();
        }
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}