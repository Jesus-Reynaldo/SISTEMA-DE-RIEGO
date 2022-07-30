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
    public partial class Copia_Seguridad : Form
    {
        Copia_SeguridadEN _eN = new Copia_SeguridadEN();
        Copia_SeguridadBL _BL = new Copia_SeguridadBL();
        public Copia_Seguridad()
        {
            InitializeComponent();
        }

        private void BtnExaminarG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtBackup.Text = dlg.SelectedPath;
                BtnGenerar.Enabled = true;
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBackup.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    _eN.generar = TxtBackup.Text.ToString();
                    int resultado = _BL.Generar_copia(_eN);
                    MessageBox.Show("SE REALIZO UNA COPIA DE SEGURIDAD!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("NO SE PUDO HACER LA COPIA DE SEGURIDAD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExaminarR_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtRestaurar.Text = dlg.FileName;
                BtnRestaurar.Enabled = true;
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRestaurar.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    _eN.copia = TxtRestaurar.Text.ToString();
                    _BL.Restaurar_copia(_eN);
                    MessageBox.Show("SE RESTAURO LA BASE DE DATOS!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("NO SE PUDO RESTAURAR LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
