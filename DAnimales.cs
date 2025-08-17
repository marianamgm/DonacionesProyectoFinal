using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DonacionesProyectoFinal
{
    public partial class DAnimales : Form
    {
        SDonacionControlador controlado = new SDonacionControlador();
        public DAnimales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adoc adoc = new Adoc();
            adoc.Show();
        }
        void Limpiar()
        {
            danombre.Text = "";
            datelefono.Text = "";
            daemail.Text = "";
            dadireccion.Text = "";
            dacurp.Text = "";
            dadescripcion.Text = "";
            danombre.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (danombre.Text.Trim() == "" || datelefono.Text.Trim() == "" || daemail.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Donaciones donaciones = new Donaciones()
            {
                dCategoria = "Animales",
                dNombre = danombre.Text,
                dTelefono = datelefono.Text,
                dEmail = daemail.Text,
                dDireccion = dadireccion.Text,
                dCURP = dacurp.Text,
                dDescripcion = dadescripcion.Text
            };



            bool guardo = controlado.AgregarDonacion(donaciones);

            if (guardo)
            {
                MessageBox.Show("Donación enviada correctamente.");
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la Donación.");
        }
        


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DAnimales_Load(object sender, EventArgs e)
        {
        }
           
    }
}
