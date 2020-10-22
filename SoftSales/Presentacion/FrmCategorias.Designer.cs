namespace Presentacion
{
    partial class FrmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PanelSuperior = new Guna.UI.WinForms.GunaPanel();
            this.btnCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.DgCategorias = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.txtidCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtEliminar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtEditar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.PanelSuperior.Controls.Add(this.gunaLabel1);
            this.PanelSuperior.Controls.Add(this.gunaPictureBox1);
            this.PanelSuperior.Controls.Add(this.btnCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(740, 31);
            this.PanelSuperior.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconSize = 15F;
            this.btnCerrar.Location = new System.Drawing.Point(708, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(29)))), ((int)(((byte)(68)))));
            this.btnCerrar.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(29, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 21);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Categorías";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.BorderSize = 1;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(41, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.Radius = 6;
            this.txtBuscar.Size = new System.Drawing.Size(222, 30);
            this.txtBuscar.TabIndex = 1;
            // 
            // DgCategorias
            // 
            this.DgCategorias.AllowUserToAddRows = false;
            this.DgCategorias.AllowUserToDeleteRows = false;
            this.DgCategorias.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DgCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCategorias.BackgroundColor = System.Drawing.Color.White;
            this.DgCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgCategorias.ColumnHeadersHeight = 21;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCategorias.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgCategorias.EnableHeadersVisualStyles = false;
            this.DgCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgCategorias.Location = new System.Drawing.Point(12, 77);
            this.DgCategorias.Name = "DgCategorias";
            this.DgCategorias.ReadOnly = true;
            this.DgCategorias.RowHeadersVisible = false;
            this.DgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCategorias.Size = new System.Drawing.Size(457, 257);
            this.DgCategorias.TabIndex = 284;
            this.DgCategorias.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DgCategorias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgCategorias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgCategorias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgCategorias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgCategorias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgCategorias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgCategorias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgCategorias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.DgCategorias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgCategorias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgCategorias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgCategorias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgCategorias.ThemeStyle.HeaderStyle.Height = 21;
            this.DgCategorias.ThemeStyle.ReadOnly = true;
            this.DgCategorias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgCategorias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgCategorias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgCategorias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgCategorias.ThemeStyle.RowsStyle.Height = 22;
            this.DgCategorias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgCategorias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.PanelSuperior;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(483, 41);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 15);
            this.gunaLabel2.TabIndex = 285;
            this.gunaLabel2.Text = "idCategoria:";
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(465, 41);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(12, 303);
            this.gunaVSeparator1.TabIndex = 286;
            // 
            // txtidCategoria
            // 
            this.txtidCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtidCategoria.BaseColor = System.Drawing.Color.White;
            this.txtidCategoria.BorderColor = System.Drawing.Color.Silver;
            this.txtidCategoria.BorderSize = 1;
            this.txtidCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidCategoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txtidCategoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtidCategoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtidCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtidCategoria.Location = new System.Drawing.Point(486, 59);
            this.txtidCategoria.Name = "txtidCategoria";
            this.txtidCategoria.PasswordChar = '\0';
            this.txtidCategoria.Radius = 6;
            this.txtidCategoria.Size = new System.Drawing.Size(87, 30);
            this.txtidCategoria.TabIndex = 287;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(486, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 6;
            this.txtNombre.Size = new System.Drawing.Size(237, 30);
            this.txtNombre.TabIndex = 289;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(483, 92);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel3.TabIndex = 288;
            this.gunaLabel3.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Silver;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(486, 161);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Radius = 6;
            this.txtDescripcion.Size = new System.Drawing.Size(237, 97);
            this.txtDescripcion.TabIndex = 291;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(483, 143);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel4.TabIndex = 290;
            this.gunaLabel4.Text = "Descripción:";
            // 
            // txtEliminar
            // 
            this.txtEliminar.AnimationHoverSpeed = 0.07F;
            this.txtEliminar.AnimationSpeed = 0.03F;
            this.txtEliminar.BackColor = System.Drawing.Color.Transparent;
            this.txtEliminar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.txtEliminar.BorderColor = System.Drawing.Color.Black;
            this.txtEliminar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.txtEliminar.CheckedBorderColor = System.Drawing.Color.Black;
            this.txtEliminar.CheckedForeColor = System.Drawing.Color.White;
            this.txtEliminar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtEliminar.CheckedImage")));
            this.txtEliminar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.txtEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.txtEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEliminar.ForeColor = System.Drawing.Color.White;
            this.txtEliminar.Image = global::Presentacion.Properties.Resources.icons8_delete_bin_48;
            this.txtEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.txtEliminar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtEliminar.Location = new System.Drawing.Point(607, 302);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.txtEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.txtEliminar.OnHoverImage = null;
            this.txtEliminar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.txtEliminar.Radius = 6;
            this.txtEliminar.Size = new System.Drawing.Size(111, 32);
            this.txtEliminar.TabIndex = 295;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGuardar
            // 
            this.txtGuardar.AnimationHoverSpeed = 0.07F;
            this.txtGuardar.AnimationSpeed = 0.03F;
            this.txtGuardar.BackColor = System.Drawing.Color.Transparent;
            this.txtGuardar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.txtGuardar.BorderColor = System.Drawing.Color.Black;
            this.txtGuardar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.txtGuardar.CheckedBorderColor = System.Drawing.Color.Black;
            this.txtGuardar.CheckedForeColor = System.Drawing.Color.White;
            this.txtGuardar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtGuardar.CheckedImage")));
            this.txtGuardar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.txtGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.txtGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuardar.ForeColor = System.Drawing.Color.White;
            this.txtGuardar.Image = global::Presentacion.Properties.Resources.icons8_save_all_48;
            this.txtGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.txtGuardar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtGuardar.Location = new System.Drawing.Point(490, 302);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.txtGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.txtGuardar.OnHoverImage = null;
            this.txtGuardar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.txtGuardar.Radius = 6;
            this.txtGuardar.Size = new System.Drawing.Size(111, 32);
            this.txtGuardar.TabIndex = 294;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEditar
            // 
            this.txtEditar.AnimationHoverSpeed = 0.07F;
            this.txtEditar.AnimationSpeed = 0.03F;
            this.txtEditar.BackColor = System.Drawing.Color.Transparent;
            this.txtEditar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.txtEditar.BorderColor = System.Drawing.Color.Black;
            this.txtEditar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.txtEditar.CheckedBorderColor = System.Drawing.Color.Black;
            this.txtEditar.CheckedForeColor = System.Drawing.Color.White;
            this.txtEditar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtEditar.CheckedImage")));
            this.txtEditar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.txtEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtEditar.FocusedColor = System.Drawing.Color.Empty;
            this.txtEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditar.ForeColor = System.Drawing.Color.White;
            this.txtEditar.Image = global::Presentacion.Properties.Resources.icons8_edit_calendar_48;
            this.txtEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.txtEditar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtEditar.Location = new System.Drawing.Point(607, 264);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.txtEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.txtEditar.OnHoverImage = null;
            this.txtEditar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtEditar.OnPressedColor = System.Drawing.Color.Black;
            this.txtEditar.Radius = 6;
            this.txtEditar.Size = new System.Drawing.Size(111, 32);
            this.txtEditar.TabIndex = 293;
            this.txtEditar.Text = "Editar";
            this.txtEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNuevo
            // 
            this.txtNuevo.AnimationHoverSpeed = 0.07F;
            this.txtNuevo.AnimationSpeed = 0.03F;
            this.txtNuevo.BackColor = System.Drawing.Color.Transparent;
            this.txtNuevo.BaseColor = System.Drawing.Color.DodgerBlue;
            this.txtNuevo.BorderColor = System.Drawing.Color.Black;
            this.txtNuevo.CheckedBaseColor = System.Drawing.Color.Gray;
            this.txtNuevo.CheckedBorderColor = System.Drawing.Color.Black;
            this.txtNuevo.CheckedForeColor = System.Drawing.Color.White;
            this.txtNuevo.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtNuevo.CheckedImage")));
            this.txtNuevo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.txtNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.txtNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevo.ForeColor = System.Drawing.Color.White;
            this.txtNuevo.Image = global::Presentacion.Properties.Resources.icons8_add_property_48;
            this.txtNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.txtNuevo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtNuevo.Location = new System.Drawing.Point(490, 264);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.txtNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.txtNuevo.OnHoverImage = null;
            this.txtNuevo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.txtNuevo.Radius = 6;
            this.txtNuevo.Size = new System.Drawing.Size(111, 32);
            this.txtNuevo.TabIndex = 292;
            this.txtNuevo.Text = "Nuevo";
            this.txtNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::Presentacion.Properties.Resources.icons8_search_48;
            this.gunaPictureBox2.Location = new System.Drawing.Point(12, 41);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(28, 28);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 2;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Presentacion.Properties.Resources.icons8_categorize_48;
            this.gunaPictureBox1.Location = new System.Drawing.Point(2, 1);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 355);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtidCategoria);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.DgCategorias);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel PanelSuperior;
        private Guna.UI.WinForms.GunaControlBox btnCerrar;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        internal Guna.UI.WinForms.GunaDataGridView DgCategorias;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton txtNuevo;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtidCategoria;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton txtEliminar;
        private Guna.UI.WinForms.GunaAdvenceButton txtGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton txtEditar;
        private System.Windows.Forms.ErrorProvider Error;
    }
}