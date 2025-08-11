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
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void donarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMadresSolteras madressoltera = new frmMadresSolteras();
            madressoltera.Show();
        }

        private void donarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAnimales animales = new frmAnimales();
            animales.Show();
        }

        private void donarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRefugios refugios = new frmRefugios();
            refugios.Show();
        }

        private void donarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPersonasSinHogar persh = new frmPersonasSinHogar();
            persh.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
