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
    public class TuberiaBL
    {
        TuberiaDAL _dal = new TuberiaDAL();

        public List<Tuberia> Mos_Tuberia(Tuberia En)
        {
            return _dal.Mostrar_Tuberia(En);
        }
        public DataTable Mos_Tipo()
        {
            return _dal.Mostrar_Tipo();
        }

    }
}
