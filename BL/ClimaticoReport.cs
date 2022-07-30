using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class ClimaticoReport
    {
        public List<Datos_Climaticos> ClimaListing { get; set; }
        // Metodos
        public void createClimaticoReport(int codigo)
        {
            var _cliDAL = new Datos_ClimaticosDAL();
            var result = _cliDAL.Mos_Datos_Climaticos(codigo);
            ClimaListing = new List<Datos_Climaticos>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ClimaModel = new Datos_Climaticos()
                {
                    MES = Convert.ToString(rows[0]),
                    PRECIPITACION = Convert.ToSingle(rows[1]),
                    ETo = Convert.ToSingle(rows[2]),
                    Pe = Convert.ToSingle(rows[3])
                };
                ClimaListing.Add(ClimaModel);
            }
        }
    }
}