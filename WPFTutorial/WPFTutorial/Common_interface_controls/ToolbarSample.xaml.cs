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
using System.Windows.Shapes;

namespace WPFTutorial.Common_interface_controls
{
    /// <summary>
    /// Lógica de interacción para ToolbarSample.xaml
    /// </summary>
    public partial class ToolbarSample : Window
    {
        public ToolbarSample()
        {
            InitializeComponent();
        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}