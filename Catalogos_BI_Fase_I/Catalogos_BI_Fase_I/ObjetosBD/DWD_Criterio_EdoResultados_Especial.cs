using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogos_BI_Fase_I.ObjetosBD
{
    public class DWD_Criterio_EdoResultados_Especial : INotifyPropertyChanged
    {
        String _Rubro_01;
        public String  Rubro_01 
        { 
            get
            {
            return _Rubro_01;
            } 
            set
            {
                _Rubro_01= value;
                this.OnPropertyChanged("Rubro_01");
            } 
        }
        String _Rubro_03;
        public String  Rubro_03 
        { 
            get
            {
            return _Rubro_03;
            } 
            set
            {
                _Rubro_03= value;
                this.OnPropertyChanged("Rubro_03");
            } 
        }
        String _Contrato;
        public String  Contrato 
        { 
            get
            {
            return _Contrato;
            } 
            set
            {
                _Contrato= value;
                this.OnPropertyChanged("Contrato");
            } 
        }
        String _gcta_id_8_fin;
        public String  gcta_id_8_fin 
        { 
            get
            {
            return _gcta_id_8_fin;
            } 
            set
            {
                _gcta_id_8_fin= value;
                this.OnPropertyChanged("gcta_id_8_fin");
            } 
        }
        String _gcta_id_8_ini;
        public String gcta_id_8_ini 
        { 
            get
            {
                return _gcta_id_8_ini;
            } 
            set
            {
                _gcta_id_8_ini = value;
                this.OnPropertyChanged("gcta_id_8_ini");
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
