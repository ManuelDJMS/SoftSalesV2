using System;
using System.Windows.Forms;

namespace Presentacion.Notificaciones
{
    public partial class FrmQuestionSuccess : Form
    {
        public FrmQuestionSuccess(string mensaje)
        {
            InitializeComponent();
            lbMensaje.Text = mensaje;
        }
        public static void Confirmacion(string mensaje)
        {
            FrmQuestionSuccess frm = new FrmQuestionSuccess(mensaje);
            frm.Show();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmQuestionSuccess_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
