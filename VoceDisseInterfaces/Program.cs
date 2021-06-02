using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            var a = new ImpressoraCopiadora();
            var escaner = new MultiFuncional();
            var abacaxi = new MultiFuncional();


            var multifuncional = new MultiFuncional();
            var copia = multifuncional.Copiar("XUXA");

            Console.WriteLine(i.Imprimir("Hoje tem gol do Ribamar"));
            Console.WriteLine(i2.Copiar("Palmeiras não tem mundial"));
            Console.WriteLine(copia);

            CopiarDocumento(new Xerox(), "Hello World!");
            CopiarDocumento(a, "Ribamar");
            EscanearDocumento(escaner, "estou escaneando esse texto");
            CopiadoraDocumento(abacaxi, "esse texto foi copiado da multifuncional");
            


        }

        public static void CopiarDocumento(ICopiar c, string texto)
        {
            Console.WriteLine("Estou copiando o texto a seguir: " + c.Copiar(texto));
        }

        public static void EscanearDocumento(IEscanear a, string texto)
        {
            Console.WriteLine("Estou escaneando o texto a seguir: " + a.Escaner(texto));
        }
        public static void CopiadoraDocumento(ICopiar b, string texto)
        {
            Console.WriteLine("Estou usando a multifuncional para copiar esse texto: " + b.Copiar(texto));
        }
    }
}
