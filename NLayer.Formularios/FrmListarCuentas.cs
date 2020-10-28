using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLayer.Entidades;
using NLayer.Negocio;

namespace NLayer.Formularios
{
    public partial class FrmListarCuentas : Form
    {
        CuentaServicio cuenta;
        public FrmListarCuentas()
        {
            InitializeComponent();
            cuenta = new CuentaServicio();
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            List<Cuenta> lst = cuenta.TraerCuentas();
            listBox1.DataSource = null;
            listBox1.DataSource = lst;
        }
    }
}
