﻿using System;
using System.Data;
using System.Data.SQLite;
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
  
namespace WpfApp2
 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

        
    public partial class MainWindow : Window
       
    {
        SqlControl SQL = new SqlControl();


        public MainWindow()
            
        {
         


            InitializeComponent();
        }
       

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            SQL.GetData();
            //this.Datagrid1.ItemsSource = 


        }

    }
}

