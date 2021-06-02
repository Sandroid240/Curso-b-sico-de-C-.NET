using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public class Gato : Animal //A classe Gato está herdando o código de Animal 
    {
        public Gato(string nome, int idade) : base(nome, idade) // base(nome, idade) invoca construtor da classe Animal 
        {
     
        }

        public override Cor Cor => Cor.Branco;
        public override Som SomEmitido => Som.Miado;
       
    }
}
