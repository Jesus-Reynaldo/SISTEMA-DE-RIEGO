using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EN;
using BL;

namespace UI
{
    public partial class PeriodoDesarrollo : Form
    {
        private static PeriodoDesarrollo instancia;
        Periodo_DesarrolloBL _pd = new Periodo_DesarrolloBL();
        Periodo_Desarrollo _pEn = new Periodo_Desarrollo();

        public PeriodoDesarrollo()
        {
            InitializeComponent();
        }
        public static PeriodoDesarrollo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new PeriodoDesarrollo();
            }
            return instancia;
        }
        // cerrar instancia
        public static PeriodoDesarrollo getCerrar()
        {
            if (instancia != null)
            {
                instancia = null;
            }
            return instancia;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            getCerrar();
            this.Close();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                AddOwnedForm(formulario);
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario != null)
            {
                formulario.Close();
            }
        }

        private void PeriodoDesarrollo_Load(object sender, EventArgs e)
        {
            DgwPeriodo.DataSource = _pd.MostrarPeriodo();
            //AbrirFormulario<MostrarPeriodoDesarrollo>();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwPeriodo.SelectedRows)
            {
                if (MessageBox.Show("EL CULTIVO: " + row.Cells[1].Value.ToString() + " ESTA SELECCIONADO", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    CultivoUI _cu = ((CultivoUI)(Owner));
                    _cu.codigo = Int32.Parse(row.Cells[0].Value.ToString());
                    _cu.LblCultivo.Text = row.Cells[1].Value.ToString();
                    this.Close();
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CerrarFormulario<RegistrarPeriodoDesarrollo>();
            AbrirFormulario<RegistrarPeriodoDesarrollo>();

            if (panelFormularios.Width == 590)
            {
                panelFormularios.Width = 15;
            }
            else
            {
                panelFormularios.Width = 590;
            }

        }
    
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwPeriodo.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE EDITAR EL CULTIVO :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int cod_pd= Int32.Parse(row.Cells[0].Value.ToString());
                    CerrarFormulario<EditarPeriodoDesarrollo>();
                    AbrirFormularioEditar(cod_pd);

                    if (panelFormularios.Width == 590)
                    {
                        panelFormularios.Width = 15;
                    }
                    else
                    {
                        panelFormularios.Width = 590;
                    }
                }
            }

        }

        public void AbrirFormularioEditar(int codigo)
        {
            EditarPeriodoDesarrollo formulario;
            formulario = panelFormularios.Controls.OfType<EditarPeriodoDesarrollo>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new EditarPeriodoDesarrollo();
                AddOwnedForm(formulario);
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.cod_pd = codigo;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwPeriodo.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL CULTIVO: " + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        _pEn.COD_PD = Int32.Parse(row.Cells[0].Value.ToString());
                        int resultado = _pd.Del_Periodo(_pEn);
                        if (resultado >= 1)
                        {
                            MessageBox.Show("Cultivo Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DgwPeriodo.DataSource = _pd.MostrarPeriodo(); 
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            DgwPeriodo.DataSource = _pd.BuscarPeriodo(BtnBuscar.Text);
        }
        #region Funcionalidades del Formulario
        private void panel_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
    }
}
