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
    public partial class ModificaInserta : Window
    {
        int _NumTab;
        public int NumTab 
        {
            get { return _NumTab; }
            set { _NumTab = value; }
        }
        Cls_DWD_Criterio_EdoResultados_41501 _regModificaCri;
        Cls_DWD_Criterio_EdoResultados_41501 _nuevoModificaCri;
        DWD_Criterio_EdoResultados_Especial _regModificaEsp;
        DWD_Criterio_EdoResultados_Especial _nuevoModificaEsp;
        DWD_Emp_Reporte_Utilidades _regModRepUtilidades;
        DWD_Emp_Reporte_Utilidades _nuevoModRepUtilidades;
        d_Deudor_Acredor_operadora _regModOperadora;
        d_Deudor_Acredor_operadora _nuevoModOperadora;
        Com_BD.ConsultaSQL consSql = new Com_BD.ConsultaSQL();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        Boolean bVengoModificar = true;
        Boolean bVengoAcreedor = true;
        enum MyTabs
        {
            Criterio41501 = 0,
            CriterioEspecial = 1,
            RepUtilidad = 2,
            OperadoraAcree= 3
        }
        #region Constructor
        public ModificaInserta(Int32 numTab, object item, Boolean bModifica)
        {
            InitializeComponent();
            bVengoModificar = bModifica;
            NumTab = numTab;
            tab41501.Visibility = System.Windows.Visibility.Hidden;
            TabEspecial.Visibility = System.Windows.Visibility.Hidden;
            tabUtilidades.Visibility = System.Windows.Visibility.Hidden;
            tabOperadora.Visibility = System.Windows.Visibility.Hidden;
            switch (numTab)
            {
                case 0: cargarEdoRes41501(item);
                    break;
                case 1: cargaEdoResultados_Especial(item);
                    break;
                case 2: cargaReporte_Utilidades(item);
                    break;
                case 3: bVengoAcreedor = true;
                    cargaOperadoraAcreDeudor(item);
                    break;
                case 4: bVengoAcreedor = false;
                    cargaOperadoraAcreDeudor(item);
                    break;
            }
        }
        #endregion
        #region Carga  las distintas tabs
        private void cargarEdoRes41501(object item)
        {
            _regModificaCri = (Cls_DWD_Criterio_EdoResultados_41501)item;
            if (bVengoModificar)
            {
                _nuevoModificaCri = new Cls_DWD_Criterio_EdoResultados_41501();
                _nuevoModificaCri.gcta_id_8_ini = _regModificaCri.gcta_id_8_ini;
                _nuevoModificaCri.gcta_id_9_fin = _regModificaCri.gcta_id_9_fin;
                _nuevoModificaCri.Signo_importe = _regModificaCri.Signo_importe;
                _nuevoModificaCri.Rubro_5_Afecta = _regModificaCri.Rubro_5_Afecta;
                this.tab41501.DataContext = _nuevoModificaCri;

            } else this.tab41501.DataContext = _regModificaCri;
            tab41501.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)MyTabs.Criterio41501;
        }

        private void cargaEdoResultados_Especial(object item) 
        {
            _regModificaEsp = (DWD_Criterio_EdoResultados_Especial)item;
            if (bVengoModificar)
            {
                _nuevoModificaEsp = new DWD_Criterio_EdoResultados_Especial();
                _nuevoModificaEsp.gcta_id_8_ini = _regModificaEsp.gcta_id_8_ini;
                _nuevoModificaEsp.gcta_id_8_fin = _regModificaEsp.gcta_id_8_fin;
                _nuevoModificaEsp.Contrato = _regModificaEsp.Contrato;
                _nuevoModificaEsp.Rubro_01 = _regModificaEsp.Rubro_01;
                _nuevoModificaEsp.Rubro_03 = _regModificaEsp.Rubro_03;
                this.TabEspecial.DataContext = _nuevoModificaEsp;

            }
            else this.TabEspecial.DataContext = _regModificaEsp;
            TabEspecial.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)MyTabs.CriterioEspecial;
        }

        private void cargaReporte_Utilidades(object item)
        {
            _regModRepUtilidades = (DWD_Emp_Reporte_Utilidades)item;
            if (bVengoModificar)
            {
                _nuevoModRepUtilidades = new DWD_Emp_Reporte_Utilidades();
                _nuevoModRepUtilidades.Usuario_ID = _regModRepUtilidades.Usuario_ID;
                _nuevoModRepUtilidades.gcta_id_8 = _regModRepUtilidades.gcta_id_8;
                _nuevoModRepUtilidades.Rubro = _regModRepUtilidades.Rubro;
                this.tabUtilidades.DataContext = _nuevoModRepUtilidades;

            }
            else this.tabUtilidades.DataContext = _regModRepUtilidades;
            tabUtilidades.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)MyTabs.RepUtilidad;
        }
        private void cargaOperadoraAcreDeudor(object item)
        {
            _regModOperadora = (d_Deudor_Acredor_operadora)item;
            if (bVengoModificar)
            {
                _nuevoModOperadora = new d_Deudor_Acredor_operadora();
                _nuevoModOperadora.aux_auxiliar = _regModOperadora.aux_auxiliar;
                _nuevoModOperadora.aux_desc = _regModOperadora.aux_desc;
                _nuevoModOperadora.aux_estado = _regModOperadora.aux_estado;
                _nuevoModOperadora.aux_desc_2 = _regModOperadora.aux_desc_2;
                this.tabOperadora.DataContext = _nuevoModOperadora;

            }
            else this.tabOperadora.DataContext = _regModOperadora;
            tabOperadora.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)MyTabs.OperadoraAcree; 
        }
        #endregion
        private void rbAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if(validarContenido())
                if (!bVengoModificar)
                {
                    switch (TabGeneral.SelectedIndex)
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
                else
                {
                    switch (TabGeneral.SelectedIndex)
                    {
                        case 0: modificar41501();
                            break;
                        case 1: modificarEspecial();
                            break;
                        case 2: modificarRepUtilidades();
                            break;
                        case 3: modificarOperadoras();
                            break;
                    }
                }
            
        }
        #region Metodos que crean nuevos objetos
        private void creaNuevoEdoResultados_41501()
        {
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                camposOmitir[0] = "Signo_importe_cad";
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(_regModificaCri)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<Cls_DWD_Criterio_EdoResultados_41501>.Insert(_regModificaCri, "DWD_Criterio_EdoResultados_41501", camposOmitir, false, false, funGlb.conexion(), ref exc);
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
                    this.Close();
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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }

        private void creaNuevaOperadoraAcreDeudor()
        {
            
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            string nomTabla = String.Empty;
            if (bVengoAcreedor)
            {
                nomTabla = "d_acreedor_operadora";
            }
            else
            {
                nomTabla = "d_deudor_operadora";
            }
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegAcredorDeudor(nomTabla, _regModOperadora)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<d_Deudor_Acredor_operadora>.Insert(_regModOperadora, nomTabla, camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "Operadora", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "Operadoras", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
            }

        }
        #endregion
        #region Metodos que modifican objetos
        private void modificar41501()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_41501(_nuevoModificaCri)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.updateEdoResultados_41501(_nuevoModificaCri, _regModificaCri), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El criterio fue modificado correctamente.", "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Criterio_EdoResultados_41501", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }

        private void modificarEspecial()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegEdoResultados_Especial(_nuevoModificaEsp)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.updateEdoResultados_Especial(_nuevoModificaEsp, _regModificaEsp), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El criterio fue modificado correctamente.", "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Criterio_EdoResultados_Especial", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }

        private void modificarRepUtilidades()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegReporte_Utilidades(_nuevoModRepUtilidades)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.updateReporte_Utilidades(_nuevoModRepUtilidades, _regModRepUtilidades), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue modificado correctamente.", "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Emp_Reporte_Utilidades", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }

        private void modificarOperadoras()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            string nombreTabla = String.Empty;
            if (bVengoAcreedor)
            {
                nombreTabla = "d_acreedor_operadora";
            }
            else nombreTabla = "d_deudor_operadora";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresaNumRegAcredorDeudor(nombreTabla, _nuevoModOperadora)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.updateAcredorDeudor(nombreTabla,_nuevoModOperadora, _regModOperadora), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue modificado correctamente.", "Operadora", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }
        #endregion

        /// <summary>
        /// Función que revisa cada uno de los campos por tab seleccionada
        /// </summary>
        /// <returns>Regresa true si todo está bien sino lo contrario </returns>
        private Boolean validarContenido()
        {
            Boolean todoOk = true;
            switch (TabGeneral.SelectedIndex)
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
        #region Acciones limpiar campos
        private void rbLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarDatos();
        }

        /// <summary>
        /// Metodo que limpia todos los campos por tab seleccionada.
        /// </summary>
        private void limpiarDatos()
        {
            switch (TabGeneral.SelectedIndex)
            {
                case 0: txt_gcta_id_8_ini.Text = String.Empty;
                    txt_gcta_id_9_fin.Text = String.Empty;
                    cmbSigno_importe.SelectedItem = 0;
                    txt_Rubro_5_Afecta.Text = String.Empty;
                    break;
                case 1:
                    txt_Rubro_01.Text = String.Empty;
                    txt_Rubro_03.Text = String.Empty;
                    txt_Contrato.Text = String.Empty;
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
        #endregion

        /// <summary>
        /// Evento que cierra la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
