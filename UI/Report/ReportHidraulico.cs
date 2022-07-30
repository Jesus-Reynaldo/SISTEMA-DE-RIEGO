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
    public partial class ReportHidraulico : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReportHidraulico()
        {
            InitializeComponent();
        }

        private void ReportHidraulico_Load(object sender, EventArgs e)
        {
            this.getHidraReport(_cod.CODIGO);
        }
        private void getHidraReport(int codigo)
        {
            DiseñoHidraulicoReport hi = new DiseñoHidraulicoReport();
           // PeriodoReport per = new PeriodoReport();
            hi.createHidraReport(codigo);
            DiseñoHidraulicoReportBindingSource.DataSource = hi;
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
