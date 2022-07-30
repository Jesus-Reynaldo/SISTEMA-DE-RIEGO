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
    public class Balance_HidricoBL
    {
        Balance_HidricoDAL _dal = new Balance_HidricoDAL();
        public DataTable Mostrar_Balance_Hidrico(int codigo)
        {
            return _dal.Mostrar_Balance_Hidrico(codigo);
        }

        public DataTable Mostrar_Valor_Vn(int codigo)
        {
            return _dal.Mostrar_Valor_Vn(codigo);
        }
    }
}
