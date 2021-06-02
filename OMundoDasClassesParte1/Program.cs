using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    class Program // sem modificador de acesso explicito = internal por padrão 
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro(Cor.Azul, 4, "Corsa 97"); ; //criando o carro; 

            //Exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas");

            Console.WriteLine(carro.TanqueCheio());
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("\nLigado?\n" + carro.Ligado);
            Console.WriteLine(carro.Andar());

            Console.WriteLine(carro.TanqueVazio());
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("\nO carro continua Ligado?\n" + carro.Ligado);

            carro.Cor = Cor.Vermelho; //Pintando o carro de outra cor
            Console.WriteLine("\nA nova cor do carro é " + carro.Cor);

        }
    }
}
