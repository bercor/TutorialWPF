using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Catalogos_BI_Fase_I.Validaciones
{
    
    // '' <summary>
    // '' Auxiliar para validaciones
    // '' </summary>
    // '' <remarks></remarks>
    public class ObjetoErrorValidacion
    {

        private string _Mensaje;

        public string Mensaje
        {
            get
            {
                return _Mensaje;
            }
            set
            {
                _Mensaje = value;
            }
        }

        private string _Nivel;

        public string Nivel
        {
            get
            {
                return _Nivel;
            }
            set
            {
                _Nivel = value;
            }
        }

        public ObjetoErrorValidacion(string Mensaje, int nivel)
        {
            this.Mensaje = Mensaje;
            this.Nivel = nivel.ToString ();
        }

        private ObjetoErrorValidacion()
        {
        }

        public override string ToString()
        {
            return Mensaje;
        }
    }
    // '' <summary>
    // '' Auxiliar para validaciones
    // '' </summary>
    // '' <remarks></remarks>
    enum NivelesError
    {

        None = 0,

        Warning = 1,

        Error = 2,
    }
    // '' <summary>
    // '' Auxiliares para validaciones
    // '' </summary>
    // '' <remarks></remarks>
    public class Constantes
    {

        public static Regex regexRFCBase = new Regex("^[a-zA-Z&]{3,4}(\\d{6})((\\D|\\d){3})?\\s*$");

        public static Regex regexRFCHomoclave = new Regex("^[a-zA-Z&]{3,4}(\\d{6})((\\D|\\d){2}(a-A|\\d){1})\\s*$");
    }
}
