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
    public partial class ReporteHidraulicoEspecifico : Form
    {
        CodPro _cod = CodPro.getInstancia();
        public ReporteHidraulicoEspecifico()
        {
            InitializeComponent();
        }

        private void ReporteHidraulicoEspecifico_Load(object sender, EventArgs e)
        {
            //this.getHidraReport(_cod.CODIGO);
            this.getHidraReport(_cod.COD_LAT,_cod.TOPOGRAFIA);
        }

        private void getHidraReport(int codigo, string topografia)
        {
            DiseñoHidraulicoEspecificoReport hi = new DiseñoHidraulicoEspecificoReport();
            LateralBL la = new LateralBL();
            hi.createHidraReportEspecifico(codigo,topografia);
            la.createHidraReport(codigo);
            DiseñoHidraulicoEspecificoReportBindingSource.DataSource = hi;
            LateralBLBindingSource.DataSource = la;     
            switch(topografia)
            {
                case "HORIZONTAL":
                        this.reportViewer1.Visible = true;
                        this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    break;
                case "ASCENDENTE":
                        this.reportViewerA.Visible = true;
                        this.reportViewerA.SetDisplayMode(DisplayMode.PrintLayout);
                    break;
                case "DESCENDENTE":
                        if (_cod.h > 2*_cod.Hg)
                        {
                            this.reportViewerD1.Visible = true;
                            this.reportViewerD1.SetDisplayMode(DisplayMode.PrintLayout);
                        }
                        else
                        {
                            this.reportViewerD2.Visible = true;
                            this.reportViewerD2.SetDisplayMode(DisplayMode.PrintLayout);
                         }
                            
                    break;

            }
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
