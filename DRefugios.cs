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
    public partial class DRefugios : Form
    {
        SolicitudControlador controlador = new SolicitudControlador();
        public DRefugios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rdoc rdoc = new Rdoc();
            rdoc.Show();
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
                Limpiar();
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la solicitud.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

