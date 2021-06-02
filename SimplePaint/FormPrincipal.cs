using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FormPrincipal : Form
    {

        private bool flagPintar; //controlar quando se deve desenhar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; //Para controlar quando se deve apagar com a borracha
        private Image imagemSalvar;
        private Graphics graphicsImagemSalvar;
        public FormPrincipal()
        {
            InitializeComponent();

            /* As propriedades abaixo só fazem efeito quando o button está com a propriedade FlatStyle
             * setada em Flat
             */
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.Cyan; //Altera a cor do botão quando o cursor está sobre ele
            buttonLimparTudo.FlatAppearance.MouseOverBackColor = Color.Cyan; //Altera a cor do botão quando o cursor está sobre ele
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.Cyan; //Altera a cor do botão quando o cursor está sobre ele

            for (int i = 2; i <= 100; i+=2) // Irá preencher o comboBox de 2 até 100 contando de 2 em 2 
            {
                comboBoxEspessuraDaCaneta.Items.Add(i);
            }

            comboBoxEspessuraDaCaneta.Text = "10"; //Texto que irá aparecer inicialmente na comboBox
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 3; // Define o numero de itens a serem exibidos na comboBoX
            comboBoxEspessuraDaCaneta.IntegralHeight = false; // Necessário para que seja possível definir a quantidade de itens exibidos na comboBox

            graphicsPainelPintura = panelPintura.CreateGraphics(); //Graphics permite o desenho sobre o controle
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text); //Converte texto da comboBoxEspessura para float
            corBorracha = panelPintura.BackColor; //Especifica a cor padrão da borracha como a cor de fundo do painel 

            imagemSalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //Imagem para salvar 
            graphicsImagemSalvar = Graphics.FromImage(imagemSalvar); //Extraindo Graphics da Imagem para salvar de forma a podermos desenhar nela
            graphicsImagemSalvar.Clear(panelPintura.BackColor); //Preenchemos a imagem com a cor de fundo do painel 
        }


        //SelectedIndexChanged ocorre quando é feita uma escolha de item pelo o usuário na comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        // handler do evento de click do button
        // disparado quando o botão é clicado
        // Server para manipulação de quando o clique ocorre 
        private void buttonCorCaneta_Click(object sender, EventArgs e) //método 
        {
            var colorDialog = new ColorDialog(); //ColorDialog é uma caixa de seleção de cores 
            var corEscolhida = colorDialog.ShowDialog(); //exibe na forma modal - aplicação fica travada no dialogo enquanto não é resolvido

            if (corEscolhida == DialogResult.OK) //Verifica se usuário clicou mesmo em OK 
            {
                buttonCorCaneta.BackColor = colorDialog.Color; // Alteramos a cor do botão para a cor escolhida pelo usuário 
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {

            

            if (flagPintar)
            {

                if (!flagApagar)
                {
                    //Desenhamos uma elipse de cor e espessura definida pelo usuário, nas coordenadas do ponteiro do mouse 
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                    //Desenhando imagem para salvar 
                    graphicsImagemSalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                }
                else
                {
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); //Variavel float foi tranformada em int. Método usado, pois não há risco de perda de dados 

                    //Desenhando imagem para salvar 
                    graphicsImagemSalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
 
            }
        }
        private void buttonLimparTudo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja apagar tudo?", "Aapagar desenho", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                graphicsPainelPintura.Clear(Color.White); //Limpa todo o desenho e preenche novamente todo o background do painel com branco

                imagemSalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //Imagem para salvar 
                graphicsImagemSalvar = Graphics.FromImage(imagemSalvar); //Extraindo Graphics da Imagem para salvar de forma a podermos desenhar nela
                graphicsImagemSalvar.Clear(panelPintura.BackColor); //Preenchemos a imagem com a cor de fundo do painel 
            }
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) //Se clicar com o botão direito do mouse sob o botão borracha 
            {
                var colorDialog = new ColorDialog();
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; //Seleciona a cor da borracha de acordo com a escolha do usuário
                }
            }
            else
            {
                if (!flagApagar) //Operador ! altera false para true (e vise e versa) 
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha; //cor do botão será o mesmo da borracha 
                }
                else
                {
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.Black; //cor do botão voltará ao padrão 
                }
               
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); //Janela para salvar arquivos 
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg"; //Atribuindo formatos de imagem
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                //Definindo extensão da imagem a ser salva 
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        //Evento dispara sempre que painel é redimensionado
        private void panelPintura_Resize(object sender, EventArgs e) 
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); //Atualiza a referência do objeto graphics do painel
            var imgTemp = new Bitmap(panelPintura.Width, panelPintura.Height); // Criação de uma imagem temporaria 
            var graphicsImgtemp = Graphics.FromImage(imgTemp);
            graphicsImgtemp.DrawImage(imagemSalvar,0 ,0); //Desenhamos um imagem antiga na imagem temporaria - uma maneira de fazer uma cópia de dados 
            imagemSalvar = imgTemp;
            graphicsImagemSalvar = graphicsImgtemp;
        }
    }
}
