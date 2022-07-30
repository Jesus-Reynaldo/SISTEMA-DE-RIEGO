using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Reportes;
using BL;
using EN;
using Microsoft.Reporting.WinForms;

namespace UI
{
    public partial class ReporteCalendario : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReporteCalendario()
        {
            InitializeComponent();
        }

        private void ReporteCalendario_Load(object sender, EventArgs e)
        {
            getCalenReport(_cod.CODIGO);
            this.reportViewer1.RefreshReport();
        }
        private void getCalenReport(int codigo)
        {
            CalendarioReport cal = new CalendarioReport();
            PeriodoReport per = new PeriodoReport();
            Balance_HidricoReport bh = new Balance_HidricoReport();
            cal.createalendarioReport(codigo);
            per.createPeriodoReport(codigo);
            bh.createHidricoReport(codigo);
            ReporteCalendarioBindingSource.DataSource = cal;
            PeriodoReportBindingSource.DataSource = per;
            Balance_HidricoReportBindingSource.DataSource = bh;
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
