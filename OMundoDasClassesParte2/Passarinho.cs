using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public class Passarinho : Animal
    {
        public Passarinho(string nome, int idade) : base(nome, idade)
        {
        }

        public override Cor Cor => Cor.Azul;
        public override Som SomEmitido => Som.Piupiu;

        public override string Locomocao => "Está voando";


    }
}
