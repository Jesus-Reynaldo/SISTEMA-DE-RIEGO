using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;
namespace BL
{
    public class ProyectoBL
    {
        ProyectoDAL _dal = new ProyectoDAL();

        public int Reg_Proyecto(Proyecto pEN)
        {
            return _dal.Reg_Proyecto(pEN);
        }
        public List<Proyecto> MostrarProyecto()
        {
            return _dal.MostrarProyecto();
        }
        public int Edi_Proyecto(Proyecto pEN)
        {
            return _dal.Edi_Proyecto(pEN);
        }
        public int Del_Proyecto(Proyecto pEN)
        {
            return _dal.Del_Proyecto(pEN);
        }
    }
}
