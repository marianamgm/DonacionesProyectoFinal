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
    public partial class frmAnimales : Form
    {
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adoc adoc = new Adoc();
            adoc.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaprins = new frmPaginaPrincipal();
            paginaprins.Show();
        }
    }
}
