using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    public class Xerox : ICopiar
    {
        public string Copiar(string texto)
        {
            return $"Texto a ser copiado: {texto}";
        }
    }
}
