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
    public partial class frmRefugios : Form
    {
        public frmRefugios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentacionRefugios docref = new DocumentacionRefugios();
            docref.Show();
        }
    }
}
