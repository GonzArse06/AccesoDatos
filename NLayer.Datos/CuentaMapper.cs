using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLayer.Entidades;
using System.Collections.Specialized;
using System.Configuration;


namespace NLayer.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodo()
        {
            string json = WebHelper.Get("/cuenta");
            List<Cuenta> retorno = MapList(json);
            return retorno;

        }
        private List<Cuenta> MapList(string json)
        {
            List<Cuenta> retorno = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return retorno;
        }


        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection objeto = ReverseMap(cuenta);
            string resultado = WebHelper.Post("/cuenta", objeto);
            TransactionResult resultadoTransaccion = MapResultado(resultado);
            return resultadoTransaccion;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            n.Add("FechaApertura", cuenta.FechaApertura.ToString());
            n.Add("FechaModificacion", cuenta.FechaModificacion.ToString());
            n.Add("Activo", cuenta.Activo.ToString()); 
            n.Add("idCliente", cuenta.IdCliente.ToString());
            return n;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
