using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Felix", 3);

            Animal a = new Gato("Mel", 5); // Polimorfismo: O gato também é um animal 
            Animal b = new Cachorro("Linus", 2);
            Animal d = new Passarinho("Piu Piu", 2);
            Animal e = new Hamster("Hamtaro", 1);
            Animal f = new Cachorro("Bob", 2);
            
            ExibeAnimal(c); //recebe argumento do tipo cachorro
            ExibeAnimal(g); //recebe argumento do tipo gato
            ExibeAnimal(a); //recebe argumento do tipo animal 
            ExibeAnimal(b);
            ExibeAnimal(d);
            ExibeAnimal(e);
        }

        //criando método
        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"\nNome: {animal.Nome}"); // $ = Interpolação de strings 
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Cor: {animal.Cor}");
            Console.WriteLine($"Som emitido: {animal.SomEmitido}");
            Console.WriteLine($"{animal.Nome} {animal.Locomocao}");
        }
    }
}
