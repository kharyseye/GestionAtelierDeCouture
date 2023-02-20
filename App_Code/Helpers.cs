using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Atelier_Couture.App_Code
{
    public static class Helpers
    {
        public static double ConvertStringToFloat(string nbre)
        {
            return !string.IsNullOrEmpty(nbre) ? double.Parse(nbre.Replace(".",",")) : 0;
        }
    }
}
