using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Catalogos_BI_Fase_I.ObjetosBD
{
    public class Cls_DWD_Criterio_EdoResultados_41501 : INotifyPropertyChanged
    {
        private String _id_8_ini;
        public String gcta_id_8_ini 
        {
            get
            {
                return _id_8_ini;
            }
            set
            {
                _id_8_ini = value;
                this.OnPropertyChanged("Id_8_ini");
            }
        }

        private String _id_9_fin;
        public String gcta_id_9_fin
        {
            get
            {
                return _id_9_fin;
            }
            set
            {
                _id_9_fin = value;
                this.OnPropertyChanged("Id_9_fin");
            }
        }

        private Int32 _Signo_importe;
        public Int32 Signo_importe
        {
            get
            {
                return _Signo_importe;
            }
            set
            {
                _Signo_importe = value;
                if (_Signo_importe.Equals(1))
                {
                    _Signo_importe_cad = "Positivo";
                } else _Signo_importe_cad ="Negativo";
                this.OnPropertyChanged("Signo_importe");
            }
        }

        private String _Signo_importe_cad;
        public String Signo_importe_cad
        {
            get
            {
                return _Signo_importe_cad;
            }
            set
            {
                _Signo_importe_cad = value;
                if (_Signo_importe_cad.Equals("Positivo"))
                {
                    _Signo_importe = 1;
                }
                else _Signo_importe = -1;
                this.OnPropertyChanged("Signo_importe");
                this.OnPropertyChanged("Signo_importe_cad");
            }
        }
        private String _Rubro_5_Afecta;
        public String Rubro_5_Afecta
        {
            get
            {
                return _Rubro_5_Afecta;
            }
            set
            {
                _Rubro_5_Afecta = value;
                this.OnPropertyChanged("Rubro_5_Afecta");
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
