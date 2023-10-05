using Entidades;
using System;
using System.Windows.Forms;

namespace Calculadora___Integrador
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new object[] { "", "+", "-", "/", "*" };
            this.rdbDecimal.Checked = true;
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ventanaCerrar = MessageBox.Show("Desea cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ventanaCerrar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperando.Clear();
            this.txtSegundoOperando.Clear();
            this.cmbOperacion.Text = "";
            this.labelResultado.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;

            primerOperando = new Numeracion(txtPrimerOperando.Text, ESistema.Decimal);
            segundoOperando = new Numeracion(txtSegundoOperando.Text, ESistema.Decimal);

            calculadora = new Operacion(primerOperando, segundoOperando);

            bool resultadoChar = char.TryParse(cmbOperacion.Text, out operador);

            this.resultado = calculadora.Operar(operador);

            SetResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                this.sistema = ESistema.Binario;
                SetResultado();
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                this.sistema = ESistema.Decimal;
                SetResultado();
            }
        }

        private void SetResultado()
        {
            if (resultado is null)
            {
                return;
            }

            this.labelResultado.Text = resultado.ConvertirA(this.sistema);
        }

        private void txtPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            string numeroSegundoOperando = txtPrimerOperando.Text;
        }

        private void txtSegundoOperando_TextChanged(object sender, EventArgs e)
        {
            string numeroSegundoOperando = txtSegundoOperando.Text;
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {
            string resultadoLabel = labelResultado.Text;
        }
    }
}