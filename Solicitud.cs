using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesProyectoFinal
{
    internal class Solicitud
    {
        private int Sol_Solicitud_Id;
        private string Sol_Nombre;
        private string Sol_CURP;
        private string Sol_Telefono;
        private string Sol_Email;
        private string Sol_Domicilio;
        private string Sol_Descripcion;
        private string Sol_Categoria;

        public Solicitud(int sol_Solicitud_Id, string sol_Nombre, string sol_CURP, string sol_Telefono, string sol_Email, string sol_Domicilio, string sol_Descripcion)
        {
            this.Sol_Solicitud_Id = sol_Solicitud_Id;
            this.Sol_Nombre = sol_Nombre;
            this.Sol_CURP = sol_CURP;
            this.Sol_Telefono = sol_Telefono;
            this.Sol_Email = sol_Email;
            this.Sol_Domicilio = sol_Domicilio;
            this.Sol_Descripcion = sol_Descripcion;
        }

        public int Sol_Solicitud_Id1 { get => Sol_Solicitud_Id; set => Sol_Solicitud_Id = value; }
        public string Sol_Nombre1 { get => Sol_Nombre; set => Sol_Nombre = value; }
        public string Sol_CURP1 { get => Sol_CURP; set => Sol_CURP = value; }
        public string Sol_Telefono1 { get => Sol_Telefono; set => Sol_Telefono = value; }
        public string Sol_Email1 { get => Sol_Email; set => Sol_Email = value; }
        public string Sol_Domicilio1 { get => Sol_Domicilio; set => Sol_Domicilio = value; }
        public string Sol_Descripcion1 { get => Sol_Descripcion; set => Sol_Descripcion = value; }
        public string Sol_Categoria1 { get => Sol_Categoria; set => Sol_Categoria = value; }
    }
}
