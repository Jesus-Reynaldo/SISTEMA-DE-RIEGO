using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EN;

namespace DAL
{
    public class Datos_ClimaticosDAL
    {
        public int Reg_Datos_Climaticos(Datos_Climaticos pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_DATOS_CLIMATICOS", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", pEn.CODIGO));
            _comand.Parameters.Add(new SqlParameter("@MES", pEn.MES));
            _comand.Parameters.Add(new SqlParameter("@P", pEn.PRECIPITACION));
            _comand.Parameters.Add(new SqlParameter("@ETo", pEn.ETo));
            _comand.Parameters.Add(new SqlParameter("@Pe", pEn.Pe));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public DataTable Mos_Datos_Climaticos(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_DATOS_CLIMATICOS", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Reg_Datos_Climaticos2(Datos_Climaticos pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_DATOS_CLIMATICOS2", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", pEn.CODIGO));
            _comand.Parameters.Add(new SqlParameter("@MES", pEn.MES));
            _comand.Parameters.Add(new SqlParameter("@P", pEn.PRECIPITACION));
            _comand.Parameters.Add(new SqlParameter("@ETo", pEn.ETo));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}
