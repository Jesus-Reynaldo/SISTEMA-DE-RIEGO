using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;


namespace BL
{
    public class PeriodoReport
    {
        public List<Periodo_Desarrollo> PeriodoListing { get; set; }
        // Metodos
        public void createPeriodoReport(int codigo)
        {
            var _pDAL = new Periodo_DesarrolloDAL();
            var result = _pDAL.Mostrar_Periodo_Repo(codigo);
            PeriodoListing = new List<Periodo_Desarrollo>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var PeriodoModel = new Periodo_Desarrollo()
                {
                    CULTIVO = Convert.ToString(rows[0]),
                    D_I = Convert.ToInt32(rows[1]),
                    D_D = Convert.ToInt32(rows[2]),
                    D_M = Convert.ToInt32(rows[3]),
                    D_F = Convert.ToInt32(rows[4]),
                    PERIODO_VEGETACION = Convert.ToInt32(rows[5]),
                    KC_I = Convert.ToSingle(rows[6]),
                    KC_D = Convert.ToSingle(rows[7]),
                    KC_M = Convert.ToSingle(rows[8]),
                    KC_F = Convert.ToSingle(rows[9])
                };
                PeriodoListing.Add(PeriodoModel);
            }
        }
    }
}
