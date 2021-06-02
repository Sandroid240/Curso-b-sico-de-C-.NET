using ModuloCalduladora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var continuar = true;

            while (continuar)
            {
                double resultado = 0;

                Console.WriteLine("Escolha a operação: 1 - Somar/ 2 - Subtrair/ 3 - Multiplicar/ 4 - Dividir");
                var operacao = Console.ReadLine(); //Lê opção do usuario

                Console.WriteLine("Digite o primeiro valor: ");
                var numero1 = double.Parse(Console.ReadLine()); //Lê numero digitado

                Console.WriteLine("Digite o segundo valor: ");
                var numero2 = double.Parse(Console.ReadLine()); //Lê numero digitado

                if (operacao == "1")
                    resultado = OperacoesAritmeticas.Adicao(numero1, numero2);
                else if(operacao == "2")
                            resultado = OperacoesAritmeticas.Subtracao(numero1, numero2);
                else if(operacao == "3")
                            resultado = OperacoesAritmeticas.Multiplicacao(numero1, numero2);
                else if(operacao == "4")
                            resultado = OperacoesAritmeticas.Divisao(numero1, numero2);
                else
                    Console.WriteLine("Opção invalida. Tente novamente");

                Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine();
                Console.WriteLine("Deseja continuar? S/N");
                if (Console.ReadLine() == "N")
                    continuar = false;
                else
                    Console.WriteLine();

            }

        }
    }
}
