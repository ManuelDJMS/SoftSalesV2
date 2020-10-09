namespace Presentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaResize gunaResize1;
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.PnTop = new Guna.UI.WinForms.GunaPanel();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.LbIcon = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.PanelLateral = new Guna.UI.WinForms.GunaPanel();
            this.gunaAdvenceButton9 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaAdvenceButton8 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton7 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton5 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.btnShow = new Guna.UI.WinForms.GunaCircleButton();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaResize1
            // 
            gunaResize1.TargetForm = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.PnTop;
            // 
            // PnTop
            // 
            this.PnTop.BackColor = System.Drawing.Color.White;
            this.PnTop.Controls.Add(this.LbIcon);
            this.PnTop.Controls.Add(this.ImgIcon);
            this.PnTop.Controls.Add(this.gunaControlBox2);
            this.PnTop.Controls.Add(this.gunaControlBox3);
            this.PnTop.Controls.Add(this.gunaControlBox1);
            this.gunaTransition1.SetDecoration(this.PnTop, Guna.UI.Animation.DecorationType.None);
            this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTop.Location = new System.Drawing.Point(0, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(984, 31);
            this.PnTop.TabIndex = 2;
            // 
            // ImgIcon
            // 
            this.gunaTransition1.SetDecoration(this.ImgIcon, Guna.UI.Animation.DecorationType.None);
            this.ImgIcon.Image = global::Presentacion.Properties.Resources.LOGO2;
            this.ImgIcon.Location = new System.Drawing.Point(0, -3);
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Size = new System.Drawing.Size(57, 43);
            this.ImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgIcon.TabIndex = 0;
            this.ImgIcon.TabStop = false;
            // 
            // LbIcon
            // 
            this.LbIcon.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.LbIcon, Guna.UI.Animation.DecorationType.None);
            this.LbIcon.Font = new System.Drawing.Font("Eras Light ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(73)))));
            this.LbIcon.Location = new System.Drawing.Point(40, 4);
            this.LbIcon.Name = "LbIcon";
            this.LbIcon.Size = new System.Drawing.Size(132, 27);
            this.LbIcon.TabIndex = 1;
            this.LbIcon.Text = "SOFT-SALES";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(73)))));
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaControlBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(887, -1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Blue;
            this.gunaControlBox2.Size = new System.Drawing.Size(32, 32);
            this.gunaControlBox2.TabIndex = 3;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(73)))));
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaControlBox3, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox3.IconColor = System.Drawing.Color.White;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(919, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(32, 32);
            this.gunaControlBox3.TabIndex = 4;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaControlBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(951, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(29)))), ((int)(((byte)(68)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(32, 32);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.White;
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton9);
            this.PanelLateral.Controls.Add(this.gunaSeparator1);
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton8);
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton7);
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton6);
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton5);
            this.PanelLateral.Controls.Add(this.gunaAdvenceButton1);
            this.gunaTransition1.SetDecoration(this.PanelLateral, Guna.UI.Animation.DecorationType.None);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 31);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(175, 530);
            this.PanelLateral.TabIndex = 3;
            // 
            // gunaAdvenceButton9
            // 
            this.gunaAdvenceButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaAdvenceButton9.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton9.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton9.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton9.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton9.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton9.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton9.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton9.CheckedImage")));
            this.gunaAdvenceButton9.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton9, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton9.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton9.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton9.Image = global::Presentacion.Properties.Resources.icons8_settings_32;
            this.gunaAdvenceButton9.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton9.LineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton9.Location = new System.Drawing.Point(0, 484);
            this.gunaAdvenceButton9.Name = "gunaAdvenceButton9";
            this.gunaAdvenceButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton9.OnHoverImage = null;
            this.gunaAdvenceButton9.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton9.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton9.TabIndex = 11;
            this.gunaAdvenceButton9.Text = "Ajustes";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaTransition1.SetDecoration(this.gunaSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 400);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(160, 10);
            this.gunaSeparator1.TabIndex = 10;
            // 
            // gunaAdvenceButton8
            // 
            this.gunaAdvenceButton8.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton8.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton8.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton8.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton8.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton8.CheckedImage")));
            this.gunaAdvenceButton8.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton8, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton8.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton8.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.Image = global::Presentacion.Properties.Resources.icons8_categorize_32;
            this.gunaAdvenceButton8.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton8.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaAdvenceButton8.Location = new System.Drawing.Point(0, 59);
            this.gunaAdvenceButton8.Name = "gunaAdvenceButton8";
            this.gunaAdvenceButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton8.OnHoverImage = null;
            this.gunaAdvenceButton8.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton8.TabIndex = 9;
            this.gunaAdvenceButton8.Text = "Categorias";
         
            // 
            // gunaAdvenceButton7
            // 
            this.gunaAdvenceButton7.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton7.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton7.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton7.CheckedImage")));
            this.gunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton7, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton7.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton7.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.Image = global::Presentacion.Properties.Resources.icons8_contacts_32__1_;
            this.gunaAdvenceButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton7.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaAdvenceButton7.Location = new System.Drawing.Point(0, 101);
            this.gunaAdvenceButton7.Name = "gunaAdvenceButton7";
            this.gunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.OnHoverImage = null;
            this.gunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton7.TabIndex = 8;
            this.gunaAdvenceButton7.Text = "Clientes";
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton6.CheckedImage")));
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton6, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Image = global::Presentacion.Properties.Resources.icons8_checkout_32;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(0, 143);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton6.TabIndex = 7;
            this.gunaAdvenceButton6.Text = "Compras";
            // 
            // gunaAdvenceButton5
            // 
            this.gunaAdvenceButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton5.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton5.CheckedImage")));
            this.gunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton5, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton5.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton5.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Image = global::Presentacion.Properties.Resources.icons8_cash_register_32;
            this.gunaAdvenceButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton5.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaAdvenceButton5.Location = new System.Drawing.Point(0, 185);
            this.gunaAdvenceButton5.Name = "gunaAdvenceButton5";
            this.gunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.OnHoverImage = null;
            this.gunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton5.TabIndex = 6;
            this.gunaAdvenceButton5.Text = "Ventas";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.gunaAdvenceButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = global::Presentacion.Properties.Resources.icons8_open_box_32;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(0, 17);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(175, 42);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "Artículos";
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // PanelFormularios
            // 
            this.gunaTransition1.SetDecoration(this.PanelFormularios, Guna.UI.Animation.DecorationType.None);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(175, 31);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(809, 530);
            this.PanelFormularios.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BaseColor = System.Drawing.SystemColors.Control;
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnShow, Guna.UI.Animation.DecorationType.None);
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::Presentacion.Properties.Resources.icons8_next;
            this.btnShow.ImageSize = new System.Drawing.Size(28, 28);
            this.btnShow.Location = new System.Drawing.Point(21, 415);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.OnPressedDepth = 0;
            this.btnShow.Size = new System.Drawing.Size(40, 40);
            this.btnShow.TabIndex = 5;
            this.btnShow.UseTransfarantBackground = true;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.SystemColors.Control;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnClose, Guna.UI.Animation.DecorationType.None);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Presentacion.Properties.Resources.icons8_back_28;
            this.btnClose.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Location = new System.Drawing.Point(155, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.OnPressedDepth = 0;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseTransfarantBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PanelFormularios);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PnTop);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel PnTop;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LbIcon;
        private Guna.UI.WinForms.GunaPanel PanelLateral;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton8;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton7;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton5;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton9;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private Guna.UI.WinForms.GunaCircleButton btnShow;
        private System.Windows.Forms.Panel PanelFormularios;
    }
}

