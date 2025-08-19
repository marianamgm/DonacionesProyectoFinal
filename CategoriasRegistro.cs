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
        SolicitudControlador controlador = new SolicitudControlador();

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
        private void FrmGestionSolicitudes_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();  
        }

        
        private void CargarSolicitudes()
        {
            SolicitudControlador controlador = new SolicitudControlador();
            var lista = controlador.ListarSolicitud();

            Grid.DataSource = null; 
            Grid.DataSource = lista.Select(x => new
            {
                x.Id,
                x.Nombre,
                x.Email,
                x.CURP,
                x.Telefono,
                x.Domicilio,
                x.Categoria
            }).ToList();
        }

        void llenarGrid()
        {
            List<Solicitud> solicitudes = controlador.ListarSolicitud();
            Grid.DataSource = solicitudes;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0)
            {
                cs_id.Enabled = false;
                cs_id.Text = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0)
            {
                cs_id.Text = Grid[0, e.RowIndex].Value.ToString();
                cs_nombre.Text = Grid[1, e.RowIndex].Value.ToString();
                cs_curp.Text = Grid[2, e.RowIndex].Value.ToString();
                cs_telefono.Text = Grid[3, e.RowIndex].Value.ToString();
                cs_email.Text = Grid[4, e.RowIndex].Value.ToString();
                cs_direccion.Text = Grid[5, e.RowIndex].Value.ToString();
                cs_descripcion.Text = Grid[6, e.RowIndex].Value.ToString();
                cs_categoria.Text = Grid[7, e.RowIndex].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(cs_id.Text) ? 0 : Convert.ToInt32(cs_id.Text);

            Solicitud sol = new Solicitud(
                id,
                cs_nombre.Text,
                cs_curp.Text,
                cs_telefono.Text,
                cs_email.Text,
                cs_direccion.Text,
                cs_descripcion.Text,
                cs_categoria.Text
            );

            bool guardo;
            if (id == 0)
                guardo = controlador.AgregarSolicitud(sol);
            else
                guardo = controlador.ActualizarSolicitud(sol);

            if (guardo)
            {
                MessageBox.Show("Solicitud guardada correctamente.");
                llenarGrid();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cs_id.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione una solicitud para eliminar.");
                return;
            }

            int id = Convert.ToInt32(cs_id.Text);
            if (MessageBox.Show("¿Desea eliminar la solicitud?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool elimino = controlador.EliminarSolicitud(id);
                if (elimino)
                {
                    MessageBox.Show("Solicitud eliminada.");
                    llenarGrid();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }
    }
}
    

