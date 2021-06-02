using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    public class MultiFuncional : ICopiar, IImpressora, IEscanear
    {
        public string Copiar(string texto)
        {
            return $"Texto a ser copiado: {texto}";
        }

        public string Escaner(string texto)
        {
            return $"Texto ser escaneado: {texto}";
        }

        public string Imprimir(string texto)
        {
            return $"Texto a ser impresso: {texto}";
        }

    }
}
