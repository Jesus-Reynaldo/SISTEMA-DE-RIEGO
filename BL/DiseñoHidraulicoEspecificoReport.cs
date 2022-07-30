using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
    public class DiseñoHidraulicoEspecificoReport
    {
        public List<DiseñoHidraulico> HidraListing { get; set; }
        // Metodos
        public void createHidraReportEspecifico(int codigo, string topografia)
        {
            var _dhDAL = new DiseñoHidraulicoDAL();
            var result = _dhDAL.Mostrar_Hidraulico(codigo,topografia);
            HidraListing = new List<DiseñoHidraulico>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var HidraModel = new DiseñoHidraulico()
                {
                    COD_DIS = Convert.ToInt32(rows[0]),
                    Hg = Convert.ToSingle(rows[1]),
                    hs = Convert.ToSingle(rows[2]),
                    Ha = Convert.ToSingle(rows[3]),
                    TOPOGRAFIA = Convert.ToString(rows[4]),
                    TUBERIA = Convert.ToString(rows[5]),
                    LT = Convert.ToSingle(rows[6]),
                    LL = Convert.ToSingle(rows[7]),
                    LrL = Convert.ToSingle(rows[8]),
                    NA = Convert.ToInt32(rows[9]),
                    NL = Convert.ToInt32(rows[10]),
                    QL = Convert.ToSingle(rows[11]),
                    QTT = Convert.ToSingle(rows[12]),
                    LTT = Convert.ToSingle(rows[13]),
                    DT = Convert.ToSingle(rows[14]),
                    Jt = Convert.ToSingle(rows[15]),
                    J = Convert.ToSingle(rows[16]),
                    h = Convert.ToSingle(rows[17]),
                    Pa = Convert.ToSingle(rows[18]),
                    Po = Convert.ToSingle(rows[19]),
                    Pn = Convert.ToSingle(rows[20]),
                    DL = Convert.ToSingle(rows[21]),
                    COD_ASP = Convert.ToInt32(rows[22]),
                    CODIGO = Convert.ToInt32(rows[23]),
                    COD = Convert.ToInt32(rows[24]),
                    TIPO = Convert.ToString(rows[26]),
                    MARCO = Convert.ToString(rows[27]),
                    Qasp = Convert.ToSingle(rows[29]),
                    Aasp = Convert.ToSingle(rows[30]),
                    Ph = Convert.ToSingle(rows[31]),
                    Sa = Convert.ToSingle(rows[32]),
                    Sl = Convert.ToSingle(rows[33]),
                    lo = Convert.ToSingle(rows[35]),
                    n = Convert.ToInt32(rows[36]),
                    F = Convert.ToSingle(rows[37]),
                    NUM = Convert.ToInt32(rows[38])

                };
                HidraListing.Add(HidraModel);
            }
        }
    }
}
