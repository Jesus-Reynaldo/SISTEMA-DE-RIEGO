using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace UI
{
    public class Importar
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet DatosExcel(string nameExcel, string hoja)
        {
            OleDbConnection connection = null;
            DataSet dataSet = null;
            OleDbDataAdapter dbDataAdapter = null;
            string query = "select * from [" + hoja + "$]";
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + nameExcel + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'";
            try
            {
                connection = new OleDbConnection(cadenaConexion);
                connection.Open();
                dbDataAdapter = new OleDbDataAdapter(query, connection);
                dataSet = new DataSet();
                dbDataAdapter.Fill(dataSet, hoja);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }
    }
}
