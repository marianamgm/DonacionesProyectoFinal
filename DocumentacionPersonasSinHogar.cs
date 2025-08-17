using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesProyectoFinal
{
    public partial class DocumentacionPersonasSinHogar : Form
    {
        SolicitudControlador controlador = new SolicitudControlador();
        public DocumentacionPersonasSinHogar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void Limpiar()
        {
            nombrepsh.Text = "";
            telefonopsh.Text = "";
            emailpsh.Text = "";
            direccionpsh.Text = "";
            curppsh.Text = "";
            descripcionpsh.Text = "";
            nombrepsh.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (nombrepsh.Text.Trim() == "" || telefonopsh.Text.Trim() == "" || emailpsh.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Solicitud solicitud = new Solicitud()
            {
                Categoria = "Personas sin hogar",
                Nombre = nombrepsh.Text,
                Telefono = telefonopsh.Text,
                Email = emailpsh.Text,
                Domicilio = direccionpsh.Text,
                CURP = curppsh.Text,
                Descripcion = descripcionpsh.Text,
            };



            bool guardo = controlador.AgregarSolicitud(solicitud);

            if (guardo)
            {
                MessageBox.Show("Solicitud enviada correctamente.");
                Limpiar();
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la solicitud.");
        }

    }
}
    
