using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DonacionesProyectoFinal;

namespace ejemploLogin
{
    public partial class FMadresSolteras : Form
    {
        SolicitudesControlador controlador = new SolicitudesControlador();

        public FMadresSolteras()
        {
            InitializeComponent();
        }

        private void frmMadresSolteras_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            text_nombrems.Text = "";
            text_telms.Text = "";
            text_emailms.Text = "";
            text_direccionms.Text = "";
            text_curpms.Text = "";
            text_desms.Text = "";
            text_nombrems.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
        }
            

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (text_nombrems.Text.Trim() == "" || text_telms.Text.Trim() == "" || text_emailms.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Solicitud solicitud = new Solicitud()
            {
                UsuarioId = 1,
                Categoria = "Madres Solteras",
                Nombre = text_nombrems.Text,
                Telefono = text_telms.Text,
                Email = text_emailms.Text,
                Domicilio = text_direccionms.Text,
                Curp = text_curpms.Text,
                Descripcion = text_desms.Text
            };


            bool guardo = controlador.AgregarSolicitud(solicitud);

            if (guardo)
            {
                MessageBox.Show("Solicitud enviada correctamente.");
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo enviar la solicitud.");
        }
    }
    }



       