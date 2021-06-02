using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToPark
{
    class GerenciadorArrecadacao
    {

        public float ValorDaHora { get; set; } //Para configurar o valor da hora dinamicamente 
        private float _arrecadado;  //Armazena o total arrecadado 

        public float Arrecadado //Essa propriedade serve para manipularmos os dados da variavel _arrecadado
        {
            get => _arrecadado; //Retorna valor da variavel _arrecadado
            set => _arrecadado += value; // Soma o valor atual da variavel _arrecadado com o valor recebido e salva na value
        }

      public float CalcularEstadiaCliente(DateTime entrada) //Metodo usado para calcular o valor total que o cliente deve pagar
        {
            var permanencia = DateTime.Now - entrada; //Calcular o tempo de permanência desde a entrada até o presente momento 

            if(permanencia.Hours <= 0) //Se a permanencia for menor que 1h, retorna o valor de 1h...
            {
                return ValorDaHora;
            }
            else // Senão, calcular o respectivo valor de acordo com o tempo de permanencia 
            {
                return ValorDaHora * permanencia.Hours;
            }
        }
    }
}
