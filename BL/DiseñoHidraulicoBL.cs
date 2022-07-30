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
    public class DiseñoHidraulicoBL
    {
        DiseñoHidraulicoDAL _dal = new DiseñoHidraulicoDAL();
        public int Reg_DiseñoHidraulico(DiseñoHidraulico cEN)
        {
            return _dal.Reg_DiseñoHidraulico(cEN);
        }
        public DataTable Mostrar_DiseñoHidraulico(int codigo)
        {
            return _dal.Mostrar_DiseñoHidraulico(codigo);
        }
        public int Del_DiseñoHidraulico(DiseñoHidraulico cEN)
        {
            return _dal.Del_DiseñoHidraulico(cEN);
        }
    }
}
