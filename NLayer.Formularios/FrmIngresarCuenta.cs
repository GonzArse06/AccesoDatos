using NLayer.Entidades;
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
    public partial class FrmIngresarCuenta : Form
    {
        private ClienteServicio cliente;
        private CuentaServicio cuenta;
        List<Cliente> _listadoClientes;
        public int _idCliente;
        public int IdCliente { set => _idCliente=value; }

        public FrmIngresarCuenta()
        {
            InitializeComponent();
            cliente = new ClienteServicio();
            cuenta = new CuentaServicio();
        }

        private void FrmIngresarCuenta_Load(object sender, EventArgs e)
        {
            _listadoClientes = cliente.TraerClientes();
            //cbCliente.DataSource = _listadoClientes;
            //cbCliente.DisplayMember = "NombreCompleto";
            //cbCliente.ValueMember = "Id";
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            tlblFooter.Text = "";
            //int nrocuenta = int.Parse(txtNroCuenta.Text);
            string descripcion = txtDescripcion.Text;
            //DateTime fechaApertura = dtFechaApertura.Value;
            int idCliente = int.Parse(txtidCliente.Text);
            //double saldo = double.Parse(txtSaldo.Text);

            try
            {
                int resultado = cuenta.IngresarCuenta(descripcion, idCliente);
                //MessageBox.Show("Ingreso exitosamente - ID " + resultado);
                tlblFooter.ForeColor = Color.GreenYellow;
                tlblFooter.Text = "Ingreso exitosamente - ID " + resultado;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error -> "+ ex.Message); 
                tlblFooter.ForeColor = Color.Red;
                tlblFooter.Text = "Error -> " + ex.Message;
            }

            //limpio controles
            //foreach (Control a in Controls) -> limpia labels jaja Revisar
            //    a.Text = "";
            limpiarControles();
        }
        private void limpiarControles()
        {
            txtDescripcion.Clear();
            txtidCliente.Clear();
            txtNombreCliente.Clear();;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente formulario = new FrmBuscarCliente(_listadoClientes);
            formulario.Owner = this;
            formulario.ShowDialog();
            txtidCliente.Text = _idCliente.ToString();
            BuscarNombreCliente(_idCliente);
        }
        private void BuscarNombreCliente(int idCliente)
        {
            Cliente auxCliente = _listadoClientes.FirstOrDefault(x => x.Id == idCliente);
            if (auxCliente == null)
                MessageBox.Show("No existe el usuario, reintente");
            else
                txtNombreCliente.Text = auxCliente.NombreCompleto;
        }

        private void txtidCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarNombreCliente(int.Parse(txtidCliente.Text));
            }
        }
    }
}
