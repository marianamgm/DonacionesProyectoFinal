using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemploLogin;

namespace DonacionesProyectoFinal
{
    public partial class frmMadresSolteras : Form
    {
        public frmMadresSolteras()
        {
            InitializeComponent();
        }

        private void frmMadresSolteras_Load(object sender, EventArgs e)
        {
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            FMadresSolteras madress = new FMadresSolteras();
            madress.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaprins = new frmPaginaPrincipal();
            paginaprins.Show();
        }
    }
}

