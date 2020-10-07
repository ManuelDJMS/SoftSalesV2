using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = false;
            btnClose.Visible = false;
            btnShow.Visible = true;
            LbIcon.Visible = false;
            ImgIcon.Visible = false;
            PanelLateral.Width = 38;
            gunaTransition1.ShowSync(PanelLateral);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnClose.Visible = true;
            PanelLateral.Visible = false;
            LbIcon.Visible = true;
            ImgIcon.Visible = true;
            PanelLateral.Width = 175;
            gunaTransition1.ShowSync(PanelLateral);
        }
    }
}
