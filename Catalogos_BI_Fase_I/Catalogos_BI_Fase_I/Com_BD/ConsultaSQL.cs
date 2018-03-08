using Catalogos_BI_Fase_I.ObjetosBD;
using System;
using System.Linq;
using System.Text;

namespace Catalogos_BI_Fase_I.Com_BD
{
    public class ConsultaSQL
    {
        public String selectEdoResultados_41501()
        {
            String consEdoRes41501 = String.Empty;
            consEdoRes41501 = "SELECT gcta_id_8_ini,    gcta_id_9_fin,    Signo_importe, Rubro_5_Afecta  \n"; 
            consEdoRes41501 = consEdoRes41501 +  "FROM DWD_Criterio_EdoResultados_41501";
            return consEdoRes41501;
        }

        public String regresaNumRegEdoResultados_41501(Cls_DWD_Criterio_EdoResultados_41501 objCrit)
        {
            String consEdoRes41501 = String.Empty;
            consEdoRes41501 = "SELECT COUNT(*)  \n";
            consEdoRes41501 = consEdoRes41501 + "FROM DWD_Criterio_EdoResultados_41501 \n";
            consEdoRes41501 = consEdoRes41501 + "WHERE gcta_id_8_ini = '" + objCrit.gcta_id_8_ini + "' \n";
            consEdoRes41501 = consEdoRes41501 + "AND gcta_id_9_fin = '" + objCrit.gcta_id_9_fin + "' \n";
            consEdoRes41501 = consEdoRes41501 + "AND Signo_importe = " + objCrit.Signo_importe + " \n";
            consEdoRes41501 = consEdoRes41501 + "AND  Rubro_5_Afecta = '" + objCrit.Rubro_5_Afecta + "'";
            return consEdoRes41501;
        }

        public String eliminarEdoResultados_41501(String gcta_id_8_ini, String gcta_id_9_fin, Int32 Signo_importe, String Rubro_5_Afecta)
        {
            String consEdoRes41501 = String.Empty;
            consEdoRes41501 = "DELETE FROM DWD_Criterio_EdoResultados_41501 \n";
            consEdoRes41501 = consEdoRes41501 + "WHERE gcta_id_8_ini = '" + gcta_id_8_ini + "' \n";
            consEdoRes41501 = consEdoRes41501 + "AND gcta_id_9_fin = '" + gcta_id_9_fin + "'\n";
            consEdoRes41501 = consEdoRes41501 + "AND Signo_importe = " + Signo_importe + "\n";
            consEdoRes41501 = consEdoRes41501 + "AND  Rubro_5_Afecta = '" + Rubro_5_Afecta + "'";
            return consEdoRes41501;
        }
        public String updateEdoResultados_41501(Cls_DWD_Criterio_EdoResultados_41501 objNuevoCrit, Cls_DWD_Criterio_EdoResultados_41501 objViejoCrit)
        {
            String consEdoRes41501 = String.Empty;
            consEdoRes41501 = "UPDATE DWD_Criterio_EdoResultados_41501  \n";
            consEdoRes41501 = consEdoRes41501 + "SET gcta_id_8_ini = '" + objNuevoCrit.gcta_id_8_ini + "', \n";
            consEdoRes41501 = consEdoRes41501 + "gcta_id_9_fin = '" + objNuevoCrit.gcta_id_9_fin + "', \n";
            consEdoRes41501 = consEdoRes41501 + "Signo_importe = " + objNuevoCrit.Signo_importe + ", \n";
            consEdoRes41501 = consEdoRes41501 + "Rubro_5_Afecta = '" + objNuevoCrit.Rubro_5_Afecta + "'";
            consEdoRes41501 = consEdoRes41501 + "FROM DWD_Criterio_EdoResultados_41501 \n";
            consEdoRes41501 = consEdoRes41501 + "WHERE gcta_id_8_ini = '" + objViejoCrit.gcta_id_8_ini + "' \n";
            consEdoRes41501 = consEdoRes41501 + "AND gcta_id_9_fin = '" + objViejoCrit.gcta_id_9_fin + "' \n";
            consEdoRes41501 = consEdoRes41501 + "AND Signo_importe = " + objViejoCrit.Signo_importe + " \n";
            consEdoRes41501 = consEdoRes41501 + "AND  Rubro_5_Afecta = '" + objViejoCrit.Rubro_5_Afecta + "'";
            return consEdoRes41501;
        }
        public String selectEdoResultados_Especial()
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "SELECT Rubro_01,  Rubro_03,  Contrato,  gcta_id_8_fin, gcta_id_8_ini   \n";
            consEdoResEsp = consEdoResEsp + "FROM DWD_Criterio_EdoResultados_Especial";
            return consEdoResEsp;
        }

