using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalduladora
{
    /// <summary>
    /// Calculo de tabuada 
    /// </summary>
    class Tabuada
    {
        public int Numero { get; } //propriedade 

        public Tabuada(int numero) //construtor
        {
            Numero = numero;
        }

        /// <summary>
        /// Realiza o calculo da tabuada
        /// </summary>
        /// 
        /// <param name="de">
        /// Inicio do intervalo para o calculo da tabuada
        /// </param>
        /// 
        /// <param name="ate"> 
        /// Término do intervalo para o calculo da tabuada
        /// </param>
        /// 
        /// <returns>
        /// Tabuada do numero informado dentro do intervaldo fornecido
        /// </returns>
        public string Calcular(int de, int ate) //metodo
        {
            var sb = new StringBuilder(); //StringBuilder = construtor de texto/ new StringBuilder = Objeto; 
            for(int i = de; i <= ate; i++)
            {
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritmeticas.Multiplicacao(Numero, i)}");
            }
            return ToString();
        }
    }
}
