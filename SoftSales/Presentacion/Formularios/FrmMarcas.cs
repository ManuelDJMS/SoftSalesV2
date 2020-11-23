using Presentacion.Notificaciones;
using SoftSales.Datos;
using SoftSales.Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmMarcas : Form
    {
        private string nombreAnt;
        public FrmMarcas()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                DgMarcas.DataSource = NMarcas.Listar();
                this.Formato();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        public void Formato()
        {
            txtDescripcion.BaseColor = Color.WhiteSmoke;
            txtNombre.BaseColor = Color.WhiteSmoke;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
        }
        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtidMarca.Text = "";
            txtDescripcion.Text = "";
            Error.Clear();

        }
        public void Alert(string msg, FrmAlert.alertTypeEnum type)
        {
            FrmAlert f = new FrmAlert();
            f.setAlert(msg, type);
        }
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtNombre.BaseColor = Color.White;
            txtDescripcion.BaseColor = Color.White;
            this.Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                //================== INSERTAR ===========================
                if (txtidMarca.Text == "")
                {
                    if (txtNombre.Text == string.Empty)
                    {
                        Error.SetError(txtNombre, "Ingresa un nombre");
                    }
                    else
                    {
                        respuesta = NMarcas.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                        if (respuesta.Equals("OK"))
                        {
                            this.Alert("Guardado exitosamente", FrmAlert.alertTypeEnum.Success);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            FrmError.Confirmacion("Error", "Algo salió mal");
                        }
                    }
                }
                //======================== ACTUALIZAR ========================
                else
                {
                    if (txtNombre.Text == string.Empty)
                    {
                        Error.SetError(txtNombre, "Ingresa un nombre");
                    }
                    else
                    {
                        respuesta = NMarcas.Actualizar(Convert.ToInt32(txtidMarca.Text), txtNombre.Text.Trim(), this.nombreAnt, txtDescripcion.Text.Trim());
                        if (respuesta.Equals("OK"))
                        {
                            this.Alert("Actualizado exitosamente", FrmAlert.alertTypeEnum.Success);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            FrmError.Confirmacion("Error", respuesta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DgMarcas.DataSource = NMarcas.Buscar(txtBuscar.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ckSeleccionar.Checked)
            {
                try
                {
                    DialogResult Opcion = new DialogResult();
                    Form mensaje = new FrmQuestionSuccess("¿Esta seguro de eliminar la(s) marcas seleccionadas?");
                    Opcion = mensaje.ShowDialog();
                    if (Opcion == DialogResult.OK)
                    {
                        int codigo;
                        string respuesta = "";

                        foreach (DataGridViewRow row in DgMarcas.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                codigo = Convert.ToInt32(row.Cells[1].Value);
                                respuesta = NMarcas.Eliminar(codigo);

                                if (respuesta.Equals("OK"))
                                {

                                    this.Alert("Marca: " + Convert.ToString(row.Cells[2].Value) + " eliminada", FrmAlert.alertTypeEnum.Error);
                                }
                                else
                                {
                                    FrmError.Confirmacion("Error", respuesta);
                                }
                            }
                        }
                        this.Listar();
                        this.Formato();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
            }
            else
            {
                FrmError.Confirmacion("Error", "No haz seleccionado ninguna marca");
            }
        }

        private void ckSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)
            {
                DgMarcas.Columns[0].Visible = true;

            }
            else
            {
                DgMarcas.Columns[0].Visible = false;
            }
        }

        private void DgMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgMarcas.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgMarcas.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
            else if (e.ColumnIndex == DgMarcas.Columns[4].Index)
            {
                string respuesta;
                string check = Convert.ToString(DgMarcas.Rows[e.RowIndex].Cells[4].Value);
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgMarcas.Rows[e.RowIndex].Cells[4];
                if (check.Equals("True"))
                {
                    respuesta = NMarcas.Desactivar(Convert.ToInt32(DgMarcas.Rows[e.RowIndex].Cells[1].Value));
                    ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                    this.Alert("Categoría: " + Convert.ToString(DgMarcas.Rows[e.RowIndex].Cells[2].Value) + " desactivada", FrmAlert.alertTypeEnum.Info);
                }
                else
                {
                    respuesta = NMarcas.Activar(Convert.ToInt32(DgMarcas.Rows[e.RowIndex].Cells[1].Value));
                    ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                    this.Alert("Categoría: " + Convert.ToString(DgMarcas.Rows[e.RowIndex].Cells[2].Value) + " activada", FrmAlert.alertTypeEnum.Info);
                }
            }
        }

        private void DgMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                txtidMarca.Text = Convert.ToString(DgMarcas.CurrentRow.Cells[1].Value);
                this.nombreAnt = Convert.ToString(DgMarcas.CurrentRow.Cells[2].Value);
                txtNombre.Text = Convert.ToString(DgMarcas.CurrentRow.Cells[2].Value);
                txtDescripcion.Text = Convert.ToString(DgMarcas.CurrentRow.Cells[3].Value);
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                txtNombre.BaseColor = Color.White;
                txtDescripcion.BaseColor = Color.White;
            }
            catch (Exception)
            {
                FrmError.Confirmacion("Error","Seleccione desde la celda nombre.");
            }
        }
    }
    
}
