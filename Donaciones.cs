using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DonacionesProyectoFinal
{
    internal class Donaciones
    {
      
        public int dId { get; set; }
        public string dNombre { get; set; }
        public string dCURP { get; set; }
        public string dTelefono { get; set; }
        public string dEmail { get; set; }
        public string dDireccion { get; set; }
        public string dDescripcion { get; set; }
        public string dCategoria { get; set; }

  
        public Donaciones()
        {
        }

     
        public Donaciones(int id, string nombre, string curp, string telefono, string email, string direccion, string descripcion, string categoria)
        {
            dId = id;
            dNombre = nombre;
            dCURP = curp;
            dTelefono = telefono;
            dEmail = email;
            dDireccion = direccion;
            dDescripcion = descripcion;
            dCategoria = categoria;
        }
    }
}