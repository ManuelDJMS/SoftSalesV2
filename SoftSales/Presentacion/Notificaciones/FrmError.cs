using System;
using System.Windows.Forms;

namespace Presentacion.Notificaciones
{
    public partial class FrmError : Form
    {
        public FrmError(string titulo, string nombre)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
            lbMensaje.Text = nombre;
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        public static void Confirmacion(string titulo, string mensaje)
        {
            FrmError frm = new FrmError(titulo, mensaje);
            frm.Show();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
