using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public class Cachorro : Animal //A classe Cachorro está herdando o código de Animal 
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override Cor Cor => Cor.Marrom;
        public override Som SomEmitido => Som.Latido;

        
    }
}
