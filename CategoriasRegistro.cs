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
    public partial class CategoriasRegistro : Form
    {
        SolicitudesControlador constructor = new SolicitudesControlador();

        public CategoriasRegistro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoriasRegistro_Load(object sender, EventArgs e)
        {

        }

        void llenarGrid()
        {
            List<Solicitud> solicitudes = constructor.ListarSolicitudes();
            Grid.DataSource = solicitudes;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0)
            {
                cs_id.Enabled = false;
                cs_id.Text = Grid[0, e.RowIndex].Value.ToString();
                cs_nombre.Text = Grid[1, e.RowIndex].Value.ToString();
                cs_email.Text = Grid[2, e.RowIndex].Value.ToString();
                cs_telefono.Text = Grid[3, e.RowIndex].Value.ToString();
                cs_curp.Text = Grid[4, e.RowIndex].Value.ToString();
                cs_direccion.Text = Grid[5, e.RowIndex].Value.ToString();
                cs_descripcion.Text = Grid[6, e.RowIndex].Value.ToString();
            }

        }
        void Limpiar()
        {
            cs_id.Enabled = true;
            cs_id.Text = "";
            cs_nombre.Text = "";
            cs_email.Text = "";
            cs_telefono.Text = "";
            cs_curp.Text = "";
            cs_direccion.Text = "";
            cs_direccion.Text = "";
            cs_id.Focus();
        }
    }
}
