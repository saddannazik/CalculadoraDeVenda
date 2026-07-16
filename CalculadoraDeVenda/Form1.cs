using CalculadoraDeVenda.Services;
using System.Globalization;

namespace CalculadoraDeVenda
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void rdbReal_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbReal.Checked)
                return;

            lblSimboloMoeda.Text = "R$";
            lblValorPeca.Text = "Valor da Peça";
            txtValorPeca.Clear();
            lblResultado.Text = "R$ 0,00";
            txtValorPeca.Focus();
        }

        private void rdbDolar_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbDolar.Checked)
                return;

            lblSimboloMoeda.Text = "US$";
            lblValorPeca.Text = "Valor da Peça";
            txtValorPeca.Clear();
            lblResultado.Text = "R$ 0,00";
            txtValorPeca.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValorPeca.Text.Trim();

            if (string.IsNullOrWhiteSpace(valorDigitado))
            {
                MessageBox.Show(
                    "Informe o valor da peça.",
                    "Valor obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtValorPeca.Focus();
                return;
            }

            bool valorValido = decimal.TryParse(
                valorDigitado,
                NumberStyles.Number,
                new CultureInfo("pt-BR"),
                out decimal valorCusto
            );

            if (!valorValido || valorCusto <= 0)
            {
                MessageBox.Show(
                    "Digite um valor válido maior que zero.",
                    "Valor inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtValorPeca.SelectAll();
                txtValorPeca.Focus();
                return;
            }

            CalculadoraService calculadoraService = new CalculadoraService();

            decimal valorVenda;

            if (rdbReal.Checked)
            {
                valorVenda =
                    calculadoraService.CalcularVendaNacional(valorCusto);
            }
            else
            {
                valorVenda =
                    calculadoraService.CalcularVendaImportacao(valorCusto);
            }

            lblResultado.Text = valorVenda.ToString(
                "C2",
                new CultureInfo("pt-BR")

            );
            if (rdbReal.Checked)
            {
                lblResultado.ForeColor = Color.ForestGreen;
                lblTipoCalculo.Text = "✓ Cálculo Nacional";
                lblTipoCalculo.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblResultado.ForeColor = Color.SteelBlue;
                lblTipoCalculo.Text = "✓ Cálculo de Importação";
                lblTipoCalculo.ForeColor = Color.SteelBlue;
            }

                   
                       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorPeca.Clear();
            lblResultado.Text = "R$ 0,00";
            txtValorPeca.Focus();
            lblResultado.ForeColor = Color.DarkGray;
            lblTipoCalculo.Text = "Aguardando cálculo...";
            lblTipoCalculo.ForeColor = Color.Gray;
        }
    }
}
