using Newtonsoft.Json;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public class ClienteMapper
    {
        const string numeroRegistro = "852017";
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/cliente/"+ConfigurationManager.AppSettings["Legajo"]); // trae un texto en formato json de una web
            //string json2 = WebHelper.Get("/cliente/");
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            
            string result = WebHelper.Post("/cliente", obj);
            
            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Ape);
            n.Add("Direccion", cliente.Direccion);                        
            n.Add("Email", cliente.email); // STRING
            n.Add("Telefono", cliente.Telefono.ToString()); // INT
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToShortDateString()); // DateTime
            n.Add("Activo", cliente.Activo.ToString()); // bool
            n.Add("Dni", cliente.Dni);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            //n.Add("Usuario", numeroRegistro);
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }


        //private Cliente MapObj(string json)
        //{
        //    var lst = JsonConvert.DeserializeObject<Cliente>(json);
        //    return lst;
        //}
        //public Cliente TraerPorCodigo(int codigo)
        //{
        //    string json2 = WebHelper.Get("/api/v1/cliente/" + codigo.ToString()); // trae un texto en formato json de una web
        //    Cliente resultado = MapObj(json2);
        //    return resultado;
        //}
    }
}
