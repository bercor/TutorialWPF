using Catalogos_BI_Fase_I.ObjetosBD;
using System;
using System.Linq;
using System.Text;

namespace Catalogos_BI_Fase_I.Com_BD
{
    public class ConsultaSQLCatMay
    {
        #region DWD_Gpo_Cuenta_Balance
        public String regresa_NumReg_Gpo_Cuenta_Balance(DWD_Gpo_Cuenta_Balance regGpo_Cta_Bal)
        {
            String consGpo_Cta_Bal = String.Empty;
            consGpo_Cta_Bal = "SELECT COUNT(*)  \n";
            consGpo_Cta_Bal = consGpo_Cta_Bal + "FROM DWD_Gpo_Cuenta_Balance \n";
            consGpo_Cta_Bal = consGpo_Cta_Bal + "WHERE gcta_id_7 = '" + regGpo_Cta_Bal.gcta_id_7 + "' \n";
            return consGpo_Cta_Bal;
        }
        public String eliminar_Gpo_Cuenta_Balance(DWD_Gpo_Cuenta_Balance cuentaBal)
        {
            String consGpo_Cuenta_Balance = String.Empty;
            consGpo_Cuenta_Balance = "DELETE FROM DWD_Gpo_Cuenta_Balance \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "WHERE gcta_id_7 = '" + cuentaBal.gcta_id_7 + "' \n";
            return consGpo_Cuenta_Balance;
        }

        public String update_Gpo_Cuenta_Balance(DWD_Gpo_Cuenta_Balance nuevo, DWD_Gpo_Cuenta_Balance viejo)
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "UPDATE DWD_Gpo_Cuenta_Balance \n";
            consEdoResEsp = consEdoResEsp + "SET gcta_id_1 = '" + nuevo.gcta_id_1 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_1 = '" + nuevo.gcta_nombre_1 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_2 = '" + nuevo.gcta_id_2 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_2 = '" + nuevo.gcta_nombre_2 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_3 = '" + nuevo.gcta_id_3 + "',";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_3 = '" + nuevo.gcta_nombre_3 + "',";
            consEdoResEsp = consEdoResEsp + "gcta_id_4 = '" + nuevo.gcta_id_4 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_4 = '" + nuevo.gcta_nombre_4 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_5 = '" + nuevo.gcta_id_5 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_5 = '" + nuevo.gcta_nombre_5 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_6 = '" + nuevo.gcta_id_6 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_6 = '" + nuevo.gcta_nombre_6 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_7 = '" + nuevo.gcta_id_7 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_7 = '" + nuevo.gcta_nombre_7 + "', \n";
            consEdoResEsp = consEdoResEsp + "In_cat_utilidad = '" + nuevo.In_cat_utilidad + "', \n";
            consEdoResEsp = consEdoResEsp + "Ident_Migra_Pasivo = '" + nuevo.Ident_Migra_Pasivo + "' \n";
            consEdoResEsp = consEdoResEsp + "WHERE gcta_id_7 = '" + viejo.gcta_id_7 + "' \n";
            return consEdoResEsp;
        }

        public String select_Gpo_Cuenta_Balance()
        {
            String consGpo_Cuenta_Balance = String.Empty;
            consGpo_Cuenta_Balance = "SELECT gcta_id_1, gcta_nombre_1, gcta_id_2, gcta_nombre_2, \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "gcta_id_3, gcta_nombre_3, gcta_id_4, gcta_nombre_4, \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "gcta_id_5, gcta_nombre_5, gcta_id_6, gcta_nombre_6, \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "gcta_id_7, In_cat_utilidad, Ident_Migra_Pasivo, gcta_nombre_7   \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "FROM DWD_Gpo_Cuenta_Balance \n";
            consGpo_Cuenta_Balance = consGpo_Cuenta_Balance + "ORDER BY gcta_id_3 \n";
            return consGpo_Cuenta_Balance;
        }

