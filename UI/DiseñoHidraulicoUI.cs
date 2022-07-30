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
using UI.Report;

namespace UI
{
    public partial class DiseñoHidraulicoUI : Form
    {
        //Tuberia _en = new Tuberia();
        CodPro _cod = CodPro.getInstancia();
        TuberiaBL _blt = new TuberiaBL();
        DiseñoHidraulico _en = new DiseñoHidraulico();
        DiseñoHidraulicoBL _bl = new DiseñoHidraulicoBL();
        public DiseñoHidraulicoUI()
        {
            InitializeComponent();
            this.ToolTopografia.SetToolTip(this.CmbTopografia, "La topografia depende de lo accidentado que este el terreno");
        }

        private void DiseñoHidraulico_Load(object sender, EventArgs e)
        {
            //DataTable result = _blt.Mos_Tipo();
            DgwHidraulico.DataSource = _bl.Mostrar_DiseñoHidraulico(_cod.CODIGO);
            CmbTipoTuberia.DataSource = _blt.Mos_Tipo();
            CmbTipoTuberia.ValueMember = "TIPO";
            CmbTopografia.DataSource = Topografia();
            CmbHs.DataSource = Perdida();
            CmbLo.DataSource = Primer_aspersor();
            if (DgwHidraulico.Rows.Count < 1)
            {
                BtnReportEspecificoHidraulico.Enabled = false;
                BtnReportResumenHidraulico.Enabled = false;
            }
            else
            {
                MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                _menu.Btn_hidra.ForeColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_hidra.RadioColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_hidra.OutlineColor = Color.FromArgb(25, 90, 170);
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtHa.Text == "" || TxtHg.Text == "" || TxtLL.Text == "" || TxtLT.Text == "" || CmbTipoTuberia.Text == "" || CmbTopografia.Text == "" || CmbHs.Text == "" || CmbLo.Text == "")
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _en.lo = float.Parse(CmbLo.Text);
                    _en.hs = float.Parse(CmbHs.Text);
                    _en.Ha = float.Parse(TxtHa.Text);
                    _en.Hg = float.Parse(TxtHg.Text);
                    _en.TOPOGRAFIA = CmbTopografia.Text.ToString();
                    _en.TUBERIA = CmbTipoTuberia.Text.ToString();
                    _en.LT = float.Parse(TxtLT.Text);
                    _en.LL = float.Parse(TxtLL.Text);
                    _en.CODIGO = _cod.CODIGO;
                    int resultado = _bl.Reg_DiseñoHidraulico(_en);
                    if (resultado > 1)
                    {
                        MessageBox.Show("Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                _menu.Btn_hidra.ForeColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_hidra.RadioColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_hidra.OutlineColor = Color.FromArgb(25, 90, 170);
                DgwHidraulico.DataSource = _bl.Mostrar_DiseñoHidraulico(_cod.CODIGO);
                BtnReportEspecificoHidraulico.Enabled = true;
                BtnReportResumenHidraulico.Enabled = true;
            }
            catch
            {
                MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> Topografia()
        {
            List<string> lista = new List<string>();
            lista.Add("HORIZONTAL");
            lista.Add("ASCENDENTE");
            lista.Add("DESCENDENTE");
            return lista;
        }
        private List<int> Perdida()
        {
            List<int> lista = new List<int>();
            for (int n = 5; n <= 100; n = n + 5)
            {
                lista.Add(n);
            }
            return lista;
        }
        private List<double> Primer_aspersor()
        {
            List<double> lista = new List<double>();
            lista.Add(0.5);
            lista.Add(1);
            return lista;
        }

        private void CmbTopografia_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (CmbTopografia.Text.ToString())
            {
                case "HORIZONTAL":
                    TxtHg.Text = "0";
                    LblDesnivel.Enabled = false;
                    TxtHg.Visible = false;
                    break;
                case "ASCENDENTE":
                    LblDesnivel.Enabled = true;
                    TxtHg.Visible = true;
                    break;
                case "DESCENDENTE":
                    LblDesnivel.Enabled = true;
                    TxtHg.Visible = true;
                    break;
                default:
                    TxtHg.Text = "0";
                    break;
            }
        }

        private void BtnReportResumenHidraulico_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReportHidraulico>();
        }

        private void BtnReportEspecificoHidraulico_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwHidraulico.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE INGRESAR AL PROYECTO :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _cod.COD_LAT = Int32.Parse(row.Cells[0].Value.ToString());
                    _cod.TOPOGRAFIA= (row.Cells[1].Value.ToString());
                    _cod.Hg = Single.Parse(row.Cells[2].Value.ToString());
                    _cod.h = Single.Parse(row.Cells[11].Value.ToString());
                    MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                    _menu.AbrirFormulario<ReporteHidraulicoEspecifico>();
                }
            }

        }

        private void TxtHg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))//permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
                 if (e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtHa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))//permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
                 if (e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))//permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
                 if (e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtLL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))//permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
                 if (e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwHidraulico.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        _en.COD_DIS = Int32.Parse(row.Cells[0].Value.ToString());
                        int resultado = _bl.Del_DiseñoHidraulico(_en);
                        if (resultado == 1)
                        {
                            MessageBox.Show("Sea Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DgwHidraulico.DataSource = _bl.Mostrar_DiseñoHidraulico(_cod.CODIGO);
                        if (DgwHidraulico.Rows.Count < 1)
                        {
                            BtnReportEspecificoHidraulico.Enabled = false;
                            BtnReportResumenHidraulico.Enabled = false;
                            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                            _menu.Btn_hidra.ForeColor = Color.Silver;
                            _menu.Cir_hidra.RadioColor = Color.Silver;
                            _menu.Cir_hidra.OutlineColor = Color.Gray;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnAgregar_MouseEnter(object sender, EventArgs e)
        {
            BtnAgregar.BackColor = Color.FromArgb(25, 150, 220);
        }

        private void BtnAgregar_MouseLeave(object sender, EventArgs e)
        {
            BtnAgregar.BackColor = Color.FromArgb(25, 90, 170);
        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            BtnEliminar.BackColor = Color.FromArgb(25, 150, 220);
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            BtnEliminar.BackColor = Color.FromArgb(25, 90, 170);
        }
    }
    
}
