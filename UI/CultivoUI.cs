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
    public partial class CultivoUI : Form
    {
        public int codigo;
        int cod_cul;
        Cultivo _en = new Cultivo();
        CodPro _cod = CodPro.getInstancia();
        Periodo_DesarrolloBL _bl = new Periodo_DesarrolloBL();
        CultivoBL _Cbl = new CultivoBL();
        Datos_ClimaticosBL _Dbl = new Datos_ClimaticosBL();
        Balance_HidricoBL _bh = new Balance_HidricoBL();
        MesesBL _Mbl = new MesesBL();
        public CultivoUI()
        {
            InitializeComponent();
            
          
        }

        private void BtnCultivo_Click(object sender, EventArgs e)
        {

            PeriodoDesarrollo _periodo = PeriodoDesarrollo.getInstancia();
            AddOwnedForm(_periodo);
            _periodo.ShowDialog();
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtArea.Text == "" || LblCultivo.Text == "" || CmbMes.Text == "" || codigo == 0)
                {
                    MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    _en.COD_PD = codigo;
                    _en.INICIO = CmbMes.Text.ToString();
                    _en.AREA = float.Parse(TxtArea.Text);
                    _en.CODIGO = _cod.CODIGO;
                    int resultado = _Cbl.Reg_Cultivo(_en);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Proyecto Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                ValorVn();
                DgwCultivo.DataSource = _Cbl.Mostrar_Cultivo(_cod.CODIGO);
            }
            catch
            {
                MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDatosClimaticos_Click(object sender, EventArgs e)
        {
            Datos_ClimaticosUI _datos = Datos_ClimaticosUI.getInstancia();
            AddOwnedForm(_datos);
            _datos.ShowDialog();
        }
        private void ValorVn()
        {
            var lista = _bh.Mostrar_Valor_Vn(_cod.CODIGO);
            foreach (DataRow row in lista.Rows)
            {
                LblmMes.Text = "MES: ";
                LblmVn.Text = "VOLUMEN NETO: ";
                LblmVb.Text = "VOLUMEN BRUTO: ";
                LblMes.Text = Convert.ToString(row[0]);
                LblVn.Text = Convert.ToString(row[1])+ " m3";
                LblVb.Text = Convert.ToString(row[2])+ " m3";
                MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                _menu.BtnAgronomico.Enabled = true;
                _menu.Btn_cul.ForeColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_Cul.RadioColor = Color.FromArgb(25, 150, 220);
                _menu.Cir_Cul.OutlineColor = Color.FromArgb(25, 90, 170);
                _menu.Sepa_cul.LineColor = Color.FromArgb(25, 90, 170);
                BtnCalendario.Enabled=true;
                BtnBalance_Hidrico.Enabled = true;
                BtnReportDatos.Enabled = true;
                _cod.COD_AGRO = 1;
            }

        }
        private void CultivoUI_Load(object sender, EventArgs e)
        {
            BtnCalendario.Enabled = false;
            BtnBalance_Hidrico.Enabled = false;
            BtnReportDatos.Enabled = false;
            ValorVn();
            DgwCultivo.DataSource = _Cbl.Mostrar_Cultivo(_cod.CODIGO);
            DgwDatosClimaticos.DataSource = _Dbl.Mos_Datos_Climaticos(_cod.CODIGO);
            CmbMes.ValueMember = "MES";
            CmbMes.DataSource = _Mbl.MostrarMeses();

            if (DgwDatosClimaticos.Rows.Count <= 1)
                panelCultivo.Enabled = false;
            else
                panelCultivo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReporteCalendario>();
           // _cu.DgwDatosClimaticos.DataSource = _bl.Mos_Datos_Climaticos(_cod.CODIGO);
            //ReporteCalendario reporte = new ReporteCalendario();
            //reporte.Show();
        }


        private void BtnReportDatos_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReportDatos>();
        }

        private void BtnBalance_Hidrico_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReportBalanceHidrico>();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DgwCultivo.SelectedRows)
                {
                    cod_cul = Int32.Parse(row.Cells[0].Value.ToString());
                    _en.COD_CUL = cod_cul;
                    int resultado = _Cbl.Del_Cultivo(_en);
                    MessageBox.Show("Cultivo Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgwCultivo.DataSource = _Cbl.Mostrar_Cultivo(_cod.CODIGO);
                    LblmMes.Text = "";
                    LblmVn.Text = "";
                    LblmVb.Text = "";
                    LblMes.Text = "";
                    LblVn.Text = "";
                    LblVb.Text = "";
                    MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                    _menu.BtnAgronomico.Enabled = false;
                    BtnCalendario.Enabled = false;
                    BtnBalance_Hidrico.Enabled = false;
                    BtnReportDatos.Enabled = false;
                    ValorVn();
                    if (DgwCultivo.Rows.Count < 1)
                    {
                        _menu.Btn_cul.ForeColor = Color.Silver;
                        _menu.Cir_Cul.RadioColor = Color.Silver;
                        _menu.Cir_Cul.OutlineColor = Color.Gray;
                        _menu.Sepa_cul.LineColor = Color.FromArgb(128, 128, 128);

                        _menu.Btn_Agro.ForeColor = Color.Silver;
                        _menu.Cir_agro.RadioColor = Color.Silver;
                        _menu.Cir_agro.OutlineColor = Color.Gray;
                        _menu.Sepa_agro.LineColor = Color.FromArgb(128, 128, 128);

                        _menu.Btn_hidra.ForeColor = Color.Silver;
                        _menu.Cir_hidra.RadioColor = Color.Silver;
                        _menu.Cir_hidra.OutlineColor = Color.Gray;
                        _cod.COD_AGRO = 0;
                    }
                }

            }
            catch
            {
                MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtArea_KeyPress(object sender, KeyPressEventArgs e)
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
                 if (e.KeyChar==44)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            MenuPrincipal _menu = ((MenuPrincipal)(Owner));
            _menu.AbrirFormulario<ReporteCalendario>();
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
