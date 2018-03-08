using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace Catalogos_BI_Fase_I.Conexion
{
    public class ClsFuncionesGlobales
    {
        public SqlConnection conexion()
        {
            SqlConnection connection;
            string connetionString = null;
            connetionString = "Data Source=THOR\\SQLSERVER2014;Initial Catalog=Finamex_DWH_Dev;User ID=usSSAS;Password=Finamex01;MultipleActiveResultSets=True;Connect Timeout=300;Application Name=Catalogos_BI_Fase_I";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            return connection;
        }

        public DataTable obtenerDatosGrid(String comando, String claseObjeto)
        {
            SqlDataAdapter daActEcoOtr;
            DataSet dataSet = new DataSet(claseObjeto);
            DataTable tblActEcoOtro=  new DataTable();
            SqlConnection connection = conexion();
            try
            {
                daActEcoOtr = new SqlDataAdapter(comando, connection);
                daActEcoOtr.Fill(dataSet, claseObjeto);
                tblActEcoOtro = dataSet.Tables[claseObjeto];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            return tblActEcoOtro;
        }

        //Busca si existen registros de una busqueda
        public int ExistenRegistros(String comando)
        {
            var  existentes = FuncionesGenericas.EjecutaEscalar(comando, conexion(), String.Empty);

            if (existentes.HasValue)

                return existentes.Value;

            else

                return 0;
        }
    }
}
