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
    public partial class DFRMpersonasinhogarcs : Form
    {
        public DFRMpersonasinhogarcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DPersonasSinHogar personh = new DPersonasSinHogar();
            personh.Show();
        }
    }
}
