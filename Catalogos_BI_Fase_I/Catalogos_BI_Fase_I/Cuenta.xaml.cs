using Catalogos_BI_Fase_I.Conexion;
using Catalogos_BI_Fase_I.ObjetosBD;
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

namespace Catalogos_BI_Fase_I
{
    /// <summary>
    /// Lógica de interacción para Cuenta.xaml
    /// </summary>
    public partial class Cuenta : Window
    {

        Com_BD.ConsultaSQLCatMay consSql = new Com_BD.ConsultaSQLCatMay();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        Int32 TipoCuenta;
        Cuentas cuentaSeleccionada;
        ModificaInsertaCtaMay WinCaller;
        public Cuentas CuentaSeleccionada 
        {
            get
            {
                return cuentaSeleccionada;
            } 
        }
        public Cuenta(Int32 tipoCuenta, Window winCaller)
        {
            InitializeComponent();
            WinCaller = (ModificaInsertaCtaMay)winCaller;
            TipoCuenta = tipoCuenta;
            cuentaSeleccionada = new Cuentas();
            cargaGpoBalance();
        }
        #region Metodos

        private void cargaGpoBalance()
        {
            Cuentas cuentaPadre = new Cuentas();
            ObservableCollection<Cuentas> _Cuenta1 = null;
            cuentaPadre.IdCuenta = "0";
            cuentaPadre.NombreCuenta = "Cuentas";
            cuentaPadre.NivelCuenta = 0;
            cuentaPadre.IsExpanded = true;
            switch (TipoCuenta)
            {
                case 0: _Cuenta1 = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_Balance(cuentaPadre.IdCuenta, cuentaPadre.NivelCuenta), funGlb.conexion());
                    break;
                case 1: _Cuenta1 = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_EdoRes_Trad(cuentaPadre.IdCuenta, cuentaPadre.NivelCuenta), funGlb.conexion());
                    break;
                case 2: _Cuenta1 = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_BO(cuentaPadre.IdCuenta, cuentaPadre.NivelCuenta), funGlb.conexion());
                    break;
            }
            
            cuentaPadre.Children = _Cuenta1;
            trvCuentas.Items.Clear();
            trvCuentas.Items.Add(cuentaPadre);

        }
        #endregion

        #region Eventos
        private void trvCuentas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            cuentaSeleccionada = (Cuentas)trvCuentas.SelectedItem;
            switch (TipoCuenta)
            {
                case 0: cuentaSeleccionada.Children = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_Balance(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion());
                    break;
                case 1: cuentaSeleccionada.Children = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_EdoRes_Trad(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion());
                    break;
                case 2: cuentaSeleccionada.Children = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_BO(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion());
                    break;
            }
            //cuentaSeleccionada.Children = FuncionesGenericas<Cuentas>.Select(consSql.selectCuentasID_Balance(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion());
            trvCuentas.Items.Refresh(); 
        }

        private void trvCuentas_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            cuentaSeleccionada = (Cuentas)trvCuentas.SelectedItem;
        }

        private void Seleccionar_Click(object sender, RoutedEventArgs e)
        {
            cuentaSeleccionada = (Cuentas)trvCuentas.SelectedItem;
            this.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            cargaGpoBalance();
        }
        #endregion

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!cuentaSeleccionada.Equals(null))
            {
                WinCaller.cuentaSeleccione(cuentaSeleccionada);
            }
        }


    }
}
