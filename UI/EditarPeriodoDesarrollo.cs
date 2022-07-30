using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN;
using BL;

namespace UI
{
    public partial class EditarPeriodoDesarrollo : Form
    {
        Periodo_Desarrollo _pEn = new Periodo_Desarrollo();
        Periodo_DesarrolloBL _pBL = new Periodo_DesarrolloBL();
        public int cod_pd;
        public EditarPeriodoDesarrollo()
        {
            InitializeComponent();
        }

        private void EditarPeriodoDesarrollo_Load(object sender, EventArgs e)
        {
            var lista = _pBL.Mostrar_Periodo_Total(cod_pd);
            foreach (DataRow row in lista.Rows)
            {
                TxtCod_pd.Text = Convert.ToString(row[0]);
                TxtCultivo.Text = Convert.ToString(row[1]);

                TxtFinicial.Text = Convert.ToString(row[2]);
                TxtFdesarrollo.Text = Convert.ToString(row[3]);
                TxtFmedia.Text = Convert.ToString(row[4]);
                txtFfinal.Text = Convert.ToString(row[5]);

                TxtCinicial.Text = Convert.ToString(row[7]);
                TxtCdesarrollo.Text = Convert.ToString(row[8]);
                TxtCmedia.Text = Convert.ToString(row[9]);
                TxtCfinal.Text = Convert.ToString(row[10]);

            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCultivo.Text == "" || TxtCinicial.Text == "" || TxtCdesarrollo.Text == "" || TxtCmedia.Text == "" || TxtCfinal.Text == "" || TxtFinicial.Text == "" || TxtFdesarrollo.Text == "" || TxtFmedia.Text == "" || txtFfinal.Text == "")
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _pEn.COD_PD = Int32.Parse(TxtCod_pd.Text.ToString());
                    _pEn.CULTIVO = TxtCultivo.Text;
                    _pEn.D_I = Int32.Parse(TxtFinicial.Text.ToString());
                    _pEn.D_D = Int32.Parse(TxtFdesarrollo.Text.ToString());
                    _pEn.D_M = Int32.Parse(TxtFmedia.Text.ToString());
                    _pEn.D_F = Int32.Parse(txtFfinal.Text.ToString());

                    _pEn.KC_I = float.Parse(TxtCinicial.Text.ToString());
                    _pEn.KC_D = float.Parse(TxtCdesarrollo.Text.ToString());
                    _pEn.KC_M = float.Parse(TxtCmedia.Text.ToString());
                    _pEn.KC_F = float.Parse(TxtCfinal.Text.ToString()); ;
                    int resultado = _pBL.Edi_Periodo(_pEn);
                    if (resultado >= 1)
                    {
                        MessageBox.Show("Tipo de Cultivo Modificado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("NO SE PUDO MODIFICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PeriodoDesarrollo _pd = ((PeriodoDesarrollo)(Owner));
            _pd.DgwPeriodo.DataSource = _pBL.MostrarPeriodo();
            _pd.panelFormularios.Width = 15;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            PeriodoDesarrollo _pd = ((PeriodoDesarrollo)(Owner));
            _pd.DgwPeriodo.DataSource = _pBL.MostrarPeriodo();
            _pd.panelFormularios.Width = 15;
        }

        private void BtnAtras_MouseEnter(object sender, EventArgs e)
        {
            BtnAtras.BackColor = Color.FromArgb(58, 58, 61);
        }

        private void BtnAtras_MouseLeave(object sender, EventArgs e)
        {
            BtnAtras.BackColor = Color.FromArgb(26, 26, 30);
        }
    }
}
