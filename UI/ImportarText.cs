using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace UI
{
    public class ImportarText
    {
        private static ImportarText instancia;
        DataTable table = new DataTable();
        private ImportarText()
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

        }
        public static ImportarText getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ImportarText();
            }
            return instancia;
        }
        public void Importar()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            dialog.Title = "IMPORTAR DATOS DESDE EXCEL";
            dialog.FileName = string.Empty;
            string name = dialog.FileName;
            string[] lines = File.ReadAllLines(name);
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
    }
}
