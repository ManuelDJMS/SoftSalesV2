using System;
using System.Windows.Forms;
using Presentacion.Notificaciones;
using SoftSales.Negocio;
namespace Presentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgCategorias.DataSource = NCategoria.Listar();
                this.Formato();
                //this.Limpiar();
                //LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgCategorias.Columns[0].Width = 75;
            DgCategorias.Columns[3].Width = 60;
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtidCategoria.Text = "";
            txtDescripcion.Text = "";

        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.Listar();
            Error.SetError(txtNombre, "Ingrese un nombre.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string respuesta = "";
                if (txtNombre.Text == string.Empty)
                {
                    Error.SetError(txtNombre, "Ingrese un nombre");
                }
                else
                {
                    respuesta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        FrmSuccess.Confirmacion("Guardado Exitoso", "La categoría se guardo correctamente.");
                        this.Limpiar();
                        this.Formato();

                    }
                    else
                    {
                        MessageBox.Show("Respuesta");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
