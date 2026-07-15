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
            lblTitulo = new Label();
            lblValorPeca = new Label();
            txtValorPeca = new TextBox();
            btnCalcular = new Button();
            lblTextoResultado = new Label();
            lblResultado = new Label();
            btnLimpar = new Button();
            chkModoAvancado = new CheckBox();
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
            lblValorPeca.Location = new Point(115, 61);
            lblValorPeca.Name = "lblValorPeca";
            lblValorPeca.Size = new Size(102, 21);
            lblValorPeca.TabIndex = 1;
            lblValorPeca.Text = "Valor da Peça";
            // 
            // txtValorPeca
            // 
            txtValorPeca.Location = new Point(83, 96);
            txtValorPeca.Name = "txtValorPeca";
            txtValorPeca.Size = new Size(180, 23);
            txtValorPeca.TabIndex = 2;
            txtValorPeca.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(98, 143);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(152, 69);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblTextoResultado
            // 
            lblTextoResultado.AutoSize = true;
            lblTextoResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoResultado.Location = new Point(103, 277);
            lblTextoResultado.Name = "lblTextoResultado";
            lblTextoResultado.Size = new Size(114, 21);
            lblTextoResultado.TabIndex = 4;
            lblTextoResultado.Text = "Valor de Venda";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(103, 307);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(131, 45);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "R$ 0,00";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(132, 236);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // chkModoAvancado
            // 
            chkModoAvancado.AutoSize = true;
            chkModoAvancado.Location = new Point(120, 380);
            chkModoAvancado.Name = "chkModoAvancado";
            chkModoAvancado.Size = new Size(114, 19);
            chkModoAvancado.TabIndex = 7;
            chkModoAvancado.Text = "Modo Avançado";
            chkModoAvancado.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(334, 441);
            Controls.Add(chkModoAvancado);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(lblTextoResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtValorPeca);
            Controls.Add(lblValorPeca);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValorPeca;
        private TextBox txtValorPeca;
        private Button btnCalcular;
        private Label lblTextoResultado;
        private Label lblResultado;
        private Button btnLimpar;
        private CheckBox chkModoAvancado;
    }
}
