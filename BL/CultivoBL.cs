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
    public class CultivoBL
    {
        CultivoDAL _dal = new CultivoDAL();
        public int Reg_Cultivo(Cultivo cEN)
        {
            return _dal.Reg_Cultivo(cEN);
        }
        public DataTable Mostrar_Cultivo(int codigo)
        { 
            return _dal.Mostrar_Cultivo(codigo);
        }
        public int Del_Cultivo(Cultivo cEN)
        {
            return _dal.Del_Cultivo(cEN);
        }
    }
}
