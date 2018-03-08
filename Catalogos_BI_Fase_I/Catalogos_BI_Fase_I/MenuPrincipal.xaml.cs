using Catalogos_BI_Fase_I.Conexion;
using Catalogos_BI_Fase_I.ObjetosBD;
using DataGridFilterLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        private ObservableCollection<Cls_DWD_Criterio_EdoResultados_41501> _EdoResultados_41501;
        private ObservableCollection<DWD_Criterio_EdoResultados_Especial> _EdoResultados_Esp;
        private ObservableCollection<DWD_Emp_Reporte_Utilidades> _RepUtilidades;
        private ObservableCollection<d_Deudor_Acredor_operadora> _DeudorAcredor_Operadora;
        private ObservableCollection<DWD_Gpo_Cuenta_Balance> _Gpo_Cuenta_Balance;
        private ObservableCollection<DWD_Gpo_Cuenta_EdoResultados_Tradicional> _Gpo_Cuenta_ERT;
        private ObservableCollection<DWD_Gpo_Cuenta_Balance_Operadora> _Gpo_Cuenta_Bal_Ope;
        Com_BD.ConsultaSQL consSql = new Com_BD.ConsultaSQL();
        Com_BD.ConsultaSQLCatMay consSqlMay = new Com_BD.ConsultaSQLCatMay();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        //Style stilo;
        public MenuPrincipal()
        {
            InitializeComponent();
            //stilo = (Style)grd_General.Columns[0].HeaderStyle;
        }

        private void listBContabilidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grd_General.ItemsSource = null;
            grd_General.Visibility = System.Windows.Visibility.Visible;
            switch (listBContabilidad.SelectedIndex)
            {
                case 0: cargarGridEdoRes41501();
                    break;
                case 1: cargarGridEdoResEsp();
                    break;
                case 2: cargarGridRepUtilidad();
                    break;
                case 3: cargarGridOperadoraAcredor(); 
                    break;
                case 4: cargarGridOperadoraDeudor();
                    break;
                case 5: cargarGridGpo_Cuenta_Balance();
                    break;
                case 6: cargarGridGpo_Cuenta_ERT();
                    break;
                case 7: cargarGridGpo_Cuenta_Bal_Op();
                    break;
                default: grd_General.Visibility = System.Windows.Visibility.Hidden;
                    break;
            }
        }
        #region CargarGrid
        private void cargarGridEdoRes41501()
        {
            
            _EdoResultados_41501 = FuncionesGenericas<Cls_DWD_Criterio_EdoResultados_41501>.Select(consSql.selectEdoResultados_41501(), funGlb.conexion());
            grd_General.ItemsSource = _EdoResultados_41501;
            grd_General.Columns[3].Header = "Signo__importe";
            //var style = new Style(typeof(System.Windows.Controls.Primitives
            //.DataGridColumnHeader));
            //var style2 = new DataGridHeaderFilterControl();
            //    //new ComponentResourceKey(Type.FilterName(new DataGridHeaderFilterControl(),Type.GetTypeFromHandle ), new DataGridHeaderFilterControlStyle());
            //style.Setters.Add(new  Setter(ToolTipService.ToolTipProperty
            //    , "Your tool tip here"));
            //style.Setters.Add(new Setter
            //{
            //    Property = BackgroundProperty,
            //    Value
            //        = Brushes.Yellow
            //});
            ////grd_General.Columns[0].Visibility = System.Windows.Visibility.Hidden;//Ver como hacer sin tener que poner esa columna de mas
            //grd_General.Columns[3].HeaderStyle = stilo;
            
            //grd_General.Columns[3].HeaderStyle = ((Style)(TypeDescriptor.GetConverter(typeof(Style)).ConvertFromInvariantString("{StaticResource {ComponentResourceKey TypeInTargetAssembly={x:Type filter:DataGridHeaderFilterControl}, ResourceId=DataGridHeaderFilterControlStyle}}")));
            grd_General.Columns[2].Visibility = System.Windows.Visibility.Hidden;
        }

        private void cargarGridEdoResEsp()
        {
            _EdoResultados_Esp = FuncionesGenericas<DWD_Criterio_EdoResultados_Especial>.Select(consSql.selectEdoResultados_Especial(), funGlb.conexion());
            grd_General.ItemsSource = _EdoResultados_Esp;

        }
        private void cargarGridRepUtilidad()
        {
            _RepUtilidades = FuncionesGenericas<DWD_Emp_Reporte_Utilidades>.Select(consSql.selectReporte_Utilidades(), funGlb.conexion());
            grd_General.ItemsSource = _RepUtilidades;
        }
        private void cargarGridOperadoraAcredor()
        {
            _DeudorAcredor_Operadora = FuncionesGenericas<d_Deudor_Acredor_operadora>.Select(consSql.selectAcredorDeudor("d_acreedor_operadora"), funGlb.conexion());
            grd_General.ItemsSource = _DeudorAcredor_Operadora;
        }
        private void cargarGridOperadoraDeudor()
        {
            _DeudorAcredor_Operadora = FuncionesGenericas<d_Deudor_Acredor_operadora>.Select(consSql.selectAcredorDeudor("d_deudor_operadora"), funGlb.conexion());
            grd_General.ItemsSource = _DeudorAcredor_Operadora;

        }
        private void cargarGridGpo_Cuenta_Balance()
        {
            _Gpo_Cuenta_Balance = FuncionesGenericas<DWD_Gpo_Cuenta_Balance>.Select(consSqlMay.select_Gpo_Cuenta_Balance(), funGlb.conexion());
            grd_General.ItemsSource = _Gpo_Cuenta_Balance;

        }

        private void cargarGridGpo_Cuenta_ERT()
        {
            _Gpo_Cuenta_ERT = FuncionesGenericas<DWD_Gpo_Cuenta_EdoResultados_Tradicional>.Select(consSqlMay.select_Gpo_Cuenta_ERT(), funGlb.conexion());
            grd_General.ItemsSource = _Gpo_Cuenta_ERT;

        }
        private void cargarGridGpo_Cuenta_Bal_Op()
        {
            _Gpo_Cuenta_Bal_Ope = FuncionesGenericas<DWD_Gpo_Cuenta_Balance_Operadora>.Select(consSqlMay.select_Gpo_Cuenta_BO(), funGlb.conexion());
            grd_General.ItemsSource = _Gpo_Cuenta_Bal_Ope;

        }
        #endregion

        private void grd_General_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            modificarSeleccion();
        }


        private void modificarSeleccion()
        {
            int index = 0;
            ModificaInserta mi = null;
            ModificaInsertaCtaMay gc = null;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por modificar.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            switch (listBContabilidad.SelectedIndex)
            {
                case 0: 
                    mi = new ModificaInserta(listBContabilidad.SelectedIndex, (Cls_DWD_Criterio_EdoResultados_41501)grd_General.SelectedItem, true);
                    mi.ShowDialog();
                    cargarGridEdoRes41501();
                    break;
                case 1: mi = new ModificaInserta(listBContabilidad.SelectedIndex, (DWD_Criterio_EdoResultados_Especial)grd_General.SelectedItem, true);
                    mi.ShowDialog();
                    cargarGridEdoResEsp();
                    break;
                case 2: mi = new ModificaInserta(listBContabilidad.SelectedIndex, (DWD_Emp_Reporte_Utilidades)grd_General.SelectedItem, true);
                    mi.ShowDialog();
                    cargarGridRepUtilidad();
                    break;
                case 3: mi = new ModificaInserta(listBContabilidad.SelectedIndex, (d_Deudor_Acredor_operadora)grd_General.SelectedItem, true);
                    mi.ShowDialog();
                    cargarGridOperadoraAcredor();
                    break;
                case 4: mi = new ModificaInserta(listBContabilidad.SelectedIndex, (d_Deudor_Acredor_operadora)grd_General.SelectedItem, true);
                    mi.ShowDialog();
                    cargarGridOperadoraDeudor();
                    break;
                case 5: gc = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, (DWD_Gpo_Cuenta_Balance)grd_General.SelectedItem, true);
                    gc.ShowDialog();
                    cargarGridGpo_Cuenta_Balance();
                    break;
                case 6: gc = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, (DWD_Gpo_Cuenta_EdoResultados_Tradicional)grd_General.SelectedItem, true);
                    gc.ShowDialog();
                    cargarGridGpo_Cuenta_ERT();
                    break;
                case 7: gc = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, (DWD_Gpo_Cuenta_Balance_Operadora)grd_General.SelectedItem, true);
                    gc.ShowDialog();
                    cargarGridGpo_Cuenta_Bal_Op();
                    break;
            }
            

        }

        private void rbNuevo_Click(object sender, RoutedEventArgs e)
        {
            ModificaInserta mi = null;
            ModificaInsertaCtaMay gpo = null;
            switch (listBContabilidad.SelectedIndex )
            {
                case 0: /*NuevaModifica41501 nuevo = new NuevaModifica41501();
                        nuevo.ShowDialog();
                        cargarGridEdoRes41501();*/
                        mi=new ModificaInserta(listBContabilidad.SelectedIndex, new Cls_DWD_Criterio_EdoResultados_41501(), false);
                        mi.ShowDialog();
                        cargarGridEdoRes41501();
                        break;
                case 1: mi = new ModificaInserta(listBContabilidad.SelectedIndex, new DWD_Criterio_EdoResultados_Especial(),false);
                        mi.ShowDialog();
                        cargarGridEdoResEsp();
                        break;
                case 2: mi = new ModificaInserta(listBContabilidad.SelectedIndex, new DWD_Emp_Reporte_Utilidades(), false);
                        mi.ShowDialog();
                        cargarGridRepUtilidad();
                    break;
                case 3: mi = new ModificaInserta(listBContabilidad.SelectedIndex, new d_Deudor_Acredor_operadora(), false);
                        mi.ShowDialog();
                        cargarGridOperadoraAcredor();
                    break;
                case 4: mi = new ModificaInserta(listBContabilidad.SelectedIndex, new d_Deudor_Acredor_operadora(), false);
                        mi.ShowDialog();
                        cargarGridOperadoraDeudor();
                    break;
                case 5: gpo = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, new DWD_Gpo_Cuenta_Balance(), false);
                    gpo.ShowDialog();
                    cargarGridGpo_Cuenta_Balance();
                    break;
                case 6: gpo = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, new DWD_Gpo_Cuenta_EdoResultados_Tradicional(), false);
                    gpo.ShowDialog();
                    cargarGridGpo_Cuenta_ERT();
                    break;
                case 7: gpo = new ModificaInsertaCtaMay(listBContabilidad.SelectedIndex, new DWD_Gpo_Cuenta_Balance_Operadora(), false);
                    gpo.ShowDialog();
                    cargarGridGpo_Cuenta_Bal_Op();
                    break;
            }
            
            
        }

        private void rbEliminar_Click(object sender, RoutedEventArgs e)
        {
            switch (listBContabilidad.SelectedIndex)
            {
                case 0: eliminarCriterioEdoResultados_41501();
                    break;
                case 1: eliminarCriterioEdoResultados_Especial();
                    break;
                case 2: eliminarRepUtilidades();
                    break;
                case 3: 
                case 4: eliminarOpeAcredorDeudor();
                    break;
                case 5: eliminarGpo_CtaBalance();
                    break;
                case 6: eliminarGpo_CtaERT();
                    break;
                case 7: eliminarGpo_Cta_Bal_Op();
                    break;
            }
        }
        #region Metodos eliminar
        private void eliminarCriterioEdoResultados_41501()
        {
            int index = 0;
            Cls_DWD_Criterio_EdoResultados_41501 rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (Cls_DWD_Criterio_EdoResultados_41501)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.eliminarEdoResultados_41501(rowSelected.gcta_id_8_ini,
                    rowSelected.gcta_id_9_fin, rowSelected.Signo_importe, rowSelected.Rubro_5_Afecta), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El criterio fue eliminado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridEdoRes41501();
            }
        }

        private void eliminarCriterioEdoResultados_Especial()
        {
            int index = 0;
            DWD_Criterio_EdoResultados_Especial rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            try
            {
                rowSelected = (DWD_Criterio_EdoResultados_Especial)grd_General.SelectedItem;
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_Especial(rowSelected)) < 1)
                {
                    MessageBox.Show("El registro no exíste en la BD.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }

                if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.eliminarEdoResultados_Especial(rowSelected.Rubro_01,
                    rowSelected.Rubro_03, rowSelected.Contrato, rowSelected.gcta_id_8_fin, rowSelected.gcta_id_8_ini), funGlb.conexion(), String.Empty) > 0)
                {
                    MessageBox.Show("El criterio fue eliminado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    cargarGridEdoResEsp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el registro." + ex.Message, "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
            }

        }
        private void eliminarRepUtilidades()
        {
            int index = 0;
            DWD_Emp_Reporte_Utilidades rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (DWD_Emp_Reporte_Utilidades)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSql.regresaNumRegReporte_Utilidades(rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.eliminarReporte_Utilidades(rowSelected.Usuario_ID,
                rowSelected.gcta_id_8, rowSelected.Rubro), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridRepUtilidad();
            }
        }
        private void eliminarOpeAcredorDeudor()
        {
            int index = 0;
            string nomTabla = String.Empty;
            d_Deudor_Acredor_operadora rowSelected;
            if (listBContabilidad.SelectedIndex.Equals(3))
            {
                nomTabla = "d_acreedor_operadora";
            }
            else
            {
                nomTabla = "d_deudor_operadora";
            }
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (d_Deudor_Acredor_operadora)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSql.regresaNumRegAcredorDeudor(nomTabla, rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.eliminarAcredorDeudor(nomTabla, rowSelected.aux_auxiliar,
                rowSelected.aux_desc, rowSelected.aux_estado, rowSelected.aux_desc_2), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                if (listBContabilidad.SelectedIndex.Equals(3))
                {
                    cargarGridOperadoraAcredor();
                }
                else cargarGridOperadoraDeudor();
                
            }
        }

        private void eliminarGpo_CtaBalance()
        {
            int index = 0;
            DWD_Gpo_Cuenta_Balance rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (DWD_Gpo_Cuenta_Balance)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSqlMay.regresa_NumReg_Gpo_Cuenta_Balance(rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSqlMay.eliminar_Gpo_Cuenta_Balance(rowSelected), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridGpo_Cuenta_Balance();
            }
        }
        private void eliminarGpo_CtaERT()
        {
            int index = 0;
            DWD_Gpo_Cuenta_EdoResultados_Tradicional rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (DWD_Gpo_Cuenta_EdoResultados_Tradicional)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSqlMay.regresa_NumReg_Gpo_ERT(rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSqlMay.eliminar_Gpo_Cuenta_ERT(rowSelected), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridGpo_Cuenta_ERT();
            }
        }
        private void eliminarGpo_Cta_Bal_Op()
        {
            int index = 0;
            DWD_Gpo_Cuenta_Balance_Operadora rowSelected;
            if (!grd_General.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_General.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (DWD_Gpo_Cuenta_Balance_Operadora)grd_General.SelectedItem;
            if (funGlb.ExistenRegistros(consSqlMay.regresa_NumReg_Gpo_Cta_BO(rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSqlMay.eliminar_Gpo_Cuenta_BO(rowSelected), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridGpo_Cuenta_Bal_Op();
            }
        }
        #endregion

        private void rbSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

    }
}
