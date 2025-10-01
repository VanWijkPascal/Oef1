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

namespace Oef1
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {

            txtResume.Text = "Firstname: " + txtFirstname.Text + "\r\nLastname: " + txtLastname.Text;
            txtResume.Text = "Firstname: " + txtFirstname.Text + Environment.NewLine + "Lastname: " + txtLastname.Text;
        }
    }
}