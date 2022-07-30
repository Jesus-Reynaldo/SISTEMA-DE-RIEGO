using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Tuberia
    {
        public int ID { get; set; }
        public string TIPO { get; set; }
        public float DIAMETRO_NOMINAL { get; set; }
        public float ESPESOR_MINIMO { get; set; }
        public float PRESION { get; set; }
    }
}
