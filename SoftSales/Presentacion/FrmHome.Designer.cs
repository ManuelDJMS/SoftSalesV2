namespace Presentacion
{
    partial class FrmHome
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PanelLateral = new Guna.UI.WinForms.GunaPanel();
            this.btnMostrarMenu = new System.Windows.Forms.PictureBox();
            this.btnAjustes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.btnVentas = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCompras = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClientes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCategorias = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInicio = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOcultarMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PnTop = new Guna.UI.WinForms.GunaPanel();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new Guna.UI.WinForms.GunaControlBox();
            this.btnMaxMin = new Guna.UI.WinForms.GunaControlBox();
            this.btnCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.PanelFormularios = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarMenu)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.White;
            this.PanelLateral.Controls.Add(this.btnMostrarMenu);
            this.PanelLateral.Controls.Add(this.btnAjustes);
            this.PanelLateral.Controls.Add(this.gunaSeparator1);
            this.PanelLateral.Controls.Add(this.gunaPanel3);
            this.PanelLateral.Controls.Add(this.label1);
            this.PanelLateral.Controls.Add(this.btnOcultarMenu);
            this.PanelLateral.Controls.Add(this.pictureBox4);
            this.gunaTransition1.SetDecoration(this.PanelLateral, Guna.UI.Animation.DecorationType.None);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(188, 616);
            this.PanelLateral.TabIndex = 0;
            // 
            // btnMostrarMenu
            // 
            this.btnMostrarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnMostrarMenu, Guna.UI.Animation.DecorationType.None);
            this.btnMostrarMenu.Image = global::Presentacion.Properties.Resources.icons8_chevron_right_48;
            this.btnMostrarMenu.Location = new System.Drawing.Point(8, 526);
            this.btnMostrarMenu.Name = "btnMostrarMenu";
            this.btnMostrarMenu.Size = new System.Drawing.Size(24, 24);
            this.btnMostrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMostrarMenu.TabIndex = 7;
            this.btnMostrarMenu.TabStop = false;
            this.btnMostrarMenu.Visible = false;
            this.btnMostrarMenu.Click += new System.EventHandler(this.bntMostrarMenu_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjustes.AnimationHoverSpeed = 0.07F;
            this.btnAjustes.AnimationSpeed = 0.03F;
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.BaseColor = System.Drawing.Color.Transparent;
            this.btnAjustes.BorderColor = System.Drawing.Color.Black;
            this.btnAjustes.CheckedBaseColor = System.Drawing.Color.White;
            this.btnAjustes.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnAjustes.CheckedForeColor = System.Drawing.Color.Transparent;
            this.btnAjustes.CheckedImage = null;
            this.btnAjustes.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnAjustes, Guna.UI.Animation.DecorationType.None);
            this.btnAjustes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjustes.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjustes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnAjustes.Image = global::Presentacion.Properties.Resources.icons8_settings_48;
            this.btnAjustes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAjustes.LineColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Location = new System.Drawing.Point(3, 568);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnAjustes.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAjustes.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnAjustes.OnHoverImage = null;
            this.btnAjustes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnAjustes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnAjustes.Size = new System.Drawing.Size(182, 45);
            this.btnAjustes.TabIndex = 6;
            this.btnAjustes.Text = "Ajustes";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaTransition1.SetDecoration(this.gunaSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 556);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(188, 10);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.btnVentas);
            this.gunaPanel3.Controls.Add(this.btnCompras);
            this.gunaPanel3.Controls.Add(this.btnClientes);
            this.gunaPanel3.Controls.Add(this.btnCategorias);
            this.gunaPanel3.Controls.Add(this.btnInicio);
            this.gunaTransition1.SetDecoration(this.gunaPanel3, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel3.Location = new System.Drawing.Point(0, 36);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(182, 229);
            this.gunaPanel3.TabIndex = 2;
            // 
            // btnVentas
            // 
            this.btnVentas.AnimationHoverSpeed = 0.07F;
            this.btnVentas.AnimationSpeed = 0.03F;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BaseColor = System.Drawing.Color.Transparent;
            this.btnVentas.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnVentas.CheckedBaseColor = System.Drawing.Color.White;
            this.btnVentas.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnVentas.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnVentas.CheckedImage = global::Presentacion.Properties.Resources.icons8_cash_register_28;
            this.btnVentas.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnVentas, Guna.UI.Animation.DecorationType.None);
            this.btnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVentas.FocusedColor = System.Drawing.Color.Empty;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnVentas.Image = global::Presentacion.Properties.Resources.icons8_cash_register_28;
            this.btnVentas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVentas.LineColor = System.Drawing.Color.Transparent;
            this.btnVentas.LineRight = 2;
            this.btnVentas.Location = new System.Drawing.Point(0, 179);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnVentas.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnVentas.OnHoverImage = null;
            this.btnVentas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnVentas.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(147)))));
            this.btnVentas.Size = new System.Drawing.Size(182, 45);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            // 
            // btnCompras
            // 
            this.btnCompras.AnimationHoverSpeed = 0.07F;
            this.btnCompras.AnimationSpeed = 0.03F;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BaseColor = System.Drawing.Color.Transparent;
            this.btnCompras.BorderColor = System.Drawing.Color.Black;
            this.btnCompras.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCompras.CheckedBaseColor = System.Drawing.Color.White;
            this.btnCompras.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnCompras.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(109)))));
            this.btnCompras.CheckedImage = global::Presentacion.Properties.Resources.icons8_transaction_28;
            this.btnCompras.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(109)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnCompras, Guna.UI.Animation.DecorationType.None);
            this.btnCompras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompras.FocusedColor = System.Drawing.Color.Empty;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnCompras.Image = global::Presentacion.Properties.Resources.icons8_transaction_28;
            this.btnCompras.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCompras.LineColor = System.Drawing.Color.Transparent;
            this.btnCompras.LineRight = 2;
            this.btnCompras.Location = new System.Drawing.Point(0, 134);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnCompras.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(109)))));
            this.btnCompras.OnHoverImage = null;
            this.btnCompras.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(109)))));
            this.btnCompras.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(109)))));
            this.btnCompras.Size = new System.Drawing.Size(182, 45);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            // 
            // btnClientes
            // 
            this.btnClientes.AnimationHoverSpeed = 0.07F;
            this.btnClientes.AnimationSpeed = 0.03F;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BaseColor = System.Drawing.Color.Transparent;
            this.btnClientes.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnClientes.CheckedBaseColor = System.Drawing.Color.White;
            this.btnClientes.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.btnClientes.CheckedImage = global::Presentacion.Properties.Resources.icons8_contacts_28;
            this.btnClientes.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnClientes, Guna.UI.Animation.DecorationType.None);
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnClientes.Image = global::Presentacion.Properties.Resources.icons8_contacts_28;
            this.btnClientes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClientes.LineColor = System.Drawing.Color.Transparent;
            this.btnClientes.LineRight = 2;
            this.btnClientes.Location = new System.Drawing.Point(0, 89);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.btnClientes.OnHoverImage = null;
            this.btnClientes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.btnClientes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.btnClientes.Size = new System.Drawing.Size(182, 45);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            // 
            // btnCategorias
            // 
            this.btnCategorias.AnimationHoverSpeed = 0.07F;
            this.btnCategorias.AnimationSpeed = 0.03F;
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.BaseColor = System.Drawing.Color.Transparent;
            this.btnCategorias.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCategorias.CheckedBaseColor = System.Drawing.Color.White;
            this.btnCategorias.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnCategorias.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnCategorias.CheckedImage = global::Presentacion.Properties.Resources.icons8_categorize_28;
            this.btnCategorias.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnCategorias, Guna.UI.Animation.DecorationType.None);
            this.btnCategorias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategorias.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnCategorias.Image = global::Presentacion.Properties.Resources.icons8_categorize_28;
            this.btnCategorias.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCategorias.LineColor = System.Drawing.Color.Transparent;
            this.btnCategorias.LineRight = 2;
            this.btnCategorias.Location = new System.Drawing.Point(0, 44);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnCategorias.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCategorias.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnCategorias.OnHoverImage = null;
            this.btnCategorias.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnCategorias.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnCategorias.Size = new System.Drawing.Size(182, 45);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Artículos";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.AnimationHoverSpeed = 0.07F;
            this.btnInicio.AnimationSpeed = 0.03F;
            this.btnInicio.BaseColor = System.Drawing.Color.Transparent;
            this.btnInicio.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnInicio.CheckedBaseColor = System.Drawing.Color.White;
            this.btnInicio.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnInicio.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(225)))));
            this.btnInicio.CheckedImage = global::Presentacion.Properties.Resources.icons8_home_28;
            this.btnInicio.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(225)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnInicio, Guna.UI.Animation.DecorationType.None);
            this.btnInicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInicio.FocusedColor = System.Drawing.Color.Empty;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnInicio.Image = global::Presentacion.Properties.Resources.icons8_home_28;
            this.btnInicio.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInicio.LineColor = System.Drawing.Color.Transparent;
            this.btnInicio.LineRight = 2;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.btnInicio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(225)))));
            this.btnInicio.OnHoverImage = null;
            this.btnInicio.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(225)))));
            this.btnInicio.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(225)))));
            this.btnInicio.Size = new System.Drawing.Size(182, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(45, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SoftSales";
            // 
            // btnOcultarMenu
            // 
            this.btnOcultarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnOcultarMenu, Guna.UI.Animation.DecorationType.None);
            this.btnOcultarMenu.Image = global::Presentacion.Properties.Resources.icons8_menu_48;
            this.btnOcultarMenu.Location = new System.Drawing.Point(158, 8);
            this.btnOcultarMenu.Name = "btnOcultarMenu";
            this.btnOcultarMenu.Size = new System.Drawing.Size(24, 24);
            this.btnOcultarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOcultarMenu.TabIndex = 0;
            this.btnOcultarMenu.TabStop = false;
            this.btnOcultarMenu.Click += new System.EventHandler(this.btnOcultarMenu_Click);
            // 
            // pictureBox4
            // 
            this.gunaTransition1.SetDecoration(this.pictureBox4, Guna.UI.Animation.DecorationType.None);
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.LOGO2;
            this.pictureBox4.Location = new System.Drawing.Point(-8, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // PnTop
            // 
            this.PnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.PnTop.Controls.Add(this.lbUser);
            this.PnTop.Controls.Add(this.btnHelp);
            this.PnTop.Controls.Add(this.imgUser);
            this.PnTop.Controls.Add(this.btnMinimizar);
            this.PnTop.Controls.Add(this.btnMaxMin);
            this.PnTop.Controls.Add(this.btnCerrar);
            this.gunaTransition1.SetDecoration(this.PnTop, Guna.UI.Animation.DecorationType.None);
            this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTop.Location = new System.Drawing.Point(188, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(959, 31);
            this.PnTop.TabIndex = 3;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lbUser, Guna.UI.Animation.DecorationType.None);
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lbUser.Location = new System.Drawing.Point(753, 6);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(103, 17);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Manuel Morales";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransition1.SetDecoration(this.btnHelp, Guna.UI.Animation.DecorationType.None);
            this.btnHelp.Image = global::Presentacion.Properties.Resources.icons8_help_48;
            this.btnHelp.Location = new System.Drawing.Point(695, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(15, 15);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHelp.TabIndex = 1;
            this.btnHelp.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransition1.SetDecoration(this.imgUser, Guna.UI.Animation.DecorationType.None);
            this.imgUser.Image = global::Presentacion.Properties.Resources.Sin_título_2;
            this.imgUser.Location = new System.Drawing.Point(716, 2);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(32, 32);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.AnimationHoverSpeed = 0.07F;
            this.btnMinimizar.AnimationSpeed = 0.03F;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnMinimizar, Guna.UI.Animation.DecorationType.None);
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnMinimizar.IconSize = 15F;
            this.btnMinimizar.Location = new System.Drawing.Point(862, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btnMinimizar.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMinimizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 3;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.AnimationHoverSpeed = 0.07F;
            this.btnMaxMin.AnimationSpeed = 0.03F;
            this.btnMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxMin.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnMaxMin, Guna.UI.Animation.DecorationType.None);
            this.btnMaxMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.btnMaxMin.IconSize = 15F;
            this.btnMaxMin.Location = new System.Drawing.Point(894, 0);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btnMaxMin.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMaxMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaxMin.Size = new System.Drawing.Size(32, 32);
            this.btnMaxMin.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnCerrar, Guna.UI.Animation.DecorationType.None);
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconSize = 15F;
            this.btnCerrar.Location = new System.Drawing.Point(926, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(29)))), ((int)(((byte)(68)))));
            this.btnCerrar.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 1;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.PanelFormularios, Guna.UI.Animation.DecorationType.None);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(188, 31);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(959, 585);
            this.PanelFormularios.TabIndex = 4;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.PnTop;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.gunaAnimateWindow1.Interval = 800;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
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
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 616);
            this.Controls.Add(this.PanelFormularios);
            this.Controls.Add(this.PnTop);
            this.Controls.Add(this.PanelLateral);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarMenu)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel PanelLateral;
        private Guna.UI.WinForms.GunaPanel PnTop;
        private Guna.UI.WinForms.GunaControlBox btnMinimizar;
        private Guna.UI.WinForms.GunaControlBox btnMaxMin;
        private Guna.UI.WinForms.GunaControlBox btnCerrar;
        private System.Windows.Forms.PictureBox btnOcultarMenu;
        private Guna.UI.WinForms.GunaPanel PanelFormularios;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnInicio;
        private Guna.UI.WinForms.GunaAdvenceButton btnCategorias;
        private Guna.UI.WinForms.GunaAdvenceButton btnClientes;
        private Guna.UI.WinForms.GunaAdvenceButton btnCompras;
        private Guna.UI.WinForms.GunaAdvenceButton btnVentas;
        private Guna.UI.WinForms.GunaAdvenceButton btnAjustes;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.PictureBox btnMostrarMenu;
    }
}