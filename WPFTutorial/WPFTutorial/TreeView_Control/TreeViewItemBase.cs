using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial.TreeView_Control
{
    public class TreeViewItemBase1 : INotifyPropertyChanged
    {
        public string texto { get; set; }
        public string Imagen { get; set; }
        public string Control { get; set; }
        public bool IsEnabled { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
