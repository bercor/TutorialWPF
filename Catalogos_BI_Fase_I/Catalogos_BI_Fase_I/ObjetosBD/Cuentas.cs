using Catalogos_BI_Fase_I.Conexion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogos_BI_Fase_I.ObjetosBD
{
    public class Cuentas : TreeViewItemBase
    {
        Com_BD.ConsultaSQL consSql = new Com_BD.ConsultaSQL();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        public String  IdCuenta { get; set; }
        public String NombreCuenta { get; set; }
        public int NivelCuenta { get; set; }
        public ObservableCollection<Cuentas> Children { get; set; }
        public Cuentas()
        {
            this.Children = new  ObservableCollection<Cuentas>();
        }
    }

    public class TreeViewItemBase : INotifyPropertyChanged
    {
        private bool isSelected;
        public bool IsSelected
        {
            get { return this.isSelected; }
            set
            {
                if (value != this.isSelected)
                {
                    this.isSelected = value;
                    NotifyPropertyChanged("IsSelected");
                }
            }
        }

        private bool isExpanded;
        public bool IsExpanded
        {
            get { return this.isExpanded; }
            set
            {
                if (value != this.isExpanded)
                {
                    this.isExpanded = value;
                    NotifyPropertyChanged("IsExpanded");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
    

}
