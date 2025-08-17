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
  
    public partial class DonacionesRegistro : Form
    {
        SDonacionControlador controlado = new SDonacionControlador();
        public DonacionesRegistro()
        {
            InitializeComponent();
        }

        private void btnNuevoD_Click(object sender, EventArgs e)
        {
           
        }
        void Limpiar()
        {
            cd_id.Enabled = true;
            cd_id.Text = "";
            cd_nombre.Text = "";
            cd_email.Text = "";
            cd_telefono.Text = "";
            cd_curp.Text = "";
            cd_direccion.Text = "";
            cd_direccion.Text = "";
            cd_categoria.Text = "";
            cd_descripcion.Text = "";
            cd_id.Focus();
        }
        void llenarGrid()
        {
            List<Donaciones> donaciones = controlado.ListarDonacion();
            GridD.DataSource = donaciones;
        }

        private void DonacionesRegistro_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GridD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridD.Rows.Count > 0)
            {
                cd_id.Enabled = false;
                cd_id.Text = GridD[0, e.RowIndex].Value.ToString();
                cd_nombre.Text = GridD[1, e.RowIndex].Value.ToString();
                cd_email.Text = GridD[2, e.RowIndex].Value.ToString();
                cd_telefono.Text = GridD[3, e.RowIndex].Value.ToString();
                cd_curp.Text = GridD[4, e.RowIndex].Value.ToString();
                cd_direccion.Text = GridD[5, e.RowIndex].Value.ToString();
                cd_descripcion.Text = GridD[6, e.RowIndex].Value.ToString();
            }
        }
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridD.Rows.Count > 0)
            {
                cd_id.Text = GridD[0, e.RowIndex].Value.ToString();
                cd_nombre.Text = GridD[1, e.RowIndex].Value.ToString();
                cd_curp.Text = GridD[2, e.RowIndex].Value.ToString();
                cd_telefono.Text = GridD[3, e.RowIndex].Value.ToString();
                cd_email.Text = GridD[4, e.RowIndex].Value.ToString();
                cd_direccion.Text = GridD[5, e.RowIndex].Value.ToString();
                cd_descripcion.Text = GridD[6, e.RowIndex].Value.ToString();
                cd_categoria.Text = GridD[7, e.RowIndex].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btnGuardarD_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(cd_id.Text) ? 0 : Convert.ToInt32(cd_id.Text);

            Donaciones donaciones = new Donaciones(
                id,
                cd_nombre.Text,
                cd_curp.Text,
                cd_telefono.Text,
                cd_email.Text,
                cd_direccion.Text,
                cd_descripcion.Text,
                cd_categoria.Text
            );

            bool guardo;
            if (id == 0)
                guardo = controlado.AgregarDonacion(donaciones);
            else
                guardo = controlado.ActualizarDonacion(donaciones);

            if (guardo)
            {
                MessageBox.Show("Donación guardada correctamente.");
                llenarGrid();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            if (cd_id.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione una Donación para eliminar.");
                return;
            }

            int id = Convert.ToInt32(cd_id.Text);
            if (MessageBox.Show("¿Desea eliminar la Donación?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool elimino = controlado.EliminarDonacion(id);
                if (elimino)
                {
                    MessageBox.Show("Donación eliminada.");
                    llenarGrid();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
