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

namespace WPFTutorial
{
    /// <summary>
    /// Lógica de interacción para ToolTipsAdvancedSample.xaml
    /// </summary>
    public partial class ToolTipsAdvancedSample : Window
    {
        public ToolTipsAdvancedSample()
        {
            InitializeComponent();
        }

        private void whenToolTipCloses(object sender, ToolTipEventArgs e)
        {
            tbEjemploToolTip.Text = "Se cerró el toolTip";
        }

        private void whenToolTipOpens(object sender, ToolTipEventArgs e)
        {
            tbEjemploToolTip.Text = "Se abrió el toolTip";
        }
    }
}
