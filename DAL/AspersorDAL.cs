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
    public class AspersorDAL
    {
        public DataTable MostrarAspersor()
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_ASPERSOR", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }

        public DataTable Buscar_Aspersor(string texto)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("BUSCAR_ASPERSOR", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@TEXTO", texto));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Reg_Aspersor(Aspersor aEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_ASPERSOR", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@TIPO", aEn.TIPO));
            _comand.Parameters.Add(new SqlParameter("@MARCO", aEn.MARCO));
            _comand.Parameters.Add(new SqlParameter("@Pa", aEn.Pa));
            _comand.Parameters.Add(new SqlParameter("@Qasp ", aEn.Qasp));
            _comand.Parameters.Add(new SqlParameter("@Sa", aEn.Sa));
            _comand.Parameters.Add(new SqlParameter("@Sl",aEn.Sl));

            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }

        public int Edi_Aspersor(Aspersor aEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("EDI_ASPERSOR", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_ASP", aEn.COD_ASP));
            _comand.Parameters.Add(new SqlParameter("@TIPO", aEn.TIPO));
            _comand.Parameters.Add(new SqlParameter("@MARCO", aEn.MARCO));
            _comand.Parameters.Add(new SqlParameter("@Pa", aEn.Pa));
            _comand.Parameters.Add(new SqlParameter("@Qasp ", aEn.Qasp));
            _comand.Parameters.Add(new SqlParameter("@Sa", aEn.Sa));
            _comand.Parameters.Add(new SqlParameter("@Sl", aEn.Sl));

            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }

        public int Del_Aspersor(Aspersor aEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("DEL_ASPERSOR", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_ASP", aEn.COD_ASP));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }

        public DataTable Mostrar_Aspersor_Uno(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_ASPERSOR_UNO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_ASP", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }

    }
}
