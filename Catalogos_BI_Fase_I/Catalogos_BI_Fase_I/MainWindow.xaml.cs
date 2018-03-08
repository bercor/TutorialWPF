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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Catalogos_BI_Fase_I.Validaciones;
using System.Data;

namespace Catalogos_BI_Fase_I
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Cls_DWD_Criterio_EdoResultados_41501> _EdoResultados_41501;
        private ObservableCollection<DWD_Criterio_EdoResultados_Especial> _EdoResultados_Esp;
        private ObservableCollection<DWD_Emp_Reporte_Utilidades> _RepUtilidades;
        private ObservableCollection<d_Deudor_Acredor_operadora> _DeudorAcredor_Operadora;
        Com_BD.ConsultaSQL consSql = new Com_BD.ConsultaSQL();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        public MainWindow()
        {
            InitializeComponent();
            cargarGridEdoRes41501();
            cargarGridEdoResEsp();
            cargarGridRepUtilidad();
            OpeAcree.IsChecked = true;
            cargarGridOperadoraAcreDeu();
        }

        private void rbAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if(validarContenido())
            switch (tabControl.SelectedIndex)
            {
                case 0: creaNuevoEdoResultados_41501();
                    break;
                case 1: creaNuevoEdoResultados_Especial();
                    break;
                case 2: creaNuevoReporte_utilidades();
                    break;
                case 3: creaNuevaOperadoraAcreDeudor();
                    break;
            }
        }

        private Boolean validarContenido()
        {
            Boolean todoOk = true;
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_8_ini.Text))
	                {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_8_ini.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_8_ini", (int)NivelesError.Error);
                            Validation.MarkInvalid(txt_gcta_id_8_ini.GetBindingExpression(TextBox.TextProperty), validationError);
                            todoOk = false;
	                }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_9_fin.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_9_fin.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_9_fin", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_9_fin.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_Rubro_5_Afecta.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Rubro_5_Afecta.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Rubro_5_Afecta", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Rubro_5_Afecta.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
                case 1:
                    if (String.IsNullOrWhiteSpace(txt_Rubro_01.Text))
	                {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Rubro_01.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Rubro_01", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Rubro_01.GetBindingExpression(TextBox.TextProperty), validationError);
                            todoOk = false;
	                }
                    if (String.IsNullOrWhiteSpace(txt_Rubro_03.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Rubro_03.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Rubro_03", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Rubro_03.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_Contrato.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Contrato.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Contrato", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Contrato.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_8_fin.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_8_fin.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_8_fin", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_8_fin.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_8_iniEsp.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_8_iniEsp.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_8_ini", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_8_iniEsp.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
                case 2:
                    if (String.IsNullOrWhiteSpace(txt_Usuario_ID.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Usuario_ID.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Usuario_ID", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Usuario_ID.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_8.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_8.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_8", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_8.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_Rubro.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Rubro.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Rubro", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Rubro.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
                case 3:
                    if (String.IsNullOrWhiteSpace(txt_aux_auxiliar.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_aux_auxiliar.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso aux_auxiliar", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_aux_auxiliar.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_aux_desc.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_aux_desc.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso aux_desc", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_aux_desc.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_aux_estado.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_aux_estado.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso aux_estado", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_aux_estado.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_aux_desc_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_aux_desc_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso aux_desc_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_aux_desc_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
            }
            return todoOk;
        }
        private void limpiarDatos()
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: txt_gcta_id_8_ini.Text = String.Empty;
                        txt_gcta_id_9_fin.Text = String.Empty;
                        cmbSigno_importe.SelectedItem = 0;
                        txt_Rubro_5_Afecta.Text = String.Empty;
                    break;
                case 1:
                        txt_Rubro_01.Text= String.Empty;
                        txt_Rubro_03.Text= String.Empty;
                        txt_Contrato.Text= String.Empty;
                        txt_gcta_id_8_fin.Text = String.Empty;
                        txt_gcta_id_8_iniEsp.Text = String.Empty;
                    break;
                case 2:
                        txt_Usuario_ID.Text = String.Empty;
                        txt_gcta_id_8.Text = String.Empty;
                        txt_Rubro.Text = String.Empty;
                    break;
                case 3: txt_aux_auxiliar.Text = String.Empty;
                        txt_aux_desc.Text = String.Empty;
                        txt_aux_estado.Text = String.Empty;
                        txt_aux_desc_2.Text = String.Empty;
                    break;
            }
        }

        private void creaNuevoEdoResultados_41501()
        {
            Cls_DWD_Criterio_EdoResultados_41501 nuevo = new Cls_DWD_Criterio_EdoResultados_41501();
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            nuevo.gcta_id_8_ini = txt_gcta_id_8_ini.Text;
            nuevo.gcta_id_9_fin = txt_gcta_id_9_fin.Text;
            if (cmbSigno_importe.Text.Equals("Positivo"))
            {
                nuevo.Signo_importe = 1;
            }
            else nuevo.Signo_importe = -1;
            
            nuevo.Rubro_5_Afecta = txt_Rubro_5_Afecta.Text;
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(nuevo))> 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<Cls_DWD_Criterio_EdoResultados_41501>.Insert(nuevo, "DWD_Criterio_EdoResultados_41501", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas>0)
                {
                    MessageBox.Show("El criterio fue insertado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    cargarGridEdoRes41501();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message , "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                
            }
            
        }
        private void creaNuevoEdoResultados_Especial()
        {
            DWD_Criterio_EdoResultados_Especial nuevo = new DWD_Criterio_EdoResultados_Especial();
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            nuevo.Rubro_01 = txt_Rubro_01.Text;
            nuevo.Rubro_03 = txt_Rubro_03.Text;
            nuevo.Contrato = txt_Contrato.Text;
            nuevo.gcta_id_8_fin = txt_gcta_id_8_fin.Text;
            nuevo.gcta_id_8_ini = txt_gcta_id_8_iniEsp.Text;
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_Especial(nuevo)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<DWD_Criterio_EdoResultados_Especial>.Insert(nuevo, "DWD_Criterio_EdoResultados_Especial", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El criterio fue insertado correctamente.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    cargarGridEdoResEsp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }

        private void creaNuevoReporte_utilidades()
        {
            DWD_Emp_Reporte_Utilidades nuevo = new DWD_Emp_Reporte_Utilidades();
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            nuevo.Usuario_ID = txt_Usuario_ID.Text;
            nuevo.gcta_id_8 = txt_gcta_id_8.Text;
            nuevo.Rubro = txt_Rubro.Text;
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegReporte_Utilidades(nuevo)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<DWD_Emp_Reporte_Utilidades>.Insert(nuevo, "DWD_Emp_Reporte_Utilidades", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    cargarGridRepUtilidad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }

        private void creaNuevaOperadoraAcreDeudor()
        {
            d_Deudor_Acredor_operadora nuevo = new d_Deudor_Acredor_operadora();
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            string nomTabla = String.Empty;
            nuevo.aux_auxiliar = txt_aux_auxiliar.Text;
            nuevo.aux_desc = txt_aux_desc.Text;
            nuevo.aux_estado = txt_aux_estado.Text;
            nuevo.aux_desc_2 = txt_aux_desc_2.Text;
            if ((bool)OpeAcree.IsChecked)
            {
                nomTabla = "d_acreedor_operadora";
            }
            else
            {
                nomTabla = "d_deudor_operadora";
            }
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegAcredorDeudor(nomTabla, nuevo)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<d_Deudor_Acredor_operadora>.Insert(nuevo, nomTabla, camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    cargarGridOperadoraAcreDeu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }

        private void cargarGridEdoRes41501()
        {
            _EdoResultados_41501 = FuncionesGenericas<Cls_DWD_Criterio_EdoResultados_41501>.Select(consSql.selectEdoResultados_41501(), funGlb.conexion());
            grd_EdoResultados_41501.ItemsSource = _EdoResultados_41501;
        }

        private void cargarGridEdoResEsp()
        {
            _EdoResultados_Esp = FuncionesGenericas<DWD_Criterio_EdoResultados_Especial>.Select(consSql.selectEdoResultados_Especial(), funGlb.conexion());
            grd_EdoResultados_Especial.ItemsSource = _EdoResultados_Esp;
        }
        private void cargarGridRepUtilidad()
        {
            _RepUtilidades = FuncionesGenericas<DWD_Emp_Reporte_Utilidades>.Select(consSql.selectReporte_Utilidades(), funGlb.conexion());
            grd_Reporte_Utilidades.ItemsSource = _RepUtilidades;
        }
        private void cargarGridOperadoraAcreDeu()
        {
            if ((bool)OpeAcree.IsChecked)
            {
                _DeudorAcredor_Operadora = FuncionesGenericas<d_Deudor_Acredor_operadora>.Select(consSql.selectAcredorDeudor("d_acreedor_operadora"), funGlb.conexion());
            }
            else 
            {
                _DeudorAcredor_Operadora = FuncionesGenericas<d_Deudor_Acredor_operadora>.Select(consSql.selectAcredorDeudor("d_deudor_operadora"), funGlb.conexion());
            }
            grd_Acredor_Deudor.ItemsSource = _DeudorAcredor_Operadora;
            
        }
        private void rbEliminar_Click(object sender, RoutedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: eliminarCriterioEdoResultados_41501();
                    break;
                case 1: eliminarCriterioEdoResultados_Especial();
                    break;
                case 2: eliminarRepUtilidades ();
                    break;
                case 3: eliminarOpeAcredorDeudor();
                    break;
            }
        }

        private void eliminarCriterioEdoResultados_41501()
        {
            int index = 0;
            Cls_DWD_Criterio_EdoResultados_41501 rowSelected;
            if (!grd_EdoResultados_41501.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_EdoResultados_41501.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (Cls_DWD_Criterio_EdoResultados_41501)grd_EdoResultados_41501.SelectedItem;
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
            if (!grd_EdoResultados_Especial.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_EdoResultados_Especial.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            try
            {
                rowSelected = (DWD_Criterio_EdoResultados_Especial)grd_EdoResultados_Especial.SelectedItem;
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
            if (!grd_Reporte_Utilidades.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_Reporte_Utilidades.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (DWD_Emp_Reporte_Utilidades)grd_Reporte_Utilidades.SelectedItem;
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
            if ((bool)OpeAcree.IsChecked)
            {
                nomTabla = "d_acreedor_operadora";
            }
            else
            {
                nomTabla = "d_deudor_operadora";
            }
            if (!grd_Acredor_Deudor.HasItems)
            {
                MessageBox.Show("El grid está vacío, por lo que no hay ítem por eliminar.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }
            index = grd_Acredor_Deudor.SelectedIndex;
            if (index.Equals(-1) || index < 0)
            {
                MessageBox.Show("Hubo un error al leer el ítem seleccionado.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            rowSelected = (d_Deudor_Acredor_operadora )grd_Acredor_Deudor.SelectedItem;
            if (funGlb.ExistenRegistros(consSql.regresaNumRegAcredorDeudor(nomTabla, rowSelected)) < 1)
            {
                MessageBox.Show("El registro no exíste en la BD.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                return;
            }

            if (FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.eliminarAcredorDeudor(nomTabla, rowSelected.aux_auxiliar,
                rowSelected.aux_desc, rowSelected.aux_estado, rowSelected.aux_desc_2), funGlb.conexion(), String.Empty) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente.", "Operadoras", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                cargarGridOperadoraAcreDeu();
            }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: cargarGridEdoRes41501();
                    break;
                case 1: cargarGridEdoResEsp();
                    break;
                case 2: cargarGridRepUtilidad();
                    break;
                case 3: OpeAcree.IsChecked = true;
                    cargarGridOperadoraAcreDeu();
                    break;
            }
            
            
            
        }

        private void OpeAcree_Checked(object sender, RoutedEventArgs e)
        {
            cargarGridOperadoraAcreDeu();
        }

        private void OpeDeu_Checked(object sender, RoutedEventArgs e)
        {
            cargarGridOperadoraAcreDeu();
        }
    }
}
