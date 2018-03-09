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

namespace WPFTutorial.Common_interface_controls
{
    /// <summary>
    /// Lógica de interacción para MenuIconCheckableSample.xaml
    /// </summary>
    public partial class MenuIconCheckableSample : Window
    {
        public MenuIconCheckableSample()
        {
            InitializeComponent();
        }
        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New");
        }
    }
}
