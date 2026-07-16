namespace CalculadoraDeVenda
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            lblTitulo = new Label();
            lblValorPeca = new Label();
            btnCalcular = new Button();
            lblTextoResultado = new Label();
            lblResultado = new Label();
            btnLimpar = new Button();
            chkModoAvancado = new CheckBox();
            rdbReal = new RadioButton();
            rdbDolar = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlValorPeca = new Panel();
            txtValorPeca = new TextBox();
            lblSimboloMoeda = new Label();
            lblTipoCalculo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlValorPeca.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.SteelBlue;
            lblTitulo.Location = new Point(53, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculadora de Venda";
            // 
            // lblValorPeca
            // 
            lblValorPeca.AutoSize = true;
            lblValorPeca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorPeca.Location = new Point(115, 106);
            lblValorPeca.Name = "lblValorPeca";
            lblValorPeca.Size = new Size(102, 21);
            lblValorPeca.TabIndex = 1;
            lblValorPeca.Text = "Valor da Peça";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(83, 188);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(152, 69);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTextoResultado
            // 
            lblTextoResultado.AutoSize = true;
            lblTextoResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoResultado.Location = new Point(88, 333);
            lblTextoResultado.Name = "lblTextoResultado";
            lblTextoResultado.Size = new Size(114, 21);
            lblTextoResultado.TabIndex = 4;
            lblTextoResultado.Text = "Valor de Venda";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.DarkGray;
            lblResultado.Location = new Point(81, 354);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(131, 45);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "R$ 0,00";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(115, 263);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(72, 43);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // chkModoAvancado
            // 
            chkModoAvancado.AutoSize = true;
            chkModoAvancado.Location = new Point(12, 461);
            chkModoAvancado.Name = "chkModoAvancado";
            chkModoAvancado.Size = new Size(114, 19);
            chkModoAvancado.TabIndex = 7;
            chkModoAvancado.Text = "Modo Avançado";
            chkModoAvancado.UseVisualStyleBackColor = true;
            // 
            // rdbReal
            // 
            rdbReal.AutoSize = true;
            rdbReal.Checked = true;
            rdbReal.Location = new Point(50, 56);
            rdbReal.Name = "rdbReal";
            rdbReal.Size = new Size(47, 19);
            rdbReal.TabIndex = 8;
            rdbReal.TabStop = true;
            rdbReal.Text = "Real";
            rdbReal.UseVisualStyleBackColor = true;
            rdbReal.CheckedChanged += rdbReal_CheckedChanged;
            // 
            // rdbDolar
            // 
            rdbDolar.AutoSize = true;
            rdbDolar.Location = new Point(241, 56);
            rdbDolar.Name = "rdbDolar";
            rdbDolar.Size = new Size(53, 19);
            rdbDolar.TabIndex = 9;
            rdbDolar.Text = "Dólar";
            rdbDolar.UseVisualStyleBackColor = true;
            rdbDolar.CheckedChanged += rdbDolar_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.US_Ball;
            pictureBox2.Location = new Point(197, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 33);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pnlValorPeca
            // 
            pnlValorPeca.BackColor = Color.White;
            pnlValorPeca.BorderStyle = BorderStyle.FixedSingle;
            pnlValorPeca.Controls.Add(txtValorPeca);
            pnlValorPeca.Controls.Add(lblSimboloMoeda);
            pnlValorPeca.Location = new Point(71, 141);
            pnlValorPeca.Name = "pnlValorPeca";
            pnlValorPeca.Size = new Size(180, 32);
            pnlValorPeca.TabIndex = 12;
            // 
            // txtValorPeca
            // 
            txtValorPeca.BorderStyle = BorderStyle.None;
            txtValorPeca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorPeca.Location = new Point(31, 5);
            txtValorPeca.Name = "txtValorPeca";
            txtValorPeca.Size = new Size(132, 22);
            txtValorPeca.TabIndex = 13;
            txtValorPeca.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSimboloMoeda
            // 
            lblSimboloMoeda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSimboloMoeda.ForeColor = Color.DimGray;
            lblSimboloMoeda.Location = new Point(-1, 1);
            lblSimboloMoeda.Name = "lblSimboloMoeda";
            lblSimboloMoeda.Size = new Size(43, 30);
            lblSimboloMoeda.TabIndex = 13;
            lblSimboloMoeda.Text = "R$";
            lblSimboloMoeda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoCalculo
            // 
            lblTipoCalculo.AutoSize = true;
            lblTipoCalculo.ForeColor = Color.Gray;
            lblTipoCalculo.Location = new Point(83, 409);
            lblTipoCalculo.Name = "lblTipoCalculo";
            lblTipoCalculo.Size = new Size(123, 15);
            lblTipoCalculo.TabIndex = 13;
            lblTipoCalculo.Text = "Aguardando cálculo...";
            // 
            // frmCalculadora
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(334, 492);
            Controls.Add(lblTipoCalculo);
            Controls.Add(pnlValorPeca);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rdbDolar);
            Controls.Add(rdbReal);
            Controls.Add(chkModoAvancado);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(lblTextoResultado);
            Controls.Add(btnCalcular);
            Controls.Add(lblValorPeca);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Venda";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlValorPeca.ResumeLayout(false);
            pnlValorPeca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValorPeca;
        private Button btnCalcular;
        private Label lblTextoResultado;
        private Label lblResultado;
        private Button btnLimpar;
        private CheckBox chkModoAvancado;
        private RadioButton rdbReal;
        private RadioButton rdbDolar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel pnlValorPeca;
        private Label lblSimboloMoeda;
        private TextBox txtValorPeca;
        private Label lblTipoCalculo;
    }
}
