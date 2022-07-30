using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using EN;
using Microsoft.Reporting.WinForms;

namespace UI.Report
{
    public partial class ReportDatos : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReportDatos()
        {
            InitializeComponent();
        }

        private void ReportDatos_Load(object sender, EventArgs e)
        {

            getDatosReport(_cod.CODIGO);
        }
        private void getDatosReport(int codigo)
        {
            CultivoReport cu = new CultivoReport();
            ClimaticoReport cli = new ClimaticoReport();
            cu.createCultivoReport(codigo);
            cli.createClimaticoReport(codigo);
            CultivoReportBindingSource.DataSource = cu;
            ClimaticoReportBindingSource.DataSource = cli;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
