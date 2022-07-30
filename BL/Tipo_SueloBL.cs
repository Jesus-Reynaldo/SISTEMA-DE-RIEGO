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
    public class Tipo_SueloBL
    {
        Tipo_SueloDAL _dal = new Tipo_SueloDAL();
        public DataTable Mostrar_Textura()
        {
            return _dal.Mostrar_Textura();
        }
    }
}
