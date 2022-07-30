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
    public class Periodo_DesarrolloBL
    {
        Periodo_DesarrolloDAL _dal = new Periodo_DesarrolloDAL();

        public DataTable MostrarPeriodo()
        {
            return _dal.MostrarPeriodo();
        }
        public DataTable BuscarPeriodo(string cultivo)
        {
            return _dal.BuscarPeriodo(cultivo);
        }
        public int Reg_Periodo(Periodo_Desarrollo pEN)
        {
            return _dal.Reg_Periodo(pEN);
        }
        public DataTable Mostrar_Periodo_Total(int codigo)
        {
            return _dal.Mostrar_Periodo_Total(codigo);
        }
        public int Edi_Periodo(Periodo_Desarrollo pEN)
        {
            return _dal.Edi_Periodo(pEN);
        }
        public int Del_Periodo(Periodo_Desarrollo pEN)
        {
            return _dal.Del_Periodo(pEN);
        }
    }
}
