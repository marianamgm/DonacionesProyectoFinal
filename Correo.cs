using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DonacionesProyectoFinal
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }

        private void btnCrearcuenta_Click(object sender, EventArgs e)
        {

            if (btnCrearcuenta.Text == "" || textContraseña.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }


            MessageBox.Show("Cuenta creada con correo.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
