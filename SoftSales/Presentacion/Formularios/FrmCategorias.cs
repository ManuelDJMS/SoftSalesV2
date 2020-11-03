using System;
using System.Drawing;
using System.Windows.Forms;
using Presentacion.Notificaciones;
using SoftSales.Negocio;
namespace Presentacion
{
    public partial class FrmCategorias : Form
    {
        private string nombreAnt;
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
            txtDescripcion.BaseColor = Color.WhiteSmoke;
            txtNombre.BaseColor = Color.WhiteSmoke;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtidCategoria.Text = "";
            txtDescripcion.Text = "";
            Error.Clear();

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
                if (txtidCategoria.Text == "")
                {
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
                            this.Listar();
                            this.Formato();

                        }
                        else
                        {
                            FrmError.Confirmacion("Error", "Algo salió mal");
                        }
                    }
                }
                else
                {
                    if (txtNombre.Text == string.Empty || txtidCategoria.Text == string.Empty)
                    {
                        Error.SetError(txtNombre, "Ingrese un nombre");
                    }
                    else
                    {
                        respuesta = NCategoria.Actualizar(Convert.ToInt32(txtidCategoria.Text), this.nombreAnt, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                        if (respuesta.Equals("OK"))
                        {
                            this.Alert("Actualizado exitosamente", FrmAlert.alertTypeEnum.Success);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            FrmError.Confirmacion("Error", "Algo salió mal a");
                        }
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
            txtNombre.BaseColor = Color.White;
            txtDescripcion.BaseColor = Color.White;
            this.Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DgCategorias.DataSource = NCategoria.Buscar(txtBuscar.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)
            {
                try
                {
                    DialogResult Opcion = new DialogResult();
                    Form mensaje = new FrmQuestionSuccess("¿Está seguro de eliminar la(s) categorías seleccionadas?");
                    Opcion = mensaje.ShowDialog();
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
                                   
                                    this.Alert("Categoría: " + Convert.ToString(row.Cells[2].Value) + " eliminada", FrmAlert.alertTypeEnum.Error);
                                }
                                else
                                {
                                    FrmError.Confirmacion("Error", Rpta);
                                }
                            }
                        }
                        this.Listar();
                        this.Formato();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                FrmError.Confirmacion("Error", "No haz seleccionado ninguna categoría");
            }

        }

        private void DgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgCategorias.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgCategorias.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
            else if (e.ColumnIndex==DgCategorias.Columns[4].Index)
            {
                string respuesta;
                string check = Convert.ToString(DgCategorias.Rows[e.RowIndex].Cells[4].Value);
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgCategorias.Rows[e.RowIndex].Cells[4];
                if (check.Equals("True"))
                {
                    respuesta = NCategoria.Desactivar(Convert.ToInt32(DgCategorias.Columns[1].Index));
                    ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                    this.Alert("Categoría: " + Convert.ToString(DgCategorias.Rows[e.RowIndex].Cells[2].Value) + " desactivada", FrmAlert.alertTypeEnum.Info);
                }
                else
                {
                    respuesta = NCategoria.Activar(Convert.ToInt32(DgCategorias.Columns[1].Index));
                    ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                    this.Alert("Categoría: " + Convert.ToString(DgCategorias.Rows[e.RowIndex].Cells[2].Value) + " activada", FrmAlert.alertTypeEnum.Info);
                }
            }
        }

        private void DgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                txtidCategoria.Text = Convert.ToString(DgCategorias.CurrentRow.Cells[1].Value);
                this.nombreAnt = Convert.ToString(DgCategorias.CurrentRow.Cells[2].Value);
                txtNombre.Text = Convert.ToString(DgCategorias.CurrentRow.Cells[2].Value);
                txtDescripcion.Text = Convert.ToString(DgCategorias.CurrentRow.Cells[3].Value);
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                txtNombre.BaseColor = Color.White;
                txtDescripcion.BaseColor = Color.White;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
        }
    }
}
