using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Importando biblioteca com componentes do Visual Basic 

namespace SimpleToPark
{
    public partial class FormPrincipal2 : Form
    {
        private DataTable bancoDeDados; // DataTable - Usado para armazenar dados em linhas e colunas
        private GerenciadorArrecadacao gerenciador;                               
        public FormPrincipal2()
        {
            InitializeComponent();
            bancoDeDados = new DataTable("Estacionamento"); // Criando tabela ESTACIONAMENTO
            bancoDeDados.Columns.Add("Placa", typeof(string)); //Adicionando coluna chamada PLACA do tipo STRING 
            bancoDeDados.Columns.Add("Entrada", typeof(string)); //Adicionando coluna chamada ENTRADA do tipo STRING 

            dataGridViewCarrosEstacionados.DataSource = bancoDeDados; //Atrelando DataGridView ao DataTable

            gerenciador = new GerenciadorArrecadacao()// Inicializamos o gerenciador 
            {
                ValorDaHora = 10,
                Arrecadado = 0
            };


            labelValorDaHora.Text = $"Valor da hora:R$ {gerenciador.ValorDaHora.ToString("0.00")}";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            /*
               Utilizamos a InputBox do Visual Basic para receber a entrada do usuario, uma vez que o c# não oferece esse componente pronto
               Uma outra abordagem seria criar um form para isso, o que exigiria mais trabalho, mas com maiores possibilidades de customização.
               Para utilizar componentes do Visual Basic e outras linguagens do .NET, é necessário 
               adicionar uma referência para essas linguagens.
               (Botão direito sobre o projeto > Adicionar > Referências > Seção Assemblies > Selecionar Microsoft.VisualBasic
             */

           
           var placa = Interaction.InputBox("Digite a placa do veículo: ", "Entrada de veículos"); //Exibe janela para usuário inserir informações do carro, aproveitando componentes do Visual Basic

            if (!string.IsNullOrEmpty(placa)) //Verifica de a varivel placa está vazia ou não para saber se o usuário clicou em OK ou Cancelar 
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString()});; //Cadastrando placa e horario de entrada no estacionamento
                dataGridViewCarrosEstacionados.Rows[dataGridViewCarrosEstacionados.Rows.Count - 1].MinimumHeight = 30; //Modifica a altura da ultima linha
            }
        }

        private void buttonConfigurar_Click(object sender, EventArgs e)
        {
            var ValorDaHora = Interaction.InputBox("Digite o valor da Hora: ", "Valor da Hora");
            if (!string.IsNullOrEmpty(ValorDaHora))
            {
                gerenciador.ValorDaHora = float.Parse(ValorDaHora);
                labelValorDaHora.Text = $"Valor da hora: R${gerenciador.ValorDaHora.ToString("0.00")}";
            }
        }

        // Esse método será chamado quando o usuário clicar duas vezes sobre uma célula
        // da primeira coluna, ou seja, quando ele der duplo clique sobre a placa do 
        // veículo.
        private void dataGridViewCarrosEstacionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.ColumnIndex != -1) // Verifica se clicou na linha da coluna de placas (ColumnIndex = 0) e em uma linha válida
            {
                // Recupera a hora de entrada e a placa do veículo
                var entrada = DateTime.Parse(bancoDeDados.Rows[e.RowIndex].ItemArray[1].ToString());  // Recupera a data/hora de entrada
                var placa = bancoDeDados.Rows[e.RowIndex].ItemArray[0].ToString(); // Recupera a placa do veículo

                var arrecadado = gerenciador.CalcularEstadiaCliente(entrada); // Calcula o valor que o cliente deverá pagar

                // Exibe mensagem
                if (MessageBox.Show(this, $"Deseja encerrar o ticket de {placa}? Valor: R${arrecadado.ToString("0.00")}", "Encerrar Ticket", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bancoDeDados.Rows.RemoveAt(e.RowIndex);

                    gerenciador.Arrecadado = arrecadado;

                    labelValorArrecadado.Text = $"Total Arrecadado R${gerenciador.Arrecadado.ToString("0.00")}";
                }

            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Button Apagar 
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
