using NLayer.Negocio;
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
    public partial class FrmAltaCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmAltaCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Replace(".", "");
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text.Replace("-", "");
            DateTime fechaNacimiento = dtFechaNacimiento.Value;

            try
            {
                int retorno = _clienteServicio.InsertarCliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento);

                MessageBox.Show("Cliente Ingresado Exitosamente. Cliente ID: " + retorno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR -> " + ex.Message);
            }
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtDni_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                e.Cancel = true;
                errorProviderDni.SetError(txtDni, "Debe ingresar un dato.");
            }
            else
            {
                e.Cancel = false;
                errorProviderDni.SetError(txtDni, "");
            }
        }
    }
}
