using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogos_BI_Fase_I.ObjetosBD
{
    public class d_Deudor_Acredor_operadora : INotifyPropertyChanged
    {
        String _aux_auxiliar;
        public String aux_auxiliar
        {
            get
            {
                return _aux_auxiliar;
            }
            set
            {
                _aux_auxiliar = value;
                this.OnPropertyChanged("aux_auxiliar");
            }
        }
        String _aux_desc;
        public String aux_desc
        {
            get
            {
                return _aux_desc;
            }
            set
            {
                _aux_desc = value;
                this.OnPropertyChanged("aux_desc");
            }
        }
        String _aux_estado;
        public String aux_estado
        {
            get
            {
                return _aux_estado;
            }
            set
            {
                _aux_estado = value;
                this.OnPropertyChanged("aux_estado");
            }
        }
        String _aux_desc_2;
        public String aux_desc_2
        {
            get
            {
                return _aux_desc_2;
            }
            set
            {
                _aux_desc_2 = value;
                this.OnPropertyChanged("aux_desc_2");
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
