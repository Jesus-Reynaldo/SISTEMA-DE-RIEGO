using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BL
{
    public class MesesBL
    {
        MesesDAL _dal = new MesesDAL();
        public DataTable MostrarMeses()
        {
            return _dal.MostrarMeses();
        }
    }
}
