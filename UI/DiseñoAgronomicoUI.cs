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
    public partial class DiseñoAgronomicoUI : Form
    {
        public int cod_asp;
        DiseñoAgricola _en = new DiseñoAgricola();
        CodPro _cod = CodPro.getInstancia();
        DiseñoAgricolaBL _bl = new DiseñoAgricolaBL();
        AspersorBL _abl = new AspersorBL();
        Tipo_SueloBL _Tbl = new Tipo_SueloBL();


        public DiseñoAgronomicoUI()
        {
            InitializeComponent();
        }

        private void DiseñoAgronomico_Load(object sender, EventArgs e)
        {
            CmbTipoSuelo.ValueMember = "TEXTURA";
            CmbTipoSuelo.DataSource = _Tbl.Mostrar_Textura();
            DwgAgronomico.DataSource = _bl.Mostrar_Resumen_Agro(_cod.CODIGO);
            CargarCritico();
            CargarEficiencia();
            if (DwgAgronomico.Rows.Count <= 1)
            {
                BtnReportParametros.Enabled = false;
                BtnReportAgronomico.Enabled = false;
            }
            else
            {
                MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                _menu.BtnHidraulico.Enabled = true;
                _menu.Btn_Agro.ForeColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_agro.RadioColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_agro.OutlineColor = Color.FromArgb(25, 90, 170);
                _menu.Sepa_agro.LineColor = Color.FromArgb(25, 90, 170);
                _cod.COD_HIDRA = 1;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbTipoSuelo.Text == "" ||CmbCriterio.Text == "" || CmbEficiencia.Text == "" || TxtProfundidad.Text =="" || cod_asp == 0)
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _en.CODIGO = _cod.CODIGO;
                    _en.TEXTURA = CmbTipoSuelo.Text.ToString();
                    _en.Pre = float.Parse(TxtProfundidad.Text);
                    _en.NR = float.Parse(CmbCriterio.Text) / 100;
                    _en.Ea = float.Parse(CmbEficiencia.Text) / 100;
                    //_en.Aasp = float.Parse(TxtAasp.Text);
                    //_en.Qasp = float.Parse(TxtQasp.Text);
                    _en.COD_ASP = cod_asp;
                    int resultado = _bl.Reg_Diseño_Agro(_en);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                DwgAgronomico.DataSource = _bl.Mostrar_Resumen_Agro(_cod.CODIGO);
                MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                _menu.BtnHidraulico.Enabled = true;
                BtnReportAgronomico.Enabled = true;
                BtnReportParametros.Enabled = true;

                _menu.Btn_Agro.ForeColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_agro.RadioColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_agro.OutlineColor = Color.FromArgb(25, 90, 170);
                _menu.Sepa_agro.LineColor = Color.FromArgb(25, 90, 170);
                _cod.COD_HIDRA = 1;
            }
            catch
            {
                MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCritico()
        {
            for (int i=30; i<=50;i=i+5)
            {
                CmbCriterio.Items.Add(i);
            }
        }
        private void CargarEficiencia()
        {
            for (int i = 65; i <= 80; i = i + 5)
            {
                CmbEficiencia.Items.Add(i);
            }
        }

        private void BtnReportAgronomico_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReportDiseño_Agronomico>();
        }

        private void BtnReportParametros_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReportDatosAgronomico>();
        }

        private void BtnCultivo_Click(object sender, EventArgs e)
        {
            AspersorUI _aspersor = AspersorUI.getInstancia();
            AddOwnedForm(_aspersor);
            _aspersor.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al eliminar la información del DISEÑO AGRONÓMICO se eliminará los valores calculados en el DISEÑO HIDRÁULICO. ¿Está seguro de eliminar?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    _en.CODIGO = _cod.CODIGO;
                    int resultado = _bl.Del_Diseño_Agro(_en);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    DwgAgronomico.DataSource = _bl.Mostrar_Resumen_Agro(_cod.CODIGO);
                    MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                    _menu.BtnHidraulico.Enabled = false;

                    if (DwgAgronomico.Rows.Count < 1)
                    {
                        _menu.Btn_Agro.ForeColor = Color.Silver;
                        _menu.Cir_agro.RadioColor = Color.Silver;
                        _menu.Cir_agro.OutlineColor = Color.Gray;
                        _menu.Sepa_agro.LineColor = Color.FromArgb(128, 128, 128);

                        _menu.Btn_hidra.ForeColor = Color.Silver;
                        _menu.Cir_hidra.RadioColor = Color.Silver;
                        _menu.Cir_hidra.OutlineColor = Color.Gray;
                        _cod.COD_HIDRA = 0;
                    }
                    BtnReportAgronomico.Enabled = false;
                    BtnReportParametros.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtProfundidad_KeyPress(object sender, KeyPressEventArgs e)
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


        private void BtnCultivo_MouseEnter(object sender, EventArgs e)
        {
            BtnCultivo.BackColor = Color.FromArgb(25, 150, 220);
        }

        private void BtnCultivo_MouseLeave(object sender, EventArgs e)
        {
            BtnCultivo.BackColor = Color.FromArgb(25, 90, 170);
        }
    }
}
