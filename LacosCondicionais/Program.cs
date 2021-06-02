using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condicional if, if else, else
            /*
            int hora = 16;
            if(hora == 15)
            {
                Console.WriteLine("São 15 ou mais");
            } 
            else if ( hora == 17)
            {
                Console.WriteLine("Já são 17h ou mais");
            }
            else
            {
                if(hora == 19)
                {
                    Console.WriteLine("São 19h ou mais");
                }
                else
                {
                    Console.WriteLine("Seu relógio está quebrado");
                }
            }
            */

            //Condicional switch...case
            /*
            switch (hora)
            {
                case 15:
                    Console.WriteLine("São 15 horas");
                    break;
                case 16:
                    Console.WriteLine("São 16 horas");
                    break;
                case 21:
                    Console.WriteLine("São 21 horas");
                    break;
                default:
                    Console.WriteLine("São mais de 22 horas");
                    break;   
            }
            */

            PrimeiroSemestre mes = PrimeiroSemestre.Junho;
            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("O mês é Janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("O mês é Março");
                    break;
                default:
                    Console.WriteLine("O mês atual é " + mes);
                    break;
            }
            
        }
    }

    /*
     * public = modificador de acesso
     * enum = Geralmente usado para definir constantes
     */
    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }

}
