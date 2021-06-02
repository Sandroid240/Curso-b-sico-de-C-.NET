
namespace SimplePaint
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimparTudo = new System.Windows.Forms.Button();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEspessuraDaCaneta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCorCaneta = new System.Windows.Forms.Button();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonLimparTudo);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEspessuraDaCaneta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCorCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(561, 38);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(86, 28);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimparTudo
            // 
            this.buttonLimparTudo.BackColor = System.Drawing.Color.Black;
            this.buttonLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparTudo.Location = new System.Drawing.Point(469, 38);
            this.buttonLimparTudo.Name = "buttonLimparTudo";
            this.buttonLimparTudo.Size = new System.Drawing.Size(86, 28);
            this.buttonLimparTudo.TabIndex = 5;
            this.buttonLimparTudo.Text = "Apagar";
            this.buttonLimparTudo.UseVisualStyleBackColor = false;
            this.buttonLimparTudo.Click += new System.EventHandler(this.buttonLimparTudo_Click);
            // 
            // buttonBorracha
            // 
            this.buttonBorracha.BackColor = System.Drawing.Color.Black;
            this.buttonBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorracha.Location = new System.Drawing.Point(377, 38);
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.Size = new System.Drawing.Size(86, 28);
            this.buttonBorracha.TabIndex = 4;
            this.buttonBorracha.Text = "Borracha";
            this.buttonBorracha.UseVisualStyleBackColor = false;
            this.buttonBorracha.Click += new System.EventHandler(this.buttonBorracha_Click);
            this.buttonBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBorracha_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Espessura da caneta";
            // 
            // comboBoxEspessuraDaCaneta
            // 
            this.comboBoxEspessuraDaCaneta.FormattingEnabled = true;
            this.comboBoxEspessuraDaCaneta.Location = new System.Drawing.Point(325, 38);
            this.comboBoxEspessuraDaCaneta.Name = "comboBoxEspessuraDaCaneta";
            this.comboBoxEspessuraDaCaneta.Size = new System.Drawing.Size(46, 26);
            this.comboBoxEspessuraDaCaneta.TabIndex = 2;
            this.comboBoxEspessuraDaCaneta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor do caneta";
            // 
            // buttonCorCaneta
            // 
            this.buttonCorCaneta.BackColor = System.Drawing.Color.Blue;
            this.buttonCorCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorCaneta.Location = new System.Drawing.Point(119, 38);
            this.buttonCorCaneta.Name = "buttonCorCaneta";
            this.buttonCorCaneta.Size = new System.Drawing.Size(38, 28);
            this.buttonCorCaneta.TabIndex = 0;
            this.buttonCorCaneta.UseVisualStyleBackColor = false;
            this.buttonCorCaneta.Click += new System.EventHandler(this.buttonCorCaneta_Click);
            // 
            // panelPintura
            // 
            this.panelPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPintura.BackColor = System.Drawing.Color.White;
            this.panelPintura.Location = new System.Drawing.Point(12, 118);
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.Size = new System.Drawing.Size(688, 320);
            this.panelPintura.TabIndex = 1;
            this.panelPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseDown);
            this.panelPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseMove);
            this.panelPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseUp);
            this.panelPintura.Resize += new System.EventHandler(this.panelPintura_Resize);
            // 
            // FormPrincipal
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "SimplePaint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEspessuraDaCaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCorCaneta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimparTudo;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Panel panelPintura;
    }
}

