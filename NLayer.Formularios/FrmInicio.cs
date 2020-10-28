using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.Formularios
{
    public partial class FrmInicio : Form
    {
        private Form formulario;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulario = new FrmListaClientes();
            formulario.Owner = this;
            formulario.Show();
            this.Hide();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            formulario = new FrmAltaCliente();
            formulario.ShowDialog();
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            formulario = new FrmListarCuentas();
            formulario.ShowDialog();
        }
    }
}
