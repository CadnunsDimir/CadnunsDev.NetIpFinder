using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.NetIPFinder
{
    public static class Utils
    {
        public static string ToFormat(this string texto, params object[] args)
        {
            return string.Format(texto, args);
        }
    }
}
