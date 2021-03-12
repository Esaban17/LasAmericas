using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasAmericas.Models
{
    public class ClienteModel
    {
        int idCliente;
        private string nombre;
        private string direccion;

        public ClienteModel()
        {
                
        }

        public ClienteModel(int idCliente, string nombre, string direccion)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Direccion = direccion;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
