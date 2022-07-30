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
    public class AspersorBL
    {
        AspersorDAL _dal = new AspersorDAL();

        public DataTable MostrarAspersor()
        {
            return _dal.MostrarAspersor();
        }
        public DataTable Buscar_Aspersor(string texto)
        {
            return _dal.Buscar_Aspersor(texto);
        }
        public int Reg_Aspersor(Aspersor aEN)
        {
            return _dal.Reg_Aspersor(aEN);
        }
        public int Edi_Asperor(Aspersor aEN)
        {
            return _dal.Edi_Aspersor(aEN);
        }
        public int Del_Aspersor(Aspersor aEN)
        {
            return _dal.Del_Aspersor(aEN);
        }
        public DataTable Mostrar_Aspersor_Uno(int codigo)
        {
            return _dal.Mostrar_Aspersor_Uno(codigo);
        }
    }
}
