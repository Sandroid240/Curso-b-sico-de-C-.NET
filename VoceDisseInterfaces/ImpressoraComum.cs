using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Texto a imprimir: {texto}";
        }
      
    }
}
