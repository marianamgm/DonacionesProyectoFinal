using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesProyectoFinal
{
    internal class Solicitud
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CURP { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

        public Solicitud()
        {
        }

        public Solicitud(int id, string nombre, string curp, string telefono, string email, string domicilio, string descripcion, string categoria)
        {
            Id = id;
            Nombre = nombre;
            CURP = curp;
            Telefono = telefono;
            Email = email;
            Domicilio = domicilio;
            Descripcion = descripcion;
            Categoria = categoria;
        }
    }
}





