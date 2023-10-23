using System.Windows;
using TravelPal.Pages;

namespace TravelPal
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerwindow = new RegisterWindow();
            registerwindow.Show();
            Close();
        }
    }
}
