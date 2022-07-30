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
    public class Periodo_DesarrolloDAL
    {

        public DataTable MostrarPeriodo()
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_PERIODO_DESARROLLO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public DataTable Mostrar_Periodo_Repo(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_PERIODO_REPO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public DataTable BuscarPeriodo(string cultivo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("BUSCAR_PERIODO_DESARROLLO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CULTIVO", cultivo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Reg_Periodo(Periodo_Desarrollo pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_PERIODO_DESARROLLO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CULTIVO", pEn.CULTIVO));
            _comand.Parameters.Add(new SqlParameter("@D_I", pEn.D_I));
            _comand.Parameters.Add(new SqlParameter("@D_D", pEn.D_D));
            _comand.Parameters.Add(new SqlParameter("@D_M", pEn.D_M));
            _comand.Parameters.Add(new SqlParameter("@D_F", pEn.D_F));
            _comand.Parameters.Add(new SqlParameter("@KC_I", pEn.KC_I));
            _comand.Parameters.Add(new SqlParameter("@KC_D", pEn.KC_D));
            _comand.Parameters.Add(new SqlParameter("@KC_M", pEn.KC_M));
            _comand.Parameters.Add(new SqlParameter("@KC_F", pEn.KC_F));

            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public DataTable Mostrar_Periodo_Total(int Codigo)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_PERIODO_DESARROLLO_TODA", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_PD", Codigo));
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
        public int Edi_Periodo(Periodo_Desarrollo pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("EDI_PERIODO_DESARROLLO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_PD", pEn.COD_PD));
            _comand.Parameters.Add(new SqlParameter("@CULTIVO", pEn.CULTIVO));
            _comand.Parameters.Add(new SqlParameter("@D_I", pEn.D_I));
            _comand.Parameters.Add(new SqlParameter("@D_D", pEn.D_D));
            _comand.Parameters.Add(new SqlParameter("@D_M", pEn.D_M));
            _comand.Parameters.Add(new SqlParameter("@D_F", pEn.D_F));
            _comand.Parameters.Add(new SqlParameter("@KC_I", pEn.KC_I));
            _comand.Parameters.Add(new SqlParameter("@KC_D", pEn.KC_D));
            _comand.Parameters.Add(new SqlParameter("@KC_M", pEn.KC_M));
            _comand.Parameters.Add(new SqlParameter("@KC_F", pEn.KC_F));

            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }

        public int Del_Periodo(Periodo_Desarrollo pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("DEL_PERIODO_DESARROLLO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@COD_PD", pEn.COD_PD));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}
