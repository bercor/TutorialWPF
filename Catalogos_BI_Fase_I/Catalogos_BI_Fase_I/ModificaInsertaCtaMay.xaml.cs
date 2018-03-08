using Catalogos_BI_Fase_I.Conexion;
using Catalogos_BI_Fase_I.ObjetosBD;
using Catalogos_BI_Fase_I.Validaciones;
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
    /// Lógica de interacción para Gpo_Cuenta_Balance.xaml
    /// </summary>
    public partial class ModificaInsertaCtaMay : Window
    {
        Cuentas cuentaSeleccionada = new Cuentas();
        DWD_Gpo_Cuenta_Balance gpo_Cuenta_Balance;
        DWD_Gpo_Cuenta_Balance _nuevoCtaBal;
        DWD_Gpo_Cuenta_EdoResultados_Tradicional gpo_Cuenta_ERT;
        DWD_Gpo_Cuenta_EdoResultados_Tradicional _nuevoCtaERT;
        DWD_Gpo_Cuenta_Balance_Operadora gpo_Cuenta_BO;
        DWD_Gpo_Cuenta_Balance_Operadora _nuevoCtaBO;

        Com_BD.ConsultaSQLCatMay consSql = new Com_BD.ConsultaSQLCatMay();
        ClsFuncionesGlobales funGlb = new ClsFuncionesGlobales();
        Boolean bVengoModificar = false;
        Int32 _NumTab;
        enum  NumeroTab
        {
            Gpo_Cuenta_Balance = 0,
            Gpo_Cuenta_ERT = 1,
            Gpo_Cuenta_BO = 2
        }
        #region Constructores
        public ModificaInsertaCtaMay()
        {
            InitializeComponent();
        }
        public ModificaInsertaCtaMay(Int32 numMenu, object item, Boolean bModifica)
        {
            InitializeComponent();
            
            bVengoModificar = bModifica;
            tabGpo_Cuenta_Balance.Visibility = System.Windows.Visibility.Hidden;
            tabGpo_Cuenta_EdoRes_Trad.Visibility = System.Windows.Visibility.Hidden;
            tabGpo_Cuenta_Bal_Ope.Visibility = System.Windows.Visibility.Hidden;
            switch (numMenu)
            {
                case 5:
                    _NumTab = (Int32)NumeroTab.Gpo_Cuenta_Balance;
                    cargarGpo_Cuenta_Balance(item);
                    break;
                case 6:
                    _NumTab = (Int32)NumeroTab.Gpo_Cuenta_ERT;
                    cargarGpo_Cuenta_ERT(item);
                    break;
                case 7:
                    _NumTab = (Int32)NumeroTab.Gpo_Cuenta_BO;
                    cargarGpo_Cuenta_BO(item);
                    break;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Inserta un nuevo registro del tipo DWD_Gpo_Cuenta_Balance
        /// </summary>
        private void creaNuevoGpo_Cuenta_Bal()
        {
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_Cuenta_Balance(gpo_Cuenta_Balance)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<DWD_Gpo_Cuenta_Balance>.Insert(gpo_Cuenta_Balance, "DWD_Gpo_Cuenta_Balance", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }
        /// <summary>
        /// Modifica el registro que le haya llegado por el constructor, que es el que se haya seleccionado
        /// en la pantalla de menú de tipo DWD_Gpo_Cuenta_Balance
        /// </summary>
        private void modificarGpo_Cuenta_Balance()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_Cuenta_Balance(_nuevoCtaBal)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.update_Gpo_Cuenta_Balance(_nuevoCtaBal, gpo_Cuenta_Balance), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue modificado correctamente.", "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Gpo_Cuenta_Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }

        /// <summary>
        /// Inserta un nuevo registro de tipo DWD_Gpo_Cuenta_EdoResultados_Tradicional
        /// </summary>
        private void creaNuevoGpo_Cuenta_ERT()
        {
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_ERT(gpo_Cuenta_ERT)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<DWD_Gpo_Cuenta_EdoResultados_Tradicional>.Insert(gpo_Cuenta_ERT, "DWD_Gpo_Cuenta_EdoResultados_Tradicional", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }
        /// <summary>
        /// Modifica el registro que llegó desde el constructor de tipo DWD_Gpo_Cuenta_EdoResultados_Tradicional 
        /// con todos los cambios que haya tenido
        /// </summary>
        private void modificarGpo_Cuenta_ERT()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_ERT(_nuevoCtaERT)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.update_Gpo_Cuenta_ERT(_nuevoCtaERT, gpo_Cuenta_ERT), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue modificado correctamente.", "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Gpo_Cuenta_EdoResultados_Tradicional", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }

        /// <summary>
        /// Inserta un nuevo registro de tipo DWD_Gpo_Cuenta_EdoResultados_Tradicional
        /// </summary>
        private void creaNuevoGpo_Cuenta_BO()
        {
            string[] camposOmitir = new string[1];
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_Cta_BO(gpo_Cuenta_BO)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas<DWD_Gpo_Cuenta_Balance_Operadora>.Insert(gpo_Cuenta_BO, "DWD_Gpo_Cuenta_Balance_Operadora", camposOmitir, false, false, funGlb.conexion(), ref exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue insertado correctamente.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar." + ex.Message, "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }

        }
        /// <summary>
        /// Modifica el registro que llegó desde el constructor de tipo DWD_Gpo_Cuenta_Balance_Operadora 
        /// con todos los cambios que haya tenido
        /// </summary>
        private void modificarGpo_Cuenta_BO()
        {
            int iFilasAfectadas = 0;
            String exc = "";
            try
            {
                if (funGlb.ExistenRegistros(consSql.regresa_NumReg_Gpo_Cta_BO(_nuevoCtaBO)) > 0)
                {
                    MessageBox.Show("El registro ya exíste en la BD.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);
                    return;
                }
                iFilasAfectadas = FuncionesGenericas.EjecutaQueryUpdateDelete(consSql.update_Gpo_Cuenta_BO(_nuevoCtaBO, gpo_Cuenta_BO), funGlb.conexion(), exc);
                if (iFilasAfectadas > 0)
                {
                    MessageBox.Show("El registro fue modificado correctamente.", "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);
                    limpiarDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar." + ex.Message, "DWD_Gpo_Cuenta_Balance_Operadora", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.None);

            }
        }
        /// <summary>
        /// Limpia los campos de cada una de las tabs
        /// </summary>
        private void limpiarDatos()
        {
            switch ((NumeroTab)TabGeneral.SelectedIndex)
            {
                case NumeroTab.Gpo_Cuenta_Balance:
                    if (bVengoModificar)
                    {
                        _nuevoCtaBal = new DWD_Gpo_Cuenta_Balance();
                        this.tabGpo_Cuenta_Balance.DataContext = _nuevoCtaBal;
                    }
                    else
                    {
                        gpo_Cuenta_Balance = new DWD_Gpo_Cuenta_Balance();
                        this.tabGpo_Cuenta_Balance.DataContext = gpo_Cuenta_Balance;
                    }
                    break;
                case NumeroTab.Gpo_Cuenta_ERT:
                    if (bVengoModificar)
                    {
                        _nuevoCtaERT = new DWD_Gpo_Cuenta_EdoResultados_Tradicional();
                        this.tabGpo_Cuenta_EdoRes_Trad.DataContext = _nuevoCtaERT;
                    }
                    else
                    {
                        gpo_Cuenta_ERT = new DWD_Gpo_Cuenta_EdoResultados_Tradicional();
                        this.tabGpo_Cuenta_EdoRes_Trad.DataContext = gpo_Cuenta_ERT;
                    }
                    break;
                case NumeroTab.Gpo_Cuenta_BO :
                    if (bVengoModificar)
                    {
                        _nuevoCtaBO = new DWD_Gpo_Cuenta_Balance_Operadora();
                        this.tabGpo_Cuenta_Bal_Ope.DataContext = _nuevoCtaBO;
                    }
                    else
                    {
                        gpo_Cuenta_BO = new DWD_Gpo_Cuenta_Balance_Operadora();
                        this.tabGpo_Cuenta_Bal_Ope.DataContext = gpo_Cuenta_BO;
                    }
                    break;
            }
        }
        /// <summary>
        /// Función que revisa cada uno de los campos por tab seleccionada
        /// </summary>
        /// <returns>Regresa true si todo está bien sino lo contrario </returns>
        private Boolean validarContenido()
        {
            Boolean todoOk = true;
            switch ((NumeroTab) TabGeneral.SelectedIndex)
            {
                case NumeroTab.Gpo_Cuenta_Balance:
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_6.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_6.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_6", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_6.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_6.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_6.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_6", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_6.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_id_7.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_id_7.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_7", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_id_7.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_nombre_7.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_nombre_7.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_7", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_nombre_7.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_In_cat_utilidad.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_In_cat_utilidad.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso In_cat_utilidad", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_In_cat_utilidad.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_Ident_Migra_Pasivo.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_Ident_Migra_Pasivo.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso Ident_Migra_Pasivo", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_Ident_Migra_Pasivo.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
                case NumeroTab.Gpo_Cuenta_ERT:
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_6.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_6.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_6", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_6.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_6.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_6.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_6", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_6.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_id_9.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_id_9.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_9", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_id_9.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_ERT_nombre_9.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_ERT_nombre_9.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_9", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_ERT_nombre_9.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }

                    
                    break;
                case NumeroTab.Gpo_Cuenta_BO:
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_1.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_1.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_1", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_1.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_2.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_2.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_2", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_2.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_3.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_3.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_3", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_3.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_4.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_4.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_4", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_4.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_5.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_5.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_5", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_5.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_id_8.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_id_8.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_id_8", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_id_8.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    if (String.IsNullOrWhiteSpace(txt_gcta_BO_nombre_8.Text))
                    {
                        ValidationError validationError = new ValidationError(new ValidaCampoEnBlanco(), txt_gcta_BO_nombre_8.GetBindingExpression(TextBox.TextProperty));
                        validationError.ErrorContent = new ObjetoErrorValidacion("No se ingreso gcta_nombre_8", (int)NivelesError.Error);
                        Validation.MarkInvalid(txt_gcta_BO_nombre_8.GetBindingExpression(TextBox.TextProperty), validationError);
                        todoOk = false;
                    }
                    break;
                
            }
            return todoOk;
        }
        #endregion
        #region Eventos
        private void txt_gcta_id_6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cuenta mi = new Cuenta(_NumTab, this);
            //gpo_Cuenta_Balance = new DWD_Gpo_Cuenta_Balance();
            mi.Show();
            
            
        }

        private void rbAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if(validarContenido())
                if (!bVengoModificar)
                {
                    switch ((NumeroTab)TabGeneral.SelectedIndex)
                    {
                        case NumeroTab.Gpo_Cuenta_Balance: creaNuevoGpo_Cuenta_Bal();
                            break;
                        case NumeroTab.Gpo_Cuenta_ERT: creaNuevoGpo_Cuenta_ERT();
                            break;
                        case NumeroTab.Gpo_Cuenta_BO: creaNuevoGpo_Cuenta_BO();
                            break;
                    }
                }
                else
                    switch ((NumeroTab)TabGeneral.SelectedIndex)
                    {
                        case NumeroTab.Gpo_Cuenta_Balance: modificarGpo_Cuenta_Balance();
                            break;
                        case NumeroTab.Gpo_Cuenta_ERT: modificarGpo_Cuenta_ERT();
                            break;
                        case NumeroTab.Gpo_Cuenta_BO: modificarGpo_Cuenta_BO();
                            break;
                    }
        
        }

        private void rbLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarDatos();
        }

        private void rbCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_gcta_ERT_id_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cuenta mi = new Cuenta(_NumTab, this);
            //gpo_Cuenta_ERT = new DWD_Gpo_Cuenta_EdoResultados_Tradicional();
            mi.Show();
        }

        private void txt_gcta_BO_id_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cuenta mi = new Cuenta(_NumTab, this);
            //gpo_Cuenta_BO = new DWD_Gpo_Cuenta_Balance_Operadora();
            mi.Show();
        }
        public void cuentaSeleccione(Cuentas CuentaSeleccionada)
        {
                cuentaSeleccionada = CuentaSeleccionada;
            if (cuentaSeleccionada != null && !cuentaSeleccionada.NivelCuenta.Equals(0))
            {
                switch ((NumeroTab)_NumTab)
                {
                    case NumeroTab.Gpo_Cuenta_Balance:
                        gpo_Cuenta_Balance = FuncionesGenericas<DWD_Gpo_Cuenta_Balance>.Select(consSql.regresaGpo_Cuenta_Balance(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion()).FirstOrDefault();
                        cargarGpo_Cuenta_Balance(gpo_Cuenta_Balance);
                        break;
                    case NumeroTab.Gpo_Cuenta_ERT:
                        gpo_Cuenta_ERT = FuncionesGenericas<DWD_Gpo_Cuenta_EdoResultados_Tradicional>.Select(consSql.regresaGpo_Cuenta_ERT(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion()).FirstOrDefault();
                        cargarGpo_Cuenta_Balance(gpo_Cuenta_Balance);
                        break;
                    case NumeroTab.Gpo_Cuenta_BO:
                        gpo_Cuenta_BO = FuncionesGenericas<DWD_Gpo_Cuenta_Balance_Operadora>.Select(consSql.regresaGpo_Cuenta_BO(cuentaSeleccionada.IdCuenta, cuentaSeleccionada.NivelCuenta), funGlb.conexion()).FirstOrDefault();
                        cargarGpo_Cuenta_BO(gpo_Cuenta_BO);
                        break;
                }
                
            }
        }
        #endregion

        #region Carga Tabs

        private void cargarGpo_Cuenta_Balance(object item)
        {
            gpo_Cuenta_Balance = (DWD_Gpo_Cuenta_Balance)item;
            if (bVengoModificar)
            {
                _nuevoCtaBal = new DWD_Gpo_Cuenta_Balance();
                _nuevoCtaBal.gcta_id_1 = gpo_Cuenta_Balance.gcta_id_1;
                _nuevoCtaBal.gcta_nombre_1 = gpo_Cuenta_Balance.gcta_nombre_1;
                _nuevoCtaBal.gcta_id_2 = gpo_Cuenta_Balance.gcta_id_2;
                _nuevoCtaBal.gcta_nombre_2 = gpo_Cuenta_Balance.gcta_nombre_2;
                _nuevoCtaBal.gcta_id_3 = gpo_Cuenta_Balance.gcta_id_3;
                _nuevoCtaBal.gcta_nombre_3 = gpo_Cuenta_Balance.gcta_nombre_3;
                _nuevoCtaBal.gcta_id_4 = gpo_Cuenta_Balance.gcta_id_4;
                _nuevoCtaBal.gcta_nombre_4 = gpo_Cuenta_Balance.gcta_nombre_4;
                _nuevoCtaBal.gcta_id_5 = gpo_Cuenta_Balance.gcta_id_5;
                _nuevoCtaBal.gcta_nombre_5 = gpo_Cuenta_Balance.gcta_nombre_5;
                _nuevoCtaBal.gcta_id_6 = gpo_Cuenta_Balance.gcta_id_6;
                _nuevoCtaBal.gcta_nombre_6 = gpo_Cuenta_Balance.gcta_nombre_6;
                _nuevoCtaBal.gcta_id_7 = gpo_Cuenta_Balance.gcta_id_7;
                _nuevoCtaBal.gcta_nombre_7 = gpo_Cuenta_Balance.gcta_nombre_7;
                _nuevoCtaBal.In_cat_utilidad = gpo_Cuenta_Balance.In_cat_utilidad;
                _nuevoCtaBal.Ident_Migra_Pasivo = gpo_Cuenta_Balance.Ident_Migra_Pasivo;
                this.tabGpo_Cuenta_Balance.DataContext = _nuevoCtaBal;

            }
            else  this.tabGpo_Cuenta_Balance.DataContext = gpo_Cuenta_Balance;
            tabGpo_Cuenta_Balance.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = 0;
        }
        private void cargarGpo_Cuenta_ERT(object item)
        {
            gpo_Cuenta_ERT = (DWD_Gpo_Cuenta_EdoResultados_Tradicional)item;
            if (bVengoModificar)
            {
                _nuevoCtaERT = new DWD_Gpo_Cuenta_EdoResultados_Tradicional();
                _nuevoCtaERT.gcta_id_1 = gpo_Cuenta_ERT.gcta_id_1;
                _nuevoCtaERT.gcta_nombre_1 = gpo_Cuenta_ERT.gcta_nombre_1;
                _nuevoCtaERT.gcta_id_2 = gpo_Cuenta_ERT.gcta_id_2;
                _nuevoCtaERT.gcta_nombre_2 = gpo_Cuenta_ERT.gcta_nombre_2;
                _nuevoCtaERT.gcta_id_3 = gpo_Cuenta_ERT.gcta_id_3;
                _nuevoCtaERT.gcta_nombre_3 = gpo_Cuenta_ERT.gcta_nombre_3;
                _nuevoCtaERT.gcta_id_4 = gpo_Cuenta_ERT.gcta_id_4;
                _nuevoCtaERT.gcta_nombre_4 = gpo_Cuenta_ERT.gcta_nombre_4;
                _nuevoCtaERT.gcta_id_5 = gpo_Cuenta_ERT.gcta_id_5;
                _nuevoCtaERT.gcta_nombre_5 = gpo_Cuenta_ERT.gcta_nombre_5;
                _nuevoCtaERT.gcta_id_6 = gpo_Cuenta_ERT.gcta_id_6;
                _nuevoCtaERT.gcta_nombre_6 = gpo_Cuenta_ERT.gcta_nombre_6;
                _nuevoCtaERT.gcta_id_9 = gpo_Cuenta_ERT.gcta_id_9;
                _nuevoCtaERT.gcta_nombre_9 = gpo_Cuenta_ERT.gcta_nombre_9;
                this.tabGpo_Cuenta_EdoRes_Trad.DataContext = _nuevoCtaERT;

            }
            else this.tabGpo_Cuenta_EdoRes_Trad.DataContext = gpo_Cuenta_ERT;
            tabGpo_Cuenta_EdoRes_Trad.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)NumeroTab.Gpo_Cuenta_ERT;
        }

        private void cargarGpo_Cuenta_BO(object item)
        {
            gpo_Cuenta_BO = (DWD_Gpo_Cuenta_Balance_Operadora)item;
            if (bVengoModificar)
            {
                _nuevoCtaBO = new DWD_Gpo_Cuenta_Balance_Operadora();
                _nuevoCtaBO.gcta_id_1 = gpo_Cuenta_BO.gcta_id_1;
                _nuevoCtaBO.gcta_nombre_1 = gpo_Cuenta_BO.gcta_nombre_1;
                _nuevoCtaBO.gcta_id_2 = gpo_Cuenta_BO.gcta_id_2;
                _nuevoCtaBO.gcta_nombre_2 = gpo_Cuenta_BO.gcta_nombre_2;
                _nuevoCtaBO.gcta_id_3 = gpo_Cuenta_BO.gcta_id_3;
                _nuevoCtaBO.gcta_nombre_3 = gpo_Cuenta_BO.gcta_nombre_3;
                _nuevoCtaBO.gcta_id_4 = gpo_Cuenta_BO.gcta_id_4;
                _nuevoCtaBO.gcta_nombre_4 = gpo_Cuenta_BO.gcta_nombre_4;
                _nuevoCtaBO.gcta_id_5 = gpo_Cuenta_BO.gcta_id_5;
                _nuevoCtaBO.gcta_nombre_5 = gpo_Cuenta_BO.gcta_nombre_5;
                _nuevoCtaBO.gcta_id_8 = gpo_Cuenta_BO.gcta_id_8;
                _nuevoCtaBO.gcta_nombre_8 = gpo_Cuenta_BO.gcta_nombre_8;
                this.tabGpo_Cuenta_Bal_Ope.DataContext = _nuevoCtaBO;

            }
            else this.tabGpo_Cuenta_Bal_Ope.DataContext = gpo_Cuenta_BO;
            tabGpo_Cuenta_Bal_Ope.Visibility = System.Windows.Visibility.Visible;
            TabGeneral.SelectedIndex = (Int32)NumeroTab.Gpo_Cuenta_BO;
        }
        #endregion

        

       

        
    }
}
