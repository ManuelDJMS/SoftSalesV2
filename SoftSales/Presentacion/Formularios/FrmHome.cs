using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Presentacion
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();

            //this.chartcolum();
        }

        //private void chartcolum()
        //{


        //    cartesianChart1.Series = new SeriesCollection
        //    {
        //        new LineSeries
        //        {
        //            Title = "2019",

        //            Values = new ChartValues<ObservablePoint> 

        //            { 
        //                new ObservablePoint(0,10),
        //                new ObservablePoint(4,7),
        //                new ObservablePoint(5,3),
        //                new ObservablePoint(7,10)
        //            }
        //        }
        //    };

        //adding series will update and animate the chart automatically
        //cartesianChart1.Series.Add(new ColumnSeries
        //{
        //    Title = "2020",
        //    Values = new ChartValues<Point> {  11,
        //56,
        //42,
        //40,
        //60,
        //10,
        //35,
        //70,
        //40,
        //60,
        //10,
        //35 }
        //});

        ////also adding values updates and animates the chart automatically
        //cartesianChart1.Series[1].Values.Add(48d);

        //cartesianChart1.AxisX.Add(new Axis
        //{
        //    Title = "Sales Man",
        //    Labels = new[] { "Maria", "Susan", "Charles", "Frida", "Jaenab", "Roma", "Ferdinand", "Asril", "Jaenab", "Roma", "Ferdinand", "Asril" }
        //});

        //cartesianChart1.AxisY.Add(new Axis
        //{
        //Title = "Sold Apps",
        //    LabelFormatter = value => value.ToString("N")
        //});


        //}

        private void FrmHome_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            gunaAnimateWindow1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(PanelLateral, Color.Blue, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalRight);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmInicio>();
        }

        private void btnOcultarMenu_Click(object sender, EventArgs e)
        {
            //39-188
            PanelLateral.Visible = false;
            btnMostrarMenu.Visible = true;
            PanelLateral.Width = 39;
            gunaTransition1.ShowSync(PanelLateral);
        }

        private void bntMostrarMenu_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = false;
            btnMostrarMenu.Visible = false;
            PanelLateral.Width = 188;
            gunaTransition1.ShowSync(PanelLateral);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmArticulos>();
        }
    }
}