        public String regresaNumRegEdoResultados_Especial(DWD_Criterio_EdoResultados_Especial regRevisar)
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "SELECT COUNT(*)  \n";
            consEdoResEsp = consEdoResEsp + "FROM DWD_Criterio_EdoResultados_Especial \n";
            consEdoResEsp = consEdoResEsp + "WHERE Rubro_01 = '" + regRevisar.Rubro_01 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Rubro_03 = '" + regRevisar.Rubro_03 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Contrato = '" + regRevisar.Contrato + "' \n";
            consEdoResEsp = consEdoResEsp + "AND gcta_id_8_fin = '" + regRevisar.gcta_id_8_fin + "' \n";
            consEdoResEsp = consEdoResEsp + "AND  gcta_id_8_ini = '" + regRevisar.gcta_id_8_ini + "'";
            return consEdoResEsp;
        }
        public String eliminarEdoResultados_Especial(String Rubro_01, String Rubro_03, String Contrato,
            String gcta_id_8_fin, String gcta_id_8_ini)
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "DELETE FROM DWD_Criterio_EdoResultados_Especial \n";
            consEdoResEsp = consEdoResEsp + "WHERE Rubro_01 = '" + Rubro_01 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Rubro_03 = '" + Rubro_03 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Contrato = '" + Contrato + "' \n";
            consEdoResEsp = consEdoResEsp + "AND gcta_id_8_fin = '" + gcta_id_8_fin + "' \n";
            consEdoResEsp = consEdoResEsp + "AND  gcta_id_8_ini = '" + gcta_id_8_ini + "'";
            return consEdoResEsp;
        }

        public String updateEdoResultados_Especial(DWD_Criterio_EdoResultados_Especial nuevo, DWD_Criterio_EdoResultados_Especial viejo)
        {
            String consEdoResEsp = String.Empty;
            consEdoResEsp = "UPDATE DWD_Criterio_EdoResultados_Especial \n";
            consEdoResEsp = consEdoResEsp + "SET Rubro_01 = '" + nuevo.Rubro_01 + "', \n";
            consEdoResEsp = consEdoResEsp + "Rubro_03 = '" + nuevo.Rubro_03 + "', \n";
            consEdoResEsp = consEdoResEsp + "Contrato = '" + nuevo.Contrato + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_8_fin = '" + nuevo.gcta_id_8_fin + "', \n";
            consEdoResEsp = consEdoResEsp + "gcta_id_8_ini = '" + nuevo.gcta_id_8_ini + "'";
            consEdoResEsp = consEdoResEsp + "WHERE Rubro_01 = '" + viejo.Rubro_01 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Rubro_03 = '" + viejo.Rubro_03 + "' \n";
            consEdoResEsp = consEdoResEsp + "AND Contrato = '" + viejo.Contrato + "' \n";
            consEdoResEsp = consEdoResEsp + "AND gcta_id_8_fin = '" + viejo.gcta_id_8_fin + "' \n";
            consEdoResEsp = consEdoResEsp + "AND  gcta_id_8_ini = '" + viejo.gcta_id_8_ini + "'";
            return consEdoResEsp;
        }

        public String selectReporte_Utilidades()
        {
            String consReporte_Utilidades = String.Empty;
            consReporte_Utilidades = "SELECT Usuario_ID, gcta_id_8,  Rubro    \n";
            consReporte_Utilidades = consReporte_Utilidades + "FROM DWD_Emp_Reporte_Utilidades";
            return consReporte_Utilidades;
        }

        public String regresaNumRegReporte_Utilidades(DWD_Emp_Reporte_Utilidades regRevisar)
        {
            String consReporte_Utilidades = String.Empty;
            consReporte_Utilidades = "SELECT COUNT(*)  \n";
            consReporte_Utilidades = consReporte_Utilidades + "FROM DWD_Emp_Reporte_Utilidades \n";
            consReporte_Utilidades = consReporte_Utilidades + "WHERE Usuario_ID = '" + regRevisar.Usuario_ID + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND gcta_id_8 = '" + regRevisar.gcta_id_8 + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND Rubro = '" + regRevisar.Rubro + "'";
            return consReporte_Utilidades;
        }

        public String eliminarReporte_Utilidades(String Usuario_ID, String gcta_id_8, String Rubro)
        {
            String consReporte_Utilidades = String.Empty;
            consReporte_Utilidades = "DELETE FROM DWD_Emp_Reporte_Utilidades \n";
            consReporte_Utilidades = consReporte_Utilidades + "WHERE Usuario_ID = '" + Usuario_ID + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND gcta_id_8 = '" + gcta_id_8 + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND Rubro = '" + Rubro + "'";
            return consReporte_Utilidades;
        }

        public String updateReporte_Utilidades(DWD_Emp_Reporte_Utilidades nuevo, DWD_Emp_Reporte_Utilidades viejo)
        {
            String consReporte_Utilidades = String.Empty;
            consReporte_Utilidades = "UPDATE DWD_Emp_Reporte_Utilidades \n";
            consReporte_Utilidades = consReporte_Utilidades + "SET Usuario_ID = '" + nuevo.Usuario_ID + "', \n";
            consReporte_Utilidades = consReporte_Utilidades + "gcta_id_8 = '" + nuevo.gcta_id_8 + "', \n";
            consReporte_Utilidades = consReporte_Utilidades + "Rubro = '" + nuevo.Rubro + "'";
            consReporte_Utilidades = consReporte_Utilidades + "WHERE Usuario_ID = '" + viejo.Usuario_ID + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND gcta_id_8 = '" + viejo.gcta_id_8 + "' \n";
            consReporte_Utilidades = consReporte_Utilidades + "AND Rubro = '" + viejo.Rubro + "'";
            return consReporte_Utilidades;
        }

        public String selectAcredorDeudor(String nombreTabla)
        {
            String consAcredorDeudor = String.Empty;
            consAcredorDeudor = "SELECT aux_auxiliar, aux_desc, aux_estado,	aux_desc_2    \n";
            consAcredorDeudor = consAcredorDeudor + "FROM " + nombreTabla;
            return consAcredorDeudor;
        }

        public String regresaNumRegAcredorDeudor(String nombreTabla,d_Deudor_Acredor_operadora reg)
        {
            String consAcredorDeudor = String.Empty;
            consAcredorDeudor = "SELECT COUNT(*)  \n";
            consAcredorDeudor = consAcredorDeudor + "FROM " + nombreTabla + "\n";
            consAcredorDeudor = consAcredorDeudor + "WHERE aux_auxiliar = '" + reg.aux_auxiliar + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc = '" + reg.aux_desc + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_estado = '" + reg.aux_estado + "'";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc_2 = '" + reg.aux_desc_2 + "'";
            return consAcredorDeudor;
        }

        public String eliminarAcredorDeudor(String nombreTabla, String aux_auxiliar, String aux_desc, String aux_estado, String aux_desc_2)
        {
            String consAcredorDeudor = String.Empty;
            consAcredorDeudor = "DELETE FROM " + nombreTabla + "\n";
            consAcredorDeudor = consAcredorDeudor + "WHERE aux_auxiliar = '" + aux_auxiliar + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc = '" + aux_desc + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_estado = '" + aux_estado + "'";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc_2 = '" + aux_desc_2 + "'";
            return consAcredorDeudor;
        }
        public String updateAcredorDeudor(String nombreTabla, d_Deudor_Acredor_operadora nuevo, d_Deudor_Acredor_operadora viejo)
        {
            String consAcredorDeudor = String.Empty;
            consAcredorDeudor = "UPDATE " + nombreTabla + "\n";
            consAcredorDeudor = consAcredorDeudor + "SET aux_auxiliar = '" + nuevo.aux_auxiliar + "', \n";
            consAcredorDeudor = consAcredorDeudor + "aux_desc = '" + nuevo.aux_desc + "', \n";
            consAcredorDeudor = consAcredorDeudor + "aux_estado = '" + nuevo.aux_estado + "',";
            consAcredorDeudor = consAcredorDeudor + "aux_desc_2 = '" + nuevo.aux_desc_2 + "'";
            consAcredorDeudor = consAcredorDeudor + "WHERE aux_auxiliar = '" + viejo.aux_auxiliar + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc = '" + viejo.aux_desc + "' \n";
            consAcredorDeudor = consAcredorDeudor + "AND aux_estado = '" + viejo.aux_estado + "'";
            consAcredorDeudor = consAcredorDeudor + "AND aux_desc_2 = '" + viejo.aux_desc_2 + "'";
            return consAcredorDeudor;
        }

        public String selectCuentasID(String idCuenta, Int32 NivelCuenta)
        {
            String consCuentasID1 = String.Empty;
            consCuentasID1 = "EXECUTE spp_regresaCuentas '" + idCuenta + "', " + NivelCuenta.ToString();
            return consCuentasID1;
        }
        
    }
}
