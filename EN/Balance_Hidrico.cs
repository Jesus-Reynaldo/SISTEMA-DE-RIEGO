using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Balance_Hidrico
    {
        public int COD_CAL { get; set; }
        public string CULTIVO { get; set; }
        public float KC { get; set; }
        public float ETc { get; set; }
        public float Hn { get; set; }
        public float AREA { get; set; }
        public float Vn { get; set; }
        public int COD_CUL { get; set; }
        //CONSULTA
        public string MES { get; set; }
        public int DIAS { get; set; }
        public float Vbruto { get; set; }
        public int NUM { get; set; }

    }
}
