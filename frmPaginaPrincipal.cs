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

        private void frmPaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void donarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMadresSolteras madressoltera = new frmMadresSolteras();
            madressoltera.Show();
        }

        private void donarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmAnimales animales = new frmAnimales();
            animales.Show();
        }

        private void donarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmRefugios refugios = new frmRefugios();
            refugios.Show();
        }

        private void donarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            frmPersonasSinHogar persh = new frmPersonasSinHogar();
            persh.Show();
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DFRMmadressolteras Dms = new DFRMmadressolteras();
           Dms.Show();
        }

        private void solicitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DFRManimalescs animaa = new DFRManimalescs();
            animaa.Show();
        }

        private void solicitarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DFRMrefugios dref = new DFRMrefugios();
            dref.Show();
        }

        private void solicitarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DFRMpersonasinhogarcs ddpersh = new DFRMpersonasinhogarcs();
            ddpersh.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasRegistro solicitudesgention = new CategoriasRegistro();
            solicitudesgention.Show();

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
