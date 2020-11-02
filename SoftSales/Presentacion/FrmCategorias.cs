using System;
using System.Windows.Forms;
using Presentacion.Notificaciones;
using SoftSales.Negocio;
namespace Presentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgCategorias.DataSource = NCategoria.Listar();
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgCategorias.Columns[0].Width = 75;
            DgCategorias.Columns[3].Width = 60;
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtidCategoria.Text = "";
            txtDescripcion.Text = "";

        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.Listar();
        }
        public void Alert(string msg, FrmAlert.alertTypeEnum type)
        {
            FrmAlert f = new FrmAlert();
            f.setAlert(msg, type);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string respuesta = "";
                if (txtNombre.Text == string.Empty)
                {
                    Error.SetError(txtNombre, "Ingrese un nombre");
                }
                else
                {
                    respuesta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        //FrmSuccess.Confirmacion("Guardado Exitoso", "La categoría se guardo correctamente.");
                        this.Alert("Guardado exitosamente", FrmAlert.alertTypeEnum.Success);
                        this.Limpiar();
                        this.Formato();

                    }
                    else
                    {
                        FrmError.Confirmacion("Error", "Algo salió mal");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ckSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)
            {
                DgCategorias.Columns[0].Visible = true;
                    
            }
            else
            {
                DgCategorias.Columns[0].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
                DgCategorias.DataSource = NCategoria.Buscar(txtBuscar.Text);
                this.Formato();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion= new DialogResult();
                Form mensaje = new FrmQuestionSuccess();
                Opcion = mensaje.ShowDialog();

               //' Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgCategorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                //this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                                //FrmSuccess.Confirmacion("Registro Eliminado", "La categoría: " + Convert.ToString(row.Cells[2].Value) +" se eliminó correctamente.");
                                this.Alert("Eliminado Correctamente", FrmAlert.alertTypeEnum.Error);
                            }
                            else
                            {
                                //this.MensajeError(Rpta);
                                FrmError.Confirmacion("Error", Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgCategorias.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgCategorias.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
    }
}
