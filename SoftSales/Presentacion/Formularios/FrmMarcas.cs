using SoftSales.Datos;
using SoftSales.Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                DgMarcas.DataSource = NMarcas.Listar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        public void Formato()
        {
            DgMarcas.Columns[2].Width = 85;
            txtDescripcion.BaseColor = Color.WhiteSmoke;
            txtNombre.BaseColor = Color.WhiteSmoke;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
        }
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
