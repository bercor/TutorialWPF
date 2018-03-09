using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para TreeViewDataBindingSample.xaml
    /// </summary>
    public partial class TreeViewDataBindingSample : Window
    {
         public TreeViewDataBindingSample()
                {
                        InitializeComponent();
                        MenuItem root = new MenuItem() { Title = "Menu" };
                        MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
                        
                        MenuItem child1Item1 = new MenuItem() { Title = "Child item #1.1" };
                        MenuItem child2Item1 = new MenuItem() { Title = "Child item #1.2" };
                        child1Item1.Items.Add(new MenuItem() { Title = "Child item #1.1.1" });
                        child1Item1.Items.Add(new MenuItem() { Title = "Child item #1.1.2" });
                        childItem1.Items.Add(child1Item1);
                        childItem1.Items.Add(child2Item1);
                        root.Items.Add(childItem1);
                        root.Items.Add(new MenuItem() { Title = "Child item #2" });
                        trvMenu.Items.Add(root);
                }
    }

    public class MenuItem
    {
            public MenuItem()
            {
                    this.Items = new ObservableCollection<MenuItem>();
            }

            public string Title { get; set; }

            public ObservableCollection<MenuItem> Items { get; set; }
    }
    
}
