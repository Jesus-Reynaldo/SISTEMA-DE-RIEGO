using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EN;
using DAL;

namespace BL
{
    public class Datos_ClimaticosBL
    {
        Datos_ClimaticosDAL _dal = new Datos_ClimaticosDAL();

        public int Reg_Datos_Climaticos(Datos_Climaticos pEN)
        {
            return _dal.Reg_Datos_Climaticos(pEN);
        }
        public DataTable Mos_Datos_Climaticos(int codigo)
        {
            return _dal.Mos_Datos_Climaticos(codigo);
        }
        public int Reg_Datos_Climaticos2(Datos_Climaticos pEN)
        {
            return _dal.Reg_Datos_Climaticos2(pEN);
        }
    }
}
