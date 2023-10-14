using Entidades;
using System;
using System.Windows.Forms;

namespace Calculadora___Integrador
{
    public partial class View : Form
    {
        private Calculadora calculadora;

        public View()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y Apellido");
        }

        private Numeracion GetOperador(string value)
        {
            if (calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }

            return new SistemaDecimal(value);
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
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
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.labelResultado.Text = "";
            this.MostrarHistorial();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;

            calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.labelResultado.Text = $"{calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = ESistema.Binario;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = ESistema.Decimal;
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

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }
    }
}