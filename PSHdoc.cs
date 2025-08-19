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

    public partial class PSHdoc : Form
    {
        SDonacionControlador controlado = new SDonacionControlador();
        public PSHdoc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dpnombre.Text.Trim() == "" || dptelefono.Text.Trim() == "" || dpemail.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Donaciones donaciones = new Donaciones()
            {
                dCategoria = "Personas sin hogar",
                dNombre = dpnombre.Text,
                dTelefono = dptelefono.Text,
                dEmail = dpemail.Text,
                dDireccion = dpdir.Text,
                dCURP = dpcurp.Text,
                dDescripcion = dpdescripcion.Text
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

