﻿using HandyControl.Controls;
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
using TechMarket_Management;

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
            FLogin fLogin = new FLogin();
            fLogin.Show();

        }

        private void UCMenu_Loaded(object sender, RoutedEventArgs e)
        {
            FProduct fProduct = new FProduct();
            fProduct.Show();
        }

        private void BtnDetail_Product_Click(object sender, RoutedEventArgs e)
        {
           FDetail_Product fDetail_Product = new FDetail_Product();
            fDetail_Product.Show();

        }
    }
}
