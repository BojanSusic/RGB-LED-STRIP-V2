﻿using System;
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

namespace RGB_LED_STRIP_V2
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

        private void Slider_StylusLeave(object sender, StylusEventArgs e)
        {

        }

       

        private void BUT_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        

        

        

        private void BUT_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }
    }
}
