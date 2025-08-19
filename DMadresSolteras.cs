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
    public partial class DMadresSolteras : Form
    {
        SDonacionControlador controlado = new SDonacionControlador();
        public DMadresSolteras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
            

        private void DMadresSolteras_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if(tnombrems.Text.Trim() == "" || ttelefonoms.Text.Trim() == "" || temailms.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Donaciones donaciones = new Donaciones()
            {
                dCategoria = "Madres Solteras",
                dNombre = tnombrems.Text,
                dTelefono = ttelefonoms.Text,
                dEmail = temailms.Text,
                dDireccion = tdireccionms.Text,
                dCURP = tcurpms.Text,
                dDescripcion = tdescripcionms.Text
            };



            bool guardo = controlado.AgregarDonacion(donaciones);

            if (guardo)
            {
                MessageBox.Show("Donacion enviada correctamente.");
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la solicitud.");
        }
    }
}
    