        public String regresaGpo_Cuenta_Balance(String idCuenta, Int32 levelCuenta)
        {
            String consGpo_Cuenta = String.Empty;
            consGpo_Cuenta = "EXECUTE spp_regresa_Gpo_Cuenta_Balance'" + idCuenta + "'," + levelCuenta.ToString();
            return consGpo_Cuenta;
        }
        public String selectCuentasID_Balance(String idCuenta, Int32 NivelCuenta)
        {
            String consCuentasID1 = String.Empty;
            consCuentasID1 = "EXECUTE spp_reg_Cuentas_Gpo_Cta_Balance '" + idCuenta + "', " + NivelCuenta.ToString();
            return consCuentasID1;
        }
        #endregion
        #region DWD_Gpo_Cuenta_EdoResultados_Tradicional
        public String regresa_NumReg_Gpo_ERT(DWD_Gpo_Cuenta_EdoResultados_Tradicional regGpo_Cta_ERT)
        {
            String consGpo_Cta_ERT = String.Empty;
            consGpo_Cta_ERT = "SELECT COUNT(*)  \n";
            consGpo_Cta_ERT = consGpo_Cta_ERT + "FROM DWD_Gpo_Cuenta_EdoResultados_Tradicional \n";
            consGpo_Cta_ERT = consGpo_Cta_ERT + "WHERE gcta_id_9 = '" + regGpo_Cta_ERT.gcta_id_9 + "' \n";
            return consGpo_Cta_ERT;
        }

