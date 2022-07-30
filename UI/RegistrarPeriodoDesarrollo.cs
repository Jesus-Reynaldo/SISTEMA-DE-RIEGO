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
    public partial class RegistrarPeriodoDesarrollo : Form
    {
        Periodo_Desarrollo _pEn = new Periodo_Desarrollo();
        Periodo_DesarrolloBL _pBL = new Periodo_DesarrolloBL();
        public RegistrarPeriodoDesarrollo()
        {
            InitializeComponent();
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
                    _pEn.CULTIVO = TxtCultivo.Text;
                    _pEn.D_I = Int32.Parse(TxtFinicial.Text.ToString());
                    _pEn.D_D = Int32.Parse(TxtFdesarrollo.Text.ToString());
                    _pEn.D_M = Int32.Parse(TxtFmedia.Text.ToString());
                    _pEn.D_F = Int32.Parse(txtFfinal.Text.ToString());

                    _pEn.KC_I = float.Parse(TxtCinicial.Text.ToString());
                    _pEn.KC_D = float.Parse(TxtCdesarrollo.Text.ToString());
                    _pEn.KC_M = float.Parse(TxtCmedia.Text.ToString());
                    _pEn.KC_F = float.Parse(TxtCfinal.Text.ToString());;
                    int resultado = _pBL.Reg_Periodo(_pEn);
                    if (resultado >= 1)
                    {
                        MessageBox.Show("Tipo de Cultivo Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            PeriodoDesarrollo _pd = ((PeriodoDesarrollo)(Owner));
            _pd.DgwPeriodo.DataSource = _pBL.MostrarPeriodo();
            _pd.panelFormularios.Width = 15;
        }
    }
}
