using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class LateralBL
    {
        public List<Lateral> LateralListing { get; set; }
        // Metodos
        public void createHidraReport(int codigo)
        {
            var _dlDAL = new LateralDAL();
            var _result = _dlDAL.Mostrar_Lateral(codigo);
            LateralListing = new List<Lateral>();
            foreach (System.Data.DataRow rows in _result.Rows)
            {
                var LateralModel = new Lateral()
                {
                    NUM = Convert.ToInt32(rows[0]),
                    DIAMETRO = Convert.ToSingle(rows[1]),
                    PERDIDA = Convert.ToSingle(rows[2]),         
                };
                LateralListing.Add(LateralModel);
            }
        }
    }
}
