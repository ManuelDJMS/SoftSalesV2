using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Presentacion.Notificaciones
{
    public partial class FrmSuccess : Form
    {
        public FrmSuccess(string titulo, string mensaje)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
            lbMensaje.Text = mensaje;

        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
            //gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.;
            gunaAnimateWindow1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.Focus();
        }

        public static void Confirmacion(string titulo, string mensaje)
        {
            FrmSuccess frm = new FrmSuccess(titulo, mensaje);
            frm.Show();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSuccess_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
