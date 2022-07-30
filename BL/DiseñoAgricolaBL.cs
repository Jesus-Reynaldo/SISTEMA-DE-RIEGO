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
   public class DiseñoAgricolaBL
    {
        DiseñoAgricolaDAL _dal = new DiseñoAgricolaDAL();
        public int Reg_Diseño_Agro(DiseñoAgricola cEN)
        {
            return _dal.Reg_Diseño_Agro(cEN);
        }
        public DataTable Mostrar_Diseño_Agro(int codigo)
        {
            return _dal.Mostrar_Diseño_Agro(codigo);
        }
        public DataTable Mostrar_Resumen_Agro(int codigo)
        {
            return _dal.Mostrar_Resumen_Agro(codigo);
        }
        public int Del_Diseño_Agro(DiseñoAgricola cEN)
        {
            return _dal.Del_Diseño_Agro(cEN);
        }
    }
}
