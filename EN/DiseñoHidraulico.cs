using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class DiseñoHidraulico
    {
        public int COD_DIS { get; set; }
        public float Hg { get; set; }
        public float hs { get; set; }
        public float Ha { get; set; }
        public string TOPOGRAFIA { get; set; }
        public string TUBERIA { get; set; }
        public float LT { get; set; }
        public float LL { get; set; }
        public float LrL { get; set; }
        public int NA { get; set; }
        public int NL { get; set; }
        public float QL { get; set; }
        public float QTT { get; set; }
        public float LTT { get; set; }
        public float DT { get; set; }
        public float Jt { get; set; }
        public float J { get; set; }
        public float h { get; set; }
        public float Pa { get; set; }
        public float Po { get; set; }
        public float Pn { get; set; }
        public float DL { get; set; }
        public int COD_ASP { get; set; }
        public int CODIGO { get; set; }
        public int COD { get; set; }
        public float lo { get; set; }

        //Aspersor
        public string TIPO { get; set; }
        public string MARCO { get; set; }
        public float Qasp { get; set; }
        public float Aasp { get; set; }
        public float Ph { get; set; }
        public float Sa { get; set; }
        public float Sl { get; set; }

        // MUNERO
        public int NUM { get; set; }

        //COEFICIENTE
        public int n { get; set; }
        public float F { get; set; }

    }
}
