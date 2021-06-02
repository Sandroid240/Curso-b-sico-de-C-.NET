using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEscolares
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double resultado;


            Console.WriteLine("Digite a Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("\n" + resultado);

            if(resultado >= 6)
            {
                Console.WriteLine("Você passou!");
            }
            else
            {
                Console.WriteLine("Você reprovou");
            }
            


        }
    }
}
