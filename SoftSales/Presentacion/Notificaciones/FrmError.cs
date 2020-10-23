using System;
using System.Windows.Forms;

namespace Presentacion.Notificaciones
{
    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
