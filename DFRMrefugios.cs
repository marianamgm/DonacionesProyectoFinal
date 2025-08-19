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
    public partial class DFRMrefugios : Form
    {
        public DFRMrefugios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rdoc rdoc = new Rdoc();
            rdoc.Show();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaprins = new frmPaginaPrincipal();
            paginaprins.Show();
        }
    }
}
