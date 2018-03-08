using Catalogos_BI_Fase_I.Conexion;
using Catalogos_BI_Fase_I.ObjetosBD;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para NuevaModifica41501.xaml
    /// </summary>
    public partial class NuevaModifica41501 : Window
    {
        Cls_DWD_Criterio_EdoResultados_41501 _nuevoModificaCri;
        public Cls_DWD_Criterio_EdoResultados_41501 nuevoModificaCri 
        {
            get { return _nuevoModificaCri; } 
            set { _nuevoModificaCri = value;} 
        }
        
        Cls_DWD_Criterio_EdoResultados_41501  _regModificaCri;
        public Cls_DWD_Criterio_EdoResultados_41501 regModificaCri
        {
            get { return _regModificaCri; }
        }
        Com_BD.ConsultaSQL consSql = new Com_BD.ConsultaSQL();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        Boolean bVengoModificar = true;
        #region Constructores
        public NuevaModifica41501()
        {
            InitializeComponent();
            nuevoModificaCri = new Cls_DWD_Criterio_EdoResultados_41501();
            this.DataContext = nuevoModificaCri;
            bVengoModificar = false;
        }
        public NuevaModifica41501(object itemSeleccionado)
        {
            InitializeComponent();
            _regModificaCri = (Cls_DWD_Criterio_EdoResultados_41501)itemSeleccionado;
            _nuevoModificaCri = new Cls_DWD_Criterio_EdoResultados_41501();
            _nuevoModificaCri.gcta_id_8_ini = _regModificaCri.gcta_id_8_ini;
            _nuevoModificaCri.gcta_id_9_fin = _regModificaCri.gcta_id_9_fin;
            _nuevoModificaCri.Signo_importe = _regModificaCri.Signo_importe;
            _nuevoModificaCri.Rubro_5_Afecta = _regModificaCri.Rubro_5_Afecta;

            this.DataContext = nuevoModificaCri;
            bVengoModificar = true;
            
        }
        #endregion

        private void modificar41501()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(nuevoModificaCri)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.updateEdoResultados_41501(nuevoModificaCri, regModificaCri), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El criterio fue insertado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }
        private void creaNuevoEdoResultados_41501()
        {
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                camposOmitir[0] = "Signo_importe_cad";
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(nuevoModificaCri)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<Cls_DWD_Criterio_EdoResultados_41501>.Insert(nuevoModificaCri, "DWD_Criterio_EdoResultados_41501", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El criterio fue insertado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }
        private void limpiarDatos()
        {
            txt_gcta_id_8_ini.Text = String.Empty;
            txt_gcta_id_9_fin.Text = String.Empty;
            cmbSigno_importe.SelectedItem = 0;
            txt_Rubro_5_Afecta.Text = String.Empty;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarDatos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (bVengoModificar)
            {
                modificar41501();
            }else creaNuevoEdoResultados_41501();
        }
    }
}
