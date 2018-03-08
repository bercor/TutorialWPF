using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;

namespace Catalogos_BI_Fase_I.Validaciones
{
    public class ValidacionesComunes
    {
    }
    public class ValidaCampoEnBlanco : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (String.IsNullOrWhiteSpace((String)value))
            {
                return new ValidationResult(false, "El Campo no puede estar en blanco");
            }

            return new ValidationResult(true, null);
        }
    }
}
