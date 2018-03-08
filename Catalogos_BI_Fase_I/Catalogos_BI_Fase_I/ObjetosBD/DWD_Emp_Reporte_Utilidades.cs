using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogos_BI_Fase_I.ObjetosBD
{
    public class DWD_Emp_Reporte_Utilidades : INotifyPropertyChanged
    {
        String _Usuario_ID;
        public String Usuario_ID
        {
            get
            {
                return _Usuario_ID;
            }
            set
            {
                _Usuario_ID = value;
                this.OnPropertyChanged("Usuario_ID");
            }
        }
        String _gcta_id_8;
        public String gcta_id_8
        {
            get
            {
                return _gcta_id_8;
            }
            set
            {
                _gcta_id_8 = value;
                this.OnPropertyChanged("gcta_id_8");
            }
        }
        String _Rubro;
        public String Rubro
        {
            get
            {
                return _Rubro;
            }
            set
            {
                _Rubro = value;
                this.OnPropertyChanged("Rubro");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
