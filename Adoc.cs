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
    public partial class Adoc : Form
    {
        SolicitudControlador controlador = new SolicitudControlador();
        public Adoc()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            anombre.Text = "";
            atelefono.Text = "";
            aemail.Text = "";
            adireccion.Text = "";
            acurp.Text = "";
            adescripcion.Text = "";
            anombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (anombre.Text.Trim() == "" || atelefono.Text.Trim() == "" || aemail.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Solicitud solicitud = new Solicitud()
            {
                Categoria = "Animales",
                Nombre = anombre.Text,
                Telefono = atelefono.Text,
                Email = aemail.Text,
                Domicilio = adireccion.Text,
                CURP = acurp.Text,
                Descripcion = adescripcion.Text
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

        private void btnNuev_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adoc_Load(object sender, EventArgs e)
        {

        }
    }
    }