        public String update_Gpo_Cuenta_ERT(DWD_Gpo_Cuenta_EdoResultados_Tradicional nuevo, DWD_Gpo_Cuenta_EdoResultados_Tradicional viejo)
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "UPDATE DWD_Gpo_Cuenta_EdoResultados_Tradicional \n";
            consEdoResEsp = consEdoResEsp + "SET gcta_id_1 = '" + nuevo.gcta_id_1 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_1 = '" + nuevo.gcta_nombre_1 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_2 = '" + nuevo.gcta_id_2 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_2 = '" + nuevo.gcta_nombre_2 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_3 = '" + nuevo.gcta_id_3 + "',";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_3 = '" + nuevo.gcta_nombre_3 + "',";
            consEdoResEsp = consEdoResEsp + "gcta_id_4 = '" + nuevo.gcta_id_4 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_4 = '" + nuevo.gcta_nombre_4 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_5 = '" + nuevo.gcta_id_5 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_5 = '" + nuevo.gcta_nombre_5 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_6 = '" + nuevo.gcta_id_6 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_6 = '" + nuevo.gcta_nombre_6 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_9 = '" + nuevo.gcta_id_9 + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_nombre_9 = '" + nuevo.gcta_nombre_9 + "' \n";
            consEdoResEsp = consEdoResEsp + "WHERE gcta_id_9 = '" + viejo.gcta_id_9 + "' \n";
            return consEdoResEsp;
        }

        public String select_Gpo_Cuenta_ERT()
        {
            String consGpo_Cuenta_ERT = String.Empty;
            consGpo_Cuenta_ERT = "SELECT gcta_id_1, gcta_nombre_1, gcta_id_2, gcta_nombre_2, \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "gcta_id_3, gcta_nombre_3, gcta_id_4, gcta_nombre_4, \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "gcta_id_5, gcta_nombre_5, gcta_id_6, gcta_nombre_6, \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "gcta_id_9, gcta_nombre_9   \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "FROM DWD_Gpo_Cuenta_EdoResultados_Tradicional \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "ORDER BY gcta_id_3 \n";
            return consGpo_Cuenta_ERT;
        }

        public String eliminar_Gpo_Cuenta_ERT(DWD_Gpo_Cuenta_EdoResultados_Tradicional cuentaERT)
        {
            String consGpo_Cuenta_ERT = String.Empty;
            consGpo_Cuenta_ERT = "DELETE FROM DWD_Gpo_Cuenta_EdoResultados_Tradicional \n";
            consGpo_Cuenta_ERT = consGpo_Cuenta_ERT + "WHERE gcta_id_9 = '" + cuentaERT.gcta_id_9 + "' \n";
            return consGpo_Cuenta_ERT;
        }

        public String regresaGpo_Cuenta_ERT(String idCuenta, Int32 levelCuenta)
        {
            String consGpo_Cuenta = String.Empty;
            consGpo_Cuenta = "EXECUTE spp_regresa_Gpo_Cuenta_EdoRes_Trad' " + idCuenta + "'," + levelCuenta.ToString();
            return consGpo_Cuenta;
        }
        public String selectCuentasID_EdoRes_Trad(String idCuenta, Int32 NivelCuenta)
        {
            String consCuentasEdoRes_Trad = String.Empty;
            consCuentasEdoRes_Trad = "EXECUTE spp_reg_Cuentas_EdoRes_Trad '" + idCuenta + "', " + NivelCuenta.ToString();
            return consCuentasEdoRes_Trad;
        }
        #endregion
        #region DWD_Gpo_Cuenta_Balance_Operadora
        public String regresa_NumReg_Gpo_Cta_BO(DWD_Gpo_Cuenta_Balance_Operadora regGpo_Cta_BO)
        {
            String consGpo_Cta_BO = String.Empty;
            consGpo_Cta_BO = "SELECT COUNT(*)  \n";
            consGpo_Cta_BO = consGpo_Cta_BO + "FROM DWD_Gpo_Cuenta_Balance_Operadora \n";
            consGpo_Cta_BO = consGpo_Cta_BO + "WHERE gcta_id_8 = '" + regGpo_Cta_BO.gcta_id_8 + "' \n";
            return consGpo_Cta_BO;
        }

        public String regresaGpo_Cuenta_BO(String idCuenta, Int32 levelCuenta)
        {
            String consGpo_Cuenta = String.Empty;
            consGpo_Cuenta = "EXECUTE spp_regresa_Gpo_Cuenta_Bal_Ope '" + idCuenta + "'," + levelCuenta.ToString();
            return consGpo_Cuenta;
        }
        public String update_Gpo_Cuenta_BO(DWD_Gpo_Cuenta_Balance_Operadora nuevo, DWD_Gpo_Cuenta_Balance_Operadora viejo)
        {
            String consCuenta_BO = String.Empty;
            consCuenta_BO = "UPDATE DWD_Gpo_Cuenta_Balance_Operadora \n";
            consCuenta_BO = consCuenta_BO + "SET gcta_id_1 = '" + nuevo.gcta_id_1 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_1 = '" + nuevo.gcta_nombre_1 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_id_2 = '" + nuevo.gcta_id_2 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_2 = '" + nuevo.gcta_nombre_2 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_id_3 = '" + nuevo.gcta_id_3 + "',";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_3 = '" + nuevo.gcta_nombre_3 + "',";
            consCuenta_BO = consCuenta_BO + "gcta_id_4 = '" + nuevo.gcta_id_4 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_4 = '" + nuevo.gcta_nombre_4 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_id_5 = '" + nuevo.gcta_id_5 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_5 = '" + nuevo.gcta_nombre_5 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_id_8 = '" + nuevo.gcta_id_8 + "', \n";
            consCuenta_BO = consCuenta_BO + "gcta_nombre_8 = '" + nuevo.gcta_nombre_8 + "' \n";
            consCuenta_BO = consCuenta_BO + "WHERE gcta_id_8 = '" + viejo.gcta_id_8 + "' \n";
            return consCuenta_BO;
        }
        public String eliminar_Gpo_Cuenta_BO(DWD_Gpo_Cuenta_Balance_Operadora cuentaBO)
        {
            String consGpo_Cuenta_BO = String.Empty;
            consGpo_Cuenta_BO = "DELETE FROM DWD_Gpo_Cuenta_Balance_Operadora \n";
            consGpo_Cuenta_BO = consGpo_Cuenta_BO + "WHERE gcta_id_8 = '" + cuentaBO.gcta_id_8 + "' \n";
            return consGpo_Cuenta_BO;
        }
        public String select_Gpo_Cuenta_BO()
        {
            String consGpo_Cuenta_BO = String.Empty;
            consGpo_Cuenta_BO = "SELECT gcta_id_1, gcta_nombre_1, gcta_id_2, gcta_nombre_2, \n";
            consGpo_Cuenta_BO = consGpo_Cuenta_BO + "gcta_id_3, gcta_nombre_3, gcta_id_4, gcta_nombre_4, \n";
            consGpo_Cuenta_BO = consGpo_Cuenta_BO + "gcta_id_5, gcta_nombre_5, gcta_id_8, gcta_nombre_8 \n";
            consGpo_Cuenta_BO = consGpo_Cuenta_BO + "FROM DWD_Gpo_Cuenta_Balance_Operadora \n";
            consGpo_Cuenta_BO = consGpo_Cuenta_BO + "ORDER BY gcta_id_3 \n";
            return consGpo_Cuenta_BO;
        }
        public String selectCuentasID_BO(String idCuenta, Int32 NivelCuenta)
        {
            String consCuentasBO = String.Empty;
            consCuentasBO = "EXECUTE spp_reg_Cuentas_Balance_Operadora '" + idCuenta + "', " + NivelCuenta.ToString();
            return consCuentasBO;
        }
        #endregion
    }
}
