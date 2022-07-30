using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class CultivoReport
    {
        public List<CultivoEN> CultivoListing { get; set; }
        // Metodos
        public void createCultivoReport(int codigo)
        {
            var _cuDAL = new CultivoDAL();
            var result = _cuDAL.Mostrar_Cultivo(codigo);
            CultivoListing = new List<CultivoEN>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var CultivoModel = new CultivoEN()
                {
                    CULTIVO = Convert.ToString(rows[1]),
                    INICIO = Convert.ToString(rows[2]),
                    DURACION = Convert.ToString(rows[3]),
                    AREA = Convert.ToString(rows[4])
                };
                CultivoListing.Add(CultivoModel);
            }
        }

    }
}
