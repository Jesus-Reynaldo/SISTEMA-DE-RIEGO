using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
    public class Copia_SeguridadBL
    {
        Copia_de_seguridadDAL _dal = new Copia_de_seguridadDAL();
        public int Generar_copia(Copia_SeguridadEN cEN)
        {
            return _dal.Generar_Copia(cEN);
        }
        public void Restaurar_copia(Copia_SeguridadEN cEN)
        {
            _dal.restaurar_copia(cEN);
        }
    }
}
