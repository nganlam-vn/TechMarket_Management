using HandyControl.Controls;
using TechMarket_Management.View.UserControls;
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

namespace TechMarket_Management
{
    /// <summary>
    /// Interaction logic for FHome.xaml
    /// </summary>
    public partial class FHome : System.Windows.Window
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            //Dialog.Show(new);
            Dialog.Show(new UCSignUp());

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow fLogin = new MainWindow();
            fLogin.Show();

        }
    }
}
