using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DonacionesProyectoFinal
{
    public partial class Rdoc : Form
    {
        SDonacionControlador controlado = new SDonacionControlador();
        public Rdoc()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            drnombre.Text = "";
            drtelefono.Text = "";
            dremail.Text = "";
            drdireccion.Text = "";
            drcurp.Text = "";
            drdescripcion.Text = "";
            drnombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (drnombre.Text.Trim() == "" || drtelefono.Text.Trim() == "" || dremail.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Donaciones donaciones = new Donaciones()
            {
                dCategoria = "Refugios",
                dNombre = drnombre.Text,
                dTelefono = drtelefono.Text,
                dEmail = dremail.Text,
                dDireccion = drdireccion.Text,
                dCURP = drcurp.Text,
                dDescripcion = drdescripcion.Text
            };



            bool guardo = controlado.AgregarDonacion(donaciones);

            if (guardo)
            {
                MessageBox.Show("Donación enviada correctamente.");
                this.Close();
            }
            else
                MessageBox.Show("No se pudo enviar la Donación.");
        }

        private void Rdoc_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
    }

