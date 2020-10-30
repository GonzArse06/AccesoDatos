using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Cliente
    {
        private int _id;
        private string _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _mail;
        private string _telefono;
        private DateTime _fechaNacimiento; 
        private bool _activo;

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Dni { get => _dni; set => _dni = value; }

        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name ="apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }
        
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string email { get => _mail; set => _mail = value; }

        public string Telefono { get => _telefono; set => _telefono = value; }

        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public string NombreCompleto { get => _apellido + " - " + _nombre; }


        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}",this._apellido,this._nombre);
        }
    }
}
