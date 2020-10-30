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
        public int IngresarCuenta( string descripcion, int idCliente)
        {
            List<Cuenta> lstCuentas = mapper.TraerTodo();
                   

            Cuenta nuevaCuenta = new Cuenta();
            //nuevaCuenta.NroCuenta = nroCuenta;
            nuevaCuenta.Descripcion = descripcion;
            //nuevaCuenta.Saldo = saldo;
            //nuevaCuenta.FechaApertura = fechaApertura;
            //nuevaCuenta.FechaModificacion = DateTime.Now;
            //nuevaCuenta.Activo = true;
            nuevaCuenta.IdCliente = idCliente;

            //Valido que no tenga cuenta cargada.
            Cuenta cuenta = lstCuentas.FirstOrDefault(x => x.IdCliente == idCliente);
            if (cuenta != null)
                throw new Exception("El cliente ya tiene una cuenta cargada. intente con otro.");
            else
            { 
                TransactionResult resultado = mapper.Insert(nuevaCuenta);
                //int nroCuenta = mapper.TraerPorID()
                if (resultado.IsOk)
                    return resultado.Id;
                else
                    throw new Exception(resultado.Error);
            }
        }

    }
}
