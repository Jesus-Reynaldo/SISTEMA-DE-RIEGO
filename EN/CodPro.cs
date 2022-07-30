using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class CodPro
    {
        private static CodPro instancia;
        private CodPro()
        {

        }
        public static CodPro getInstancia()
        {
            if (instancia == null)
            {
                instancia = new CodPro();
            }
            return instancia;
        }
        public static CodPro getCerrar()
        {
            if (instancia != null)
            {
                instancia = null;
            }
            return instancia;
        }
        public int CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string LUGAR { get; set; }
        public DateTime FECHA { get; set; }
        public int COD_LAT { get; set; }
        public string TOPOGRAFIA { get; set; }
        public float Hg { get; set; }
        public float h  { get; set; }

        public int COD_CUL{ get; set; }
        public int COD_AGRO { get; set; }
        public int COD_HIDRA { get; set; }
    }
}
