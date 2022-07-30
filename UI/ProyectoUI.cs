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
    public partial class ProyectoUI : Form
    {
        Proyecto _en = new Proyecto();
        ProyectoBL _bl = new ProyectoBL();
        CodPro _cod = CodPro.getInstancia();
        private bool Editar=false;
        private int codigo;
        public ProyectoUI()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    if (TxtNombre.Text == "" || TxtLugar.Text == "")
                    {
                        MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _en.NOMBRE_PROYECTO = TxtNombre.Text;
                        _en.LUGAR = TxtLugar.Text;
                        int resultado = _bl.Reg_Proyecto(_en);
                        if (resultado == 1)
                        {
                            MessageBox.Show("Proyecto Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    DgwProyecto.DataSource = _bl.MostrarProyecto();
                }
                catch
                {
                    MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else
            {
                try
                {
                    if (TxtNombre.Text == "" || TxtLugar.Text == "")
                    {
                        MessageBox.Show("Existen campos vacios", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _en.NOMBRE_PROYECTO = TxtNombre.Text;
                        _en.LUGAR = TxtLugar.Text;
                        _en.CODIGO = codigo;
                        int resultado = _bl.Edi_Proyecto(_en);
                        if (resultado == 1)
                        {
                            BtnNuevo.Text = "REGISTRAR";
                            TxtNombre.Text = null;
                            TxtLugar.Text = null;
                            MessageBox.Show("Proyecto Modificado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    DgwProyecto.DataSource = _bl.MostrarProyecto();
                }
                catch
                {
                    MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ProyectoUI_Load(object sender, EventArgs e)
        {
            DgwProyecto.DataSource = _bl.MostrarProyecto();
        }

        private void DgwProyecto_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwProyecto.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE INGRESAR AL PROYECTO :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _cod.CODIGO = Int32.Parse(row.Cells[0].Value.ToString());
                    _cod.NOMBRE = (row.Cells[1].Value.ToString());
                    _cod.LUGAR = (row.Cells[2].Value.ToString());
                    _cod.FECHA = DateTime.Parse(row.Cells[3].Value.ToString());
                    _cod.COD_CUL = 1;
                    MenuPrincipal _menu = ((MenuPrincipal)(Owner));
                    _menu.LblProyecto.Visible = true;
                    _menu.LblProyecto.Text = "Proyecto: " + _cod.NOMBRE + " - " + _cod.LUGAR + " (" + _cod.FECHA.ToString("MM/dd/yyyy") + ")";
                    _menu.BtnCerrarSesion.Visible = true;
                    _menu.BtnProyecto.Enabled = false;
                    _menu.BtnCultivo.Enabled = true;
                    _menu.Btn_proy.ForeColor= Color.FromArgb(25, 150, 220);
                    _menu.Cir_proy.RadioColor= Color.FromArgb(25, 150, 220);
                    _menu.Cir_proy.OutlineColor = Color.FromArgb(25, 90, 170);
                    _menu.Sepa_proy.LineColor = Color.FromArgb(25, 90, 170);
                    _menu.Btn_proy.Enabled = false;
                    _menu.Btn_proy.ForeColor= Color.FromArgb(25, 150, 220);
                    _menu.Btn_proy.ForeColor = Color.FromArgb(25, 150, 220); ;
                    this.Close();                    
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwProyecto.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE EDITAR EL PROYECTO :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Editar = true;
                    BtnNuevo.Text = "MODIFICAR";
                    codigo = Int32.Parse(row.Cells[0].Value.ToString());
                    TxtNombre.Text = (row.Cells[1].Value.ToString());
                    TxtLugar.Text = (row.Cells[2].Value.ToString());
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwProyecto.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL PROYECTO :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        _en.CODIGO = Int32.Parse(row.Cells[0].Value.ToString());
                        int resultado = _bl.Del_Proyecto(_en);
                        if (resultado == 1)
                        {
                            MessageBox.Show("Proyecto Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DgwProyecto.DataSource = _bl.MostrarProyecto();
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            BtnNuevo.BackColor = Color.FromArgb(25, 150, 220);
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            BtnNuevo.BackColor = Color.FromArgb(25, 90, 170);
        }

        private void BtnAbrir_MouseEnter(object sender, EventArgs e)
        {
            BtnAbrir.BackColor = Color.FromArgb(25, 150, 220);
        }

        private void BtnAbrir_MouseLeave(object sender, EventArgs e)
        {
            BtnAbrir.BackColor = Color.FromArgb(25, 90, 170);
        }
    }
}
