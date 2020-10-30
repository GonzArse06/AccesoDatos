using NLayer.Entidades;
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
    public partial class FrmBuscarCliente : Form
    {

        List<Cliente> lst;
        public FrmBuscarCliente(List<Cliente> lista)
        {
            InitializeComponent();
            lst = lista;
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lst;
        }
        private void listBox1_doubleClick(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }
        private void SeleccionarCliente()
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una opcion.");
            }
            else
            {
                int idCliente = ((Cliente)listBox1.SelectedItem).Id;
                ((FrmIngresarCuenta)Owner).IdCliente = idCliente;
                this.Close();
                //this.Owner.Show();
            }
        }
    }
}
