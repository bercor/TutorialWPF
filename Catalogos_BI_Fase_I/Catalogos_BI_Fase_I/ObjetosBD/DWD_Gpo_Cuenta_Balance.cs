﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Catalogos_BI_Fase_I.ObjetosBD
{

    public class DWD_Gpo_Cuenta_Balance : INotifyPropertyChanged
    {

        private string _gcta_id_1;

        public string gcta_id_1
        {
            get
            {
                return _gcta_id_1;
            }
            set
            {
                _gcta_id_1 = value;
                this.OnPropertyChanged("gcta_id_1");
            }
        }

        private string _gcta_nombre_1;

        public string gcta_nombre_1
        {
            get
            {
                return _gcta_nombre_1;
            }
            set
            {
                _gcta_nombre_1 = value;
                this.OnPropertyChanged("gcta_nombre_1");
            }
        }

        private string _gcta_id_2;

        public string gcta_id_2
        {
            get
            {
                return _gcta_id_2;
            }
            set
            {
                _gcta_id_2 = value;
                this.OnPropertyChanged("gcta_id_2");
            }
        }

        private string _gcta_nombre_2;

        public string gcta_nombre_2
        {
            get
            {
                return _gcta_nombre_2;
            }
            set
            {
                _gcta_nombre_2 = value;
                this.OnPropertyChanged("gcta_nombre_2");
            }
        }

        private string _gcta_id_3;

        public string gcta_id_3
        {
            get
            {
                return _gcta_id_3;
            }
            set
            {
                _gcta_id_3 = value;
                this.OnPropertyChanged("gcta_id_3");
            }
        }

        private string _gcta_nombre_3;

        public string gcta_nombre_3
        {
            get
            {
                return _gcta_nombre_3;
            }
            set
            {
                _gcta_nombre_3 = value;
                this.OnPropertyChanged("gcta_nombre_3");
            }
        }

        private string _gcta_id_4;

        public string gcta_id_4
        {
            get
            {
                return _gcta_id_4;
            }
            set
            {
                _gcta_id_4 = value;
                this.OnPropertyChanged("gcta_id_4");
            }
        }

        private string _gcta_nombre_4;

        public string gcta_nombre_4
        {
            get
            {
                return _gcta_nombre_4;
            }
            set
            {
                _gcta_nombre_4 = value;
                this.OnPropertyChanged("gcta_nombre_4");
            }
        }

        private string _gcta_id_5;

        public string gcta_id_5
        {
            get
            {
                return _gcta_id_5;
            }
            set
            {
                _gcta_id_5 = value;
                this.OnPropertyChanged("gcta_id_5");
            }
        }

        private string _gcta_nombre_5;

        public string gcta_nombre_5
        {
            get
            {
                return _gcta_nombre_5;
            }
            set
            {
                _gcta_nombre_5 = value;
                this.OnPropertyChanged("gcta_nombre_5");
            }
        }

        private string _gcta_id_6;

        public string gcta_id_6
        {
            get
            {
                return _gcta_id_6;
            }
            set
            {
                _gcta_id_6 = value;
                this.OnPropertyChanged("gcta_id_6");
            }
        }

        private string _gcta_nombre_6;

        public string gcta_nombre_6
        {
            get
            {
                return _gcta_nombre_6;
            }
            set
            {
                _gcta_nombre_6 = value;
                this.OnPropertyChanged("gcta_nombre_6");
            }
        }

        private string _gcta_id_7;

        public string gcta_id_7
        {
            get
            {
                return _gcta_id_7;
            }
            set
            {
                _gcta_id_7 = value;
                this.OnPropertyChanged("gcta_id_7");
            }
        }

        private string _In_cat_utilidad;

        public string In_cat_utilidad
        {
            get
            {
                return _In_cat_utilidad;
            }
            set
            {
                _In_cat_utilidad = value;
               this.OnPropertyChanged("In_cat_utilidad");
            }
        }

        private string _Ident_Migra_Pasivo;

        public string Ident_Migra_Pasivo
        {
            get
            {
                return _Ident_Migra_Pasivo;
            }
            set
            {
                _Ident_Migra_Pasivo = value;
                this.OnPropertyChanged("Ident_Migra_Pasivo");
            }
        }

        private string _gcta_nombre_7;

        public string gcta_nombre_7
        {
            get
            {
                return _gcta_nombre_7;
            }
            set
            {
                _gcta_nombre_7 = value;
                this.OnPropertyChanged("gcta_nombre_7");
            }
        }

        

        public const string NombreTabla = "DWD_Gpo_Cuenta_Balance";

        public DWD_Gpo_Cuenta_Balance()
        {
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
