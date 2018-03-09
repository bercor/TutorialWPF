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

namespace WPFTutorial.TreeView_Control
{
    /// <summary>
    /// Lógica de interacción para TreeViewColeccion.xaml
    /// </summary>
    public partial class TreeViewColeccion : Window
    {
        
        public TreeViewColeccion()
        {
            InitializeComponent();
            List<ListaArbol> items = new List<ListaArbol>();
            ListaArbol i1 = new ListaArbol
            {
                texto = "Archivos",
                Imagen = "/Images/process.png",
                Control = "ControlArchivos",
                IsEnabled = true
            };
            i1.Children.Add(new ListaArbol
            {
                texto = "Archivo1",
                Imagen = "/Images/module.png",
                Control = "ControlArchivos",
                IsEnabled = true
            });
            i1.Children.Add(new ListaArbol
            {
                texto = "Archivo2",
                Imagen = "/Images/module.png",
                Control = "ControlArchivos",
                IsEnabled = true
            });
            ListaArbol i2 = new ListaArbol
            {
                texto = "Consultas",
                Imagen = "/Images/process.png",
                Control = "ControlConsultas",
                IsEnabled = false
            };

            items.Add(i1);
            items.Add(i2);
            this.treeView2.ItemsSource = items;
        }
    }
}
