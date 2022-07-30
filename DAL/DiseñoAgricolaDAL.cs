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
    public class DiseñoAgricolaDAL
    {
        public int Reg_Diseño_Agro(DiseñoAgricola cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_DIS_AGRO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", cEn.CODIGO));
            _comand.Parameters.Add(new SqlParameter("@TEXTURA", cEn.TEXTURA));
            _comand.Parameters.Add(new SqlParameter("@Pre", cEn.Pre));
            _comand.Parameters.Add(new SqlParameter("@NR", cEn.NR));
            _comand.Parameters.Add(new SqlParameter("@Ea", cEn.Ea));
            _comand.Parameters.Add(new SqlParameter("@COD_ASP", cEn.COD_ASP));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public DataTable Mostrar_Diseño_Agro(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_DISEÑO_AGRONOMICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public DataTable Mostrar_Resumen_Agro(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_RESUMEN_AGRONOMICO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Del_Diseño_Agro(DiseñoAgricola cEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("DEL_DISEÑO_AGRO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", cEn.CODIGO));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}

