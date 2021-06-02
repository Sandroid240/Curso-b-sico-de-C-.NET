using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 20;
            var soma = numero1 + numero2;
            Console.WriteLine("o valor de 10 + 20 é = " + soma);

            int copiaDoNumero1 = numero1;
            Console.WriteLine(numero1);
            copiaDoNumero1 = 11;
            Console.WriteLine(copiaDoNumero1);

            var quadrado1 = new Quadrado(); // criando objeto da classe Quadrado;   
            quadrado1.lado = 10; // quadrado1 terá valor de lado = 10;
            var quadrado2 = quadrado1;
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
        }
        class Quadrado // define uma classe chamada Quadrado
        {
            public int lado; // define um atributo do tipo inteiro (int) chamado lado, dentro da classe Quadrado (class Quadrado)
        }
    }
}
