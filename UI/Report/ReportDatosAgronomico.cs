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
    public partial class ReportDatosAgronomico : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReportDatosAgronomico()
        {
            InitializeComponent();
        }

        private void ReportDatosAgronomico_Load(object sender, EventArgs e)
        {
            getAgroReport(_cod.CODIGO);
        }
        private void getAgroReport(int codigo)
        {
            DiseñoAgricolaReport ag = new DiseñoAgricolaReport();
            PeriodoReport per = new PeriodoReport();
            ag.createAgricolaReport(codigo);
            DiseñoAgricolaReportBindingSource.DataSource = ag;
            //ReporteCalendarioENBindingSource.DataSource = cal.CalenListing;
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
