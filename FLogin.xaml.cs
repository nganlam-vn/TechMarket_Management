using TechMarket_Management.View.UserControls;
using HandyControl.Controls;
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

namespace TechMarket_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FLogin : System.Windows.Window
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FHome fHome = new FHome();
            fHome.Show();

        }
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {        
            Dialog.Show(new UCSignUp());

        }

        private void txtbUserName_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}