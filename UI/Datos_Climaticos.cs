using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.IO;
using EN;
using BL;

namespace UI
{
    public partial class Datos_ClimaticosUI : Form
    {
        private static Datos_ClimaticosUI instancia;
        private Datos_ClimaticosUI()
        {
            InitializeComponent();
            DgwDatos.Rows.Add("ENERO");
            DgwDatos.Rows.Add("FEBRERO");
            DgwDatos.Rows.Add("MARZO");
            DgwDatos.Rows.Add("ABRIL");
            DgwDatos.Rows.Add("MAYO");
            DgwDatos.Rows.Add("JUNIO");
            DgwDatos.Rows.Add("JULIO");
            DgwDatos.Rows.Add("AGOSTO");
            DgwDatos.Rows.Add("SEPTIEMBRE");
            DgwDatos.Rows.Add("OCTUBRE");
            DgwDatos.Rows.Add("NOVIEMBRE");
            DgwDatos.Rows.Add("DICIEMBRE");
        }
        public static Datos_ClimaticosUI getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Datos_ClimaticosUI();
            }
            return instancia;
        }
        // cerrar instancia
        public static Datos_ClimaticosUI getCerrar()
        {
            if (instancia != null)
            {
                instancia = null;
            }
            return instancia;
        }
        public int resultado { get; set; }
        Datos_Climaticos _en = new Datos_Climaticos();
        Datos_ClimaticosBL _bl = new Datos_ClimaticosBL();
        CodPro _cod = CodPro.getInstancia();


        private void CeldasVacias()
        {
            foreach (DataGridViewRow row in DgwDatos.Rows)
            {
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[0].Value)))
                {
                    DgwDatos.Rows.RemoveAt(row.Index);
                    /*ACA VA EL CODIGO QUE NECESITAS HACER EN CASO QUE SE DE ESTA CONDICION*/
                }
            }
        }

        private bool CeldasVacias(int columna)
        {
            foreach (DataGridViewRow row in DgwDatos.Rows)
            {
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[columna].Value)))
                {
                    return true;
                    /*ACA VA EL CODIGO QUE NECESITAS HACER EN CASO QUE SE DE ESTA CONDICION*/
                }
            }
            return false;
        }

        private bool ValidarCampo()
        {
            if (CeldasVacias(1) || CeldasVacias(2) )
            {
                if (MessageBox.Show("Existen espacios vacíos, los cuales tomaran el valor de cero. ¿Está seguro de continuar con el registro? ", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (_cod.CODIGO != 0)
            {
                if (ValidarCampo())
                {
                    try
                    {
                        foreach (DataGridViewRow row in DgwDatos.Rows)
                        {
                            _en.CODIGO = _cod.CODIGO;
                            _en.MES = Convert.ToString(row.Cells[0].Value);
                            if (Convert.ToString(row.Cells[1].Value) == "")
                                _en.PRECIPITACION = 0;
                            else
                                _en.PRECIPITACION = float.Parse(Convert.ToString(row.Cells[1].Value));
                            if (Convert.ToString(row.Cells[2].Value) == "")
                                _en.ETo = 0;
                            else
                                _en.ETo = float.Parse(Convert.ToString(row.Cells[2].Value));
                            resultado = _bl.Reg_Datos_Climaticos2(_en);
                        }

                        MessageBox.Show("Registrado!!!..", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CultivoUI _cu = ((CultivoUI)(Owner));
                        _cu.DgwDatosClimaticos.DataSource = _bl.Mos_Datos_Climaticos(_cod.CODIGO);
                        _cu.panelCultivo.Enabled = true;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUDO REGISTRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("NO SE ENCUENTRA PROYECTO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            DgwDatos.Columns.RemoveAt(DgwDatos.ColumnCount - 1);
            DgwDatos.Columns.RemoveAt(DgwDatos.ColumnCount - 1);
            DgwDatos.Columns.RemoveAt(DgwDatos.ColumnCount-1);
            OpenFileDialog myFileDialog = new OpenFileDialog();
            string xSheet = "";
            // With...
            myFileDialog.Filter = "Excel Files |*.xlsx";
            myFileDialog.Title = "Open File";
            myFileDialog.ShowDialog();
            if ((myFileDialog.FileName.ToString() != ""))
            {
                string ExcelFile = myFileDialog.FileName.ToString();
                DataSet ds = new DataSet();
                OleDbDataAdapter da;
                DataTable dt;
                OleDbConnection conn;
                xSheet = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre de la Hoja que desea importar", "Complete");
                conn = new OleDbConnection(("Provider=Microsoft.ACE.OLEDB.12.0;" + ("data source="
                                + (ExcelFile + ("; " + "Extended Properties=\'Excel 12.0 Xml;HDR=Yes\'")))));
                try
                {
                    da = new OleDbDataAdapter("Select * From [" + xSheet + "$]", conn);
                    conn.Open();
                    da.Fill(ds, "MyData");
                    dt = ds.Tables["MyData"];
                    DgwDatos.DataSource = ds;
                    DgwDatos.DataMember = "MyData";
                    CeldasVacias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inserte un nombre valido de la Hoja que desea importar", "Informacion");
                }
                finally
                {
                    conn.Close();
                }

            }

            MessageBox.Show("Se ha cargado la importacion correctamente", "Importado con exito");
        }

        private void DgwDatos_KeyPress(object sender, KeyPressEventArgs e)
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
