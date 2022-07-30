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
    public class CultivoDAL
    {
        public int Reg_Cultivo(Cultivo cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_CULTIVO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_PD", cEn.COD_PD));
            _comand.Parameters.Add(new SqlParameter("@INICIO", cEn.INICIO));
            _comand.Parameters.Add(new SqlParameter("@AREA", cEn.AREA));
            _comand.Parameters.Add(new SqlParameter("@CODIGO", cEn.CODIGO));

            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public DataTable Mostrar_Cultivo(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_CULTIVO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Del_Cultivo(Cultivo cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("DEL_CULTIVO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_CUL", cEn.COD_CUL));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}
