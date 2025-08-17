using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DonacionesProyectoFinal
{
    public partial class DocumentacionRefugios : Form
    {
        SolicitudControlador controlador = new SolicitudControlador();
        public DocumentacionRefugios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Limpiar()
        {
            nombrer.Text = "";
            telefonor.Text = "";
            emailr.Text = "";
            direccionr.Text = "";
            curpr.Text = "";
            descripcionr.Text = "";
            nombrer.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombrer.Text.Trim() == "" || telefonor.Text.Trim() == "" || emailr.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Solicitud solicitud = new Solicitud()
            {
                Categoria = "Refugios",
                Nombre = nombrer.Text,
                Telefono = telefonor.Text,
                Email = emailr.Text,
                Domicilio = direccionr.Text,
                CURP = curpr.Text,
                Descripcion = descripcionr.Text
            };



            bool guardo = controlador.AgregarSolicitud(solicitud);

            if (guardo)
            {
                MessageBox.Show("Solicitud enviada correctamente.");
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la solicitud.");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
