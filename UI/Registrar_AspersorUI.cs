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
    public partial class Registrar_AspersorUI : Form
    {
        Aspersor _aEN = new Aspersor();
        AspersorBL _aBL = new AspersorBL();
        public Registrar_AspersorUI()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAspersor.Text == "" || TxtMarco.Text == "" || TxtPa.Text == "" || TxtQasp.Text == "" || TxtSa.Text == "" || txtSl.Text == "" )
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _aEN.TIPO = TxtAspersor.Text;
                    _aEN.MARCO = TxtMarco.Text;
                    _aEN.Pa = float.Parse(TxtPa.Text.ToString());
                    _aEN.Qasp = float.Parse(TxtQasp.Text.ToString());
                    _aEN.Sl = float.Parse(txtSl.Text.ToString());
                    _aEN.Sa = float.Parse(TxtSa.Text.ToString());

                    int resultado = _aBL.Reg_Aspersor(_aEN);
                    if (resultado >= 1)
                    {
                        MessageBox.Show("Aspersor Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    AspersorUI _as = ((AspersorUI)(Owner));
                    _as.DgwAspersor.DataSource = _aBL.MostrarAspersor();
                    _as.panelFormularios.Width = 15;
                }
            }
            catch
            {
                MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            AspersorUI _pd = ((AspersorUI)(Owner));
            _pd.DgwAspersor.DataSource = _aBL.MostrarAspersor();
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
