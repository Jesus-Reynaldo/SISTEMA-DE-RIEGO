using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class DiseñoAgricolaReport
    {
        public List<DiseñoAgricola> AgricolaListing { get; set; }
        // Metodos
        public void createAgricolaReport(int codigo)
        {
            var _agDAL = new DiseñoAgricolaDAL();
            var result = _agDAL.Mostrar_Diseño_Agro(codigo);
            AgricolaListing = new List<DiseñoAgricola>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var AgricolaModel = new DiseñoAgricola()
                {

                       NUM = Convert.ToInt32(rows[0]),
                       MES = Convert.ToString(rows[1]),
                       CULTIVO = Convert.ToString(rows[2]),
                       CC = Convert.ToSingle(rows[3]),
                       PMP = Convert.ToSingle(rows[4]),
                       Da = Convert.ToSingle(rows[5]),
                       HA = Convert.ToSingle(rows[6]),
                       Ln = Convert.ToSingle(rows[7]),
                       Lb = Convert.ToSingle(rows[8]),
                       ETc = Convert.ToSingle(rows[9]),
                       Fr = Convert.ToSingle(rows[10]),
                       TURNO =  Convert.ToInt32(rows[11]),
                       Aasp = Convert.ToSingle(rows[12]),
                       Qasp = Convert.ToSingle(rows[13]),
                       Ph = Convert.ToSingle(rows[14]),
                       Tr = Convert.ToInt32(rows[15]),
                       Tap = Convert.ToInt32(rows[16]),
                       Vh = Convert.ToSingle(rows[17]),
                       Vt = Convert.ToSingle(rows[18]),
                       Q = Convert.ToSingle(rows[19]),
                       TEXTURA = Convert.ToString(rows[20]),
                       Pre = Convert.ToSingle(rows[21]),
                       NR = Convert.ToSingle(rows[22]),
                       Ea = Convert.ToSingle(rows[23]),
                };
                AgricolaListing.Add(AgricolaModel);
            }
        }
    }
}
