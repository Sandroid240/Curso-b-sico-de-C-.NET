using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços Iterativos = estrututas que repetem um bloco de código, em determinado numeros de vezes 

            //Laço for
            for(var i = 0; i<=10; i++)
            {
                Console.WriteLine("O valor de i com FOR é = " + i);
            }

            //Laço while
            var contador = 3;
            while(contador <= 10)
            {
                Console.WriteLine("O valor de contador com WHILE é = " + contador);
                contador++; 
            }

            //Laço Do...While
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100 );

            //Laço Foreach
            //Nesse laço, percorre todos os elementos de um conjunto 
            int[] conjunto= {0, 1, 2, 3, 4 };

            foreach(int numero /*variavel int numero*/ in conjunto)
            {
                Console.WriteLine("Esse elemento tem conjunto o valor = " + numero + " + 10 = " + (numero+10));
            }

            
        }
    }
}
