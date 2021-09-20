using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            lblResultado.Text = "0";
            comboBox1.SelectedIndex = 0; 
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando op1 = new Operando(txtNumero1.Text);
            Operando op2 = new Operando(txtNumero2.Text);
            char operador = Char.Parse(comboBox1.Text);
            lblResultado.Text = Calculadora.Operar(op1, op2, operador).ToString();
            lstOperaciones.Items.Add(txtNumero1.Text + comboBox1.Text + txtNumero2.Text + " = " + lblResultado.Text);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando op = new Operando();
            lblResultado.Text = op.DecimalBinario(txtNumero1.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando op = new Operando();
            lblResultado.Text = op.BinarioDecimal(txtNumero1.Text);
        }
    }
}
