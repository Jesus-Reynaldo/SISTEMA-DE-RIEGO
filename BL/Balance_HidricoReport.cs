using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;
namespace BL
{
    public class Balance_HidricoReport
    {
        public List<Balance_Hidrico> HidricoListing { get; set; }
        // Metodos
        public void createHidricoReport(int codigo)
        {
            var _bhDAL = new Balance_HidricoDAL();
            var result = _bhDAL.Mostrar_Balance_Hidrico(codigo);
            HidricoListing = new List<Balance_Hidrico>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var HidricoModel = new Balance_Hidrico()
                {
                    CULTIVO = Convert.ToString(rows[0]),
                    MES = Convert.ToString(rows[1]),
                    DIAS = Convert.ToInt32(rows[2]),
                    KC = Convert.ToSingle(rows[3]),
                    ETc = Convert.ToSingle(rows[4]),
                    Hn = Convert.ToSingle(rows[5]),
                    AREA = Convert.ToSingle(rows[6]),
                    Vn = Convert.ToSingle(rows[7]),
                    Vbruto = Convert.ToSingle(rows[8]),
                    NUM = Convert.ToInt32(rows[9])
                };
                HidricoListing.Add(HidricoModel);
            }
        }
    }
}
