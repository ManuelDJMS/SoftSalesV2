using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Notificaciones
{
   
    public partial class FrmAlert : Form
    {
        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }
        int x, y;
        public FrmAlert()
        {
            InitializeComponent();
        }
        public void setAlert(string msg, alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FrmAlert f = (FrmAlert)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case FrmAlert.alertTypeEnum.Success:
                    this.GunaPictureBox1.Image = Properties.Resources.icons8_checkmark_48;
                    this.BackColor = Color.FromArgb(42, 171, 160);
                    break;
                case FrmAlert.alertTypeEnum.Error:
                    this.GunaPictureBox1.Image = Properties.Resources.icons8_box_important_52;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;
                    //case FrmAlert.alertTypeEnum.Error:
                    //    this.GunaPictureBox1.Image = Properties.Resources.Error_28px;
                    //    this.BackColor = Color.FromArgb(255, 179, 2);255, 121, 70
                    //    break;
                    //case FrmAlert.alertTypeEnum.Info:
                    //    this.GunaPictureBox1.Image = Properties.Resources.Info_28px;
                    //    this.BackColor = Color.FromArgb(71, 169, 248);
                    //    break;
            }
            this.GunaLabel1.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private FrmAlert.actionEnum action;
        private void GunaPictureBox2_Click_1(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = FrmAlert.actionEnum.close;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case FrmAlert.actionEnum.wait:
                    this.timer1.Interval = 5000;
                    this.action = FrmAlert.actionEnum.close;
                    break;
                case FrmAlert.actionEnum.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = FrmAlert.actionEnum.wait;
                        }
                    }
                    break;
                case FrmAlert.actionEnum.close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
