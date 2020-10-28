using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayer.Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper mapper;

        public CuentaServicio()
        {
            mapper = new CuentaMapper();
        }
        public List<Cuenta> TraerCuentas()
        {
            return mapper.TraerTodo();
        }
        public int IngresarCuenta(int nroCuenta, string descripcion, double saldo, DateTime fechaApertura,int idCliente)
        {
            List<Cuenta> lstCuentas = mapper.TraerTodo();

            Cuenta nuevaCuenta = new Cuenta();
            nuevaCuenta.NroCuenta = nroCuenta;
            nuevaCuenta.Descripcion = descripcion;
            nuevaCuenta.Saldo = saldo;
            nuevaCuenta.FechaApertura = fechaApertura;
            nuevaCuenta.FechaModificacion = DateTime.Now;
            nuevaCuenta.Activo = true;
            nuevaCuenta.IdCliente = idCliente;

            TransactionResult resultado = mapper.Insert(nuevaCuenta);
            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("No se pudo finalizar el insert");
        }

    }
}
