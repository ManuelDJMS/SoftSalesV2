using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            gunaAnimateWindow1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            //Guna.UI.Lib.GraphicsHelper.DrawLineShadow(PanelLateral, Color.Blue, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalRight);
        }
    }
}
