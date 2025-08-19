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
    public partial class Tipo_de_cuenta : Form
    {
        public Tipo_de_cuenta()
        {
            InitializeComponent();
        }

        private void btncrearcuenta_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Redirigiendo a creación de cuenta...");
        }

        private void btnContinuarcon_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Por Favor seleccione una opción");
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            Correo correoForm = new Correo();
            correoForm.Show();
            this.Hide();
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            Google googleForm = new Google();
            googleForm.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
