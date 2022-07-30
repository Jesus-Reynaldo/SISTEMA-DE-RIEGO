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
    public partial class ReportBalanceHidrico : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReportBalanceHidrico()
        {
            InitializeComponent();
        }

        private void ReportBalanceHidrico_Load(object sender, EventArgs e)
        {
            getHidroReport(_cod.CODIGO);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void getHidroReport(int codigo)
        {
            Balance_HidricoReport bh = new Balance_HidricoReport();
            CalendarioReport ca = new CalendarioReport();
            bh.createHidricoReport(codigo);
            Balance_HidricoReportBindingSource.DataSource = bh;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
