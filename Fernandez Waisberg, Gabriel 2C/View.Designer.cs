namespace Calculadora___Integrador
{
    partial class View
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.grpRepresentarResultado = new System.Windows.Forms.GroupBox();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.txtPrimerOperador = new System.Windows.Forms.Label();
            this.txtOperador = new System.Windows.Forms.Label();
            this.txtSegundoOperador = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.txtPrimerOperando = new System.Windows.Forms.TextBox();
            this.txtSegundoOperando = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.txtHistorial = new System.Windows.Forms.Label();
            this.grpRepresentarResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRepresentarResultado
            // 
            this.grpRepresentarResultado.Controls.Add(this.rdbBinario);
            this.grpRepresentarResultado.Controls.Add(this.rdbDecimal);
            this.grpRepresentarResultado.Location = new System.Drawing.Point(280, 197);
            this.grpRepresentarResultado.Name = "grpRepresentarResultado";
            this.grpRepresentarResultado.Size = new System.Drawing.Size(170, 61);
            this.grpRepresentarResultado.TabIndex = 1;
            this.grpRepresentarResultado.TabStop = false;
            this.grpRepresentarResultado.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Location = new System.Drawing.Point(94, 28);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(57, 17);
            this.rdbBinario.TabIndex = 1;
            this.rdbBinario.TabStop = true;
            this.rdbBinario.Text = "Binario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Location = new System.Drawing.Point(6, 28);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(63, 17);
            this.rdbDecimal.TabIndex = 0;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // txtPrimerOperador
            // 
            this.txtPrimerOperador.AutoSize = true;
            this.txtPrimerOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerOperador.Location = new System.Drawing.Point(17, 298);
            this.txtPrimerOperador.Name = "txtPrimerOperador";
            this.txtPrimerOperador.Size = new System.Drawing.Size(216, 31);
            this.txtPrimerOperador.TabIndex = 2;
            this.txtPrimerOperador.Text = "Primer operador:";
            // 
            // txtOperador
            // 
            this.txtOperador.AutoSize = true;
            this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador.Location = new System.Drawing.Point(295, 298);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(147, 31);
            this.txtOperador.TabIndex = 3;
            this.txtOperador.Text = "Operacion:";
            // 
            // txtSegundoOperador
            // 
            this.txtSegundoOperador.AutoSize = true;
            this.txtSegundoOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoOperador.Location = new System.Drawing.Point(468, 298);
            this.txtSegundoOperador.Name = "txtSegundoOperador";
            this.txtSegundoOperador.Size = new System.Drawing.Size(245, 31);
            this.txtSegundoOperador.TabIndex = 4;
            this.txtSegundoOperador.Text = "Segundo operador:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(301, 342);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacion.TabIndex = 2;
            // 
            // txtPrimerOperando
            // 
            this.txtPrimerOperando.Location = new System.Drawing.Point(23, 343);
            this.txtPrimerOperando.Name = "txtPrimerOperando";
            this.txtPrimerOperando.Size = new System.Drawing.Size(207, 20);
            this.txtPrimerOperando.TabIndex = 1;
            this.txtPrimerOperando.TextChanged += new System.EventHandler(this.txtPrimerOperando_TextChanged);
            // 
            // txtSegundoOperando
            // 
            this.txtSegundoOperando.Location = new System.Drawing.Point(474, 343);
            this.txtSegundoOperando.Name = "txtSegundoOperando";
            this.txtSegundoOperando.Size = new System.Drawing.Size(239, 20);
            this.txtSegundoOperando.TabIndex = 3;
            this.txtSegundoOperando.TextChanged += new System.EventHandler(this.txtSegundoOperando_TextChanged);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(23, 385);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(207, 43);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(301, 385);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 43);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(474, 385);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(239, 43);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(321, 95);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 46);
            this.labelResultado.TabIndex = 11;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 63);
            this.label1.TabIndex = 12;
            this.label1.Text = "Resultado:";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(771, 125);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(298, 303);
            this.lstHistorial.TabIndex = 13;
            // 
            // txtHistorial
            // 
            this.txtHistorial.AutoSize = true;
            this.txtHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorial.Location = new System.Drawing.Point(765, 83);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(121, 31);
            this.txtHistorial.TabIndex = 14;
            this.txtHistorial.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 445);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtSegundoOperando);
            this.Controls.Add(this.txtPrimerOperando);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.txtSegundoOperador);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.txtPrimerOperador);
            this.Controls.Add(this.grpRepresentarResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Gabriel Fernandez Waisberg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.grpRepresentarResultado.ResumeLayout(false);
            this.grpRepresentarResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRepresentarResultado;
        private System.Windows.Forms.RadioButton rdbBinario;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.Label txtPrimerOperador;
        private System.Windows.Forms.Label txtOperador;
        private System.Windows.Forms.Label txtSegundoOperador;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.TextBox txtPrimerOperando;
        private System.Windows.Forms.TextBox txtSegundoOperando;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label txtHistorial;
    }
}