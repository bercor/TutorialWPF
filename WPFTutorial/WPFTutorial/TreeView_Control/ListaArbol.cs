using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial.TreeView_Control
{
    public class ListaArbol : TreeViewItemBase
    {
        public ListaArbol()
        {
            this.Children = new ObservableCollection<ListaArbol>();
        }

        public string texto { get; set; }

        public string Imagen { get; set; }

        public string Control { get; set; }
        public bool IsEnabled { get; set; }

        public ObservableCollection<ListaArbol> Children { get; set; }
    }
}
