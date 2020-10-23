namespace Presentacion.Notificaciones
{
    partial class FrmError
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmError));
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbMensaje.Location = new System.Drawing.Point(12, 102);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(240, 42);
            this.lbMensaje.TabIndex = 6;
            this.lbMensaje.Text = "La categoría se guardo correctamente.";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbTitulo.Location = new System.Drawing.Point(47, 78);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(175, 24);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "Guardado Exitoso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AnimationHoverSpeed = 0.07F;
            this.btnAceptar.AnimationSpeed = 0.03F;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BaseColor = System.Drawing.Color.White;
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAceptar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAceptar.CheckedForeColor = System.Drawing.Color.White;
            this.btnAceptar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.CheckedImage")));
            this.btnAceptar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAceptar.Location = new System.Drawing.Point(67, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnAceptar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnHoverImage = null;
            this.btnAceptar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAceptar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnAceptar.Radius = 15;
            this.btnAceptar.Size = new System.Drawing.Size(118, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.icons8_cancel_64;
            this.pictureBox1.Location = new System.Drawing.Point(96, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 200;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 194);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmError";
            this.Load += new System.EventHandler(this.FrmError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnAceptar;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
    }
}