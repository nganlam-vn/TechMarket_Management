using TechMarket_Management.View.UserControls.UCSeller;
using HandyControl.Controls;
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
using HandyControl.Tools.Extension;

namespace TechMarket_Management.View.UserControls
{
    /// <summary>
    /// Interaction logic for UCSignUp.xaml
    /// </summary>
    public partial class UCSignUp : UserControl
    {
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            if (cbRole.Text == "Seller")
            {
                Dialog.Show(new UCSignUpForSeller());

            }
            else
            {
                fHome.Show();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbRole.Text == "Seller")
            {
                HandyControl.Controls.MessageBox.Show("Seller");
            }

        }
    }
}
