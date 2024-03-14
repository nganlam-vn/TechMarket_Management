using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TechMarket_Management;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HandyControl.Tools;
using System.Globalization;



namespace TechMarket_Management.View.UserControls.UCSeller
{
     
    public partial class UCSignUpForSeller : UserControl
    {
        
     

        public UCSignUpForSeller()
        {
            // Define global culture information for reliable double conversions
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            // Set default handy control language to english
            ConfigHelper.Instance.SetLang("en");
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign Up Successfully");
            this.Visibility = Visibility.Hidden;
            //FHome fHome = (FHome)Window.GetWindow(this);
            //fHome.Close();
            FLogin fLogin = new FLogin();
            fLogin.Show();
           
        }
    }
}
