using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public class Hamster : Animal
    {
        public Hamster(string nome, int idade) : base (nome, idade) 
        {

        }
        public override Cor Cor => Cor.Preto;

        public override Som SomEmitido => Som.Roer;

       
    }
}
