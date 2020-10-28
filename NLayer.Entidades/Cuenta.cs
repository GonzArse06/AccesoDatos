using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace NLayer.Entidades
{
    [DataContract]
    public class Cuenta
    {        
        private int _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        [DataMember(Name = "nroCuenta")]
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        [DataMember(Name = "descripcion")]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        [DataMember(Name = "saldo")]
        public double Saldo { get => _saldo; set => _saldo = value; }
        [DataMember(Name = "fechaApertura")]
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        [DataMember(Name = "fechaModificacion")]
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        [DataMember(Name = "activo")]
        public bool Activo { get => _activo; set => _activo = value; }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }


        public override string ToString()
        {
            return string.Format("Cuenta: {0}-IdCliente: {1}",this._nroCuenta,this._idCliente);
        }
    }
}
