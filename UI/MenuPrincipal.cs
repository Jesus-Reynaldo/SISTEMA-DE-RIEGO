using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN;
namespace UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
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

        #region Funcionalidades del Formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion


        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 80)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 230;
                panelTransion.ShowSync(panelMenu);
                LogoTransion.ShowSync(Logo);
            }
            else
            {
                LogoTransion.Hide(Logo);
                panelMenu.Visible = false;
                panelMenu.Width = 80;
                panelTransion.ShowSync(panelMenu);
            }
        }

        private void BtnProyecto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProyectoUI>();
        }

        private void BtnCultivo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CultivoUI>();
            CerrarFormulario<ProyectoUI>();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            CerrarFormulario<ProyectoUI>();
            CerrarFormulario<CultivoUI>();
            CerrarFormulario<DiseñoAgronomicoUI>();
            CerrarFormulario<DiseñoHidraulicoUI>();
            CerrarFormulario<Copia_Seguridad>();
            Datos_ClimaticosUI.getCerrar();
            PeriodoDesarrollo.getCerrar();
        }

        private void BtnAgronomico_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DiseñoAgronomicoUI>();
            CerrarFormulario<CultivoUI>();
        }

        private void BtnHidraulico_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DiseñoHidraulicoUI>();
            CerrarFormulario<DiseñoAgronomicoUI>();
        }

        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            CerrarFormulario<ProyectoUI>();
            CerrarFormulario<CultivoUI>();
            CerrarFormulario<DiseñoAgronomicoUI>();
            CerrarFormulario<DiseñoHidraulicoUI>();
            CodPro.getCerrar();
            Datos_ClimaticosUI.getCerrar();
            BtnCerrarSesion.Visible = false;
            BtnProyecto.Enabled = true;
            LblProyecto.Visible = false;
            BtnAgronomico.Enabled = false;
            BtnCultivo.Enabled = false;
            BtnHidraulico.Enabled = false;

            Btn_Agro.ForeColor = Color.Silver;
            Btn_cul.ForeColor = Color.Silver;
            Btn_hidra.ForeColor = Color.Silver;
            Btn_proy.Enabled = true;
            Btn_proy.ForeColor = Color.Silver;

            Cir_agro.RadioColor = Color.Silver;
            Cir_Cul.RadioColor = Color.Silver;
            Cir_hidra.RadioColor = Color.Silver;
            Cir_proy.RadioColor = Color.Silver;

            Cir_agro.OutlineColor = Color.Gray;
            Cir_Cul.OutlineColor = Color.Gray;
            Cir_hidra.OutlineColor = Color.Gray;
            Cir_proy.OutlineColor = Color.Gray;
        
            Sepa_agro.LineColor = Color.FromArgb(128, 128, 128);
            Sepa_cul.LineColor = Color.FromArgb(128, 128, 128);
            Sepa_proy.LineColor = Color.FromArgb(128, 128, 128);

        }

        private void BtnCopiaSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Copia_Seguridad>();
        }

        private void panel_Proy_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProyectoUI>();
        }

        private void Btn_proy_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProyectoUI>();
        }

        private void Btn_cul_Click(object sender, EventArgs e)
        {
            CodPro _cod = CodPro.getInstancia();
            if (_cod.COD_CUL==1)
            {
                AbrirFormulario<CultivoUI>();
                CerrarFormulario<ProyectoUI>();
            }
            else
            {
                MessageBox.Show("Debe abrir un PROYECTO, para realizar esta accion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Agro_Click(object sender, EventArgs e)
        {
            CodPro _cod = CodPro.getInstancia();
            if (_cod.COD_AGRO == 1)
            {
                AbrirFormulario<DiseñoAgronomicoUI>();
                CerrarFormulario<CultivoUI>();
            }
            else
            {
                MessageBox.Show("No pudo realizar la accion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_hidra_Click(object sender, EventArgs e)
        {
            CodPro _cod = CodPro.getInstancia();
            if (_cod.COD_HIDRA == 1)
            {
                AbrirFormulario<DiseñoHidraulicoUI>();
                CerrarFormulario<DiseñoAgronomicoUI>();
            }
            else
            {
                MessageBox.Show("No pudo realizar la accion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }
}
