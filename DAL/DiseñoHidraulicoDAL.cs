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
    public class DiseñoHidraulicoDAL
    {
        public int Reg_DiseñoHidraulico(DiseñoHidraulico cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_DIS_HIDRAULICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@lo", cEn.lo));
            _comand.Parameters.Add(new SqlParameter("@hs", cEn.hs));
            _comand.Parameters.Add(new SqlParameter("@Ha", cEn.Ha));
            _comand.Parameters.Add(new SqlParameter("@Hg", cEn.Hg));
            _comand.Parameters.Add(new SqlParameter("@TOPOGRAFIA", cEn.TOPOGRAFIA));
            _comand.Parameters.Add(new SqlParameter("@TUBERIA", cEn.TUBERIA));
            _comand.Parameters.Add(new SqlParameter("@LT", cEn.LT));
            _comand.Parameters.Add(new SqlParameter("@LL", cEn.LL));
            _comand.Parameters.Add(new SqlParameter("@CODIGO ", cEn.CODIGO));

  
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public DataTable Mostrar_DiseñoHidraulico(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_DIS_HIDRAULICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public DataTable Mostrar_Diseño_Hidraulico(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_DISEÑO_HIDRAULICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public DataTable Mostrar_Hidraulico(int Codigo, string Topografia)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_HIDRAULICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            _comand.Parameters.Add(new SqlParameter("@TOPOGRAFIA",Topografia));   
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Del_DiseñoHidraulico(DiseñoHidraulico cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("ELIMINAR_DISEÑO_HIDRAULICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_DIS", cEn.COD_DIS));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}
