using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EN;
using BL;

namespace UI
{
    public partial class AspersorUI : Form
    {
        Aspersor _aEn = new Aspersor();
        AspersorBL _aBL = new AspersorBL();
        private static AspersorUI instancia;
        public AspersorUI()
        {
            InitializeComponent();
        }
        public static AspersorUI getInstancia()
        {
            if (instancia == null)
            {
                instancia = new AspersorUI();
            }
            return instancia;
        }
        // cerrar instancia
        public static AspersorUI getCerrar()
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

        private void AspersorUI_Load(object sender, EventArgs e)
        {
            DgwAspersor.DataSource = _aBL.MostrarAspersor();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CerrarFormulario<Registrar_AspersorUI>();
            AbrirFormulario<Registrar_AspersorUI>();

            if (panelFormularios.Width == 590)
            {
                panelFormularios.Width = 15;
            }
            else
            {
                panelFormularios.Width = 590;
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwAspersor.SelectedRows)
            {
                if (MessageBox.Show("EL ASPERSOR: " + row.Cells[1].Value.ToString() + " ESTA SELECCIONADO", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DiseñoAgronomicoUI _da = ((DiseñoAgronomicoUI)(Owner));
                    _da.cod_asp = Int32.Parse(row.Cells[0].Value.ToString());
                    _da.LblAspersor.Text = row.Cells[1].Value.ToString();
                    _da.LblAasp.Text = row.Cells[5].Value.ToString();
                    _da.LblQasp.Text = row.Cells[4].Value.ToString();
                    this.Close();                    
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgwAspersor.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE EDITAR EL ASPERSOR :" + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int cod_asp = Int32.Parse(row.Cells[0].Value.ToString());
                    CerrarFormulario<Editar_AspersorUI>();
                    AbrirFormularioEditar(cod_asp);

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
            Editar_AspersorUI formulario;
            formulario = panelFormularios.Controls.OfType<Editar_AspersorUI>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                                      //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new Editar_AspersorUI();
                AddOwnedForm(formulario);
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.cod_asp = codigo;
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
            foreach (DataGridViewRow row in DgwAspersor.SelectedRows)
            {
                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL ASPERSOR: " + row.Cells[1].Value.ToString() + " ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        _aEn.COD_ASP = Int32.Parse(row.Cells[0].Value.ToString());
                        int resultado = _aBL.Del_Aspersor(_aEn);
                        if (resultado >= 1)
                        {
                            MessageBox.Show("Cultivo Eliminado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DgwAspersor.DataSource = _aBL.MostrarAspersor();
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
