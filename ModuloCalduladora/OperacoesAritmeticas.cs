using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalduladora
{

    /// <summary>
    /// Classe com as operações matemáticas básicas de adição, subtração, multiplicação e divisão
    /// </summary>
    public static class OperacoesAritmeticas // classe static = Não pode ser instanciada, não pode herdar e nem ser herdada. Só pode conter membros estaticos
    {
        /// <summary>
        /// Operação básica de matemática
        /// </summary>
        /// <param name="parcela1">
        /// Pirmeira Parcela.
        /// </param>
        /// 
        /// <param name="parcela2">
        /// Segunda Parcela.
        /// </param>
        /// <returns>
        /// Retorna soma dos valores informados
        /// </returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação básica de subtração
        /// </summary>
        /// <param name="minuendo">
        /// Minuendo.
        /// </param>
        /// <param name="subtraendo">
        /// Subtraendo
        /// </param>
        /// <returns>
        /// Retorna a diferença dos valores informadors
        /// </returns>
        public static double Subtracao(double minuendo, double subtraendo)
        {
            return minuendo - subtraendo;
        }

        /// <summary>
        /// Operação básicao de multiplicação
        /// </summary>
        /// <param name="multiplicando">Multiplicando</param>
        /// <param name="multiplicador">Multiplicador</param>
        /// <returns>Retorna o produto dos valores informados</returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
        
        /// <summary>
        /// Operação básica de divisão
        /// </summary>
        /// <param name="dividendo">dividendo</param>
        /// <param name="divisor">divisor</param>
        /// <returns>Retorna o quociente dos valores informados</returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
