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
    public partial class Editar_AspersorUI : Form
    {
        Aspersor _aEN = new Aspersor();
        AspersorBL _aBL = new AspersorBL();
        public int cod_asp;
        public Editar_AspersorUI()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAspersor.Text == "" || TxtMarco.Text == "" || TxtPa.Text == "" || TxtQasp.Text == "" || TxtSa.Text == "" || txtSl.Text == "")
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _aEN.COD_ASP = Int32.Parse(TxtCod_asp.Text.ToString());
                    _aEN.TIPO = TxtAspersor.Text;
                    _aEN.MARCO = TxtMarco.Text;
                    _aEN.Pa = float.Parse(TxtPa.Text.ToString());
                    _aEN.Qasp = float.Parse(TxtQasp.Text.ToString());
                    _aEN.Sl = float.Parse(txtSl.Text.ToString());
                    _aEN.Sa = float.Parse(TxtSa.Text.ToString());

                    int resultado = _aBL.Edi_Asperor(_aEN);
                    if (resultado >= 1)
                    {
                        MessageBox.Show("Aspersor Modificado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Editar_AspersorUI_Load(object sender, EventArgs e)
        {
            var lista = _aBL.Mostrar_Aspersor_Uno(cod_asp);
            foreach (DataRow row in lista.Rows)
            {
                TxtCod_asp.Text = Convert.ToString(row[0]);
                TxtAspersor.Text = Convert.ToString(row[1]);
                TxtMarco.Text = Convert.ToString(row[2]);

                TxtPa.Text = Convert.ToString(row[3]);
                TxtQasp.Text = Convert.ToString(row[4]);

                TxtSa.Text = Convert.ToString(row[7]);
                txtSl.Text = Convert.ToString(row[8]);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            AspersorUI _as = ((AspersorUI)(Owner));
            _as.DgwAspersor.DataSource = _aBL.MostrarAspersor();
            _as.panelFormularios.Width = 15;
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
