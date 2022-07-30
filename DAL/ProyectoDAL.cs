using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProyectoDAL
    {
        public int Reg_Proyecto(Proyecto pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("REG_PROYECTO",_conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@NOMBRE", pEn.NOMBRE_PROYECTO));
            _comand.Parameters.Add(new SqlParameter("@LUGAR", pEn.LUGAR));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }

        public List<Proyecto> MostrarProyecto()
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("SELECT * FROM PROYECTO", _conn as SqlConnection);
            _comand.CommandType = CommandType.Text;
            IDataReader _reader = _comand.ExecuteReader();
            List<Proyecto> lista = new List<Proyecto>(); 
            while (_reader.Read())
            {
                Proyecto _proyecto = new Proyecto();
                _proyecto.CODIGO = _reader.GetInt32(0);
                _proyecto.NOMBRE_PROYECTO = _reader.GetString(1);
                _proyecto.LUGAR = _reader.GetString(2);
                _proyecto.FECHA = _reader.GetDateTime(3);
                lista.Add(_proyecto);
            }
            _conn.Close();
            return lista;
        }

        public int Edi_Proyecto(Proyecto pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("EDI_PROYECTO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", pEn.CODIGO));
            _comand.Parameters.Add(new SqlParameter("@NOMBRE", pEn.NOMBRE_PROYECTO));
            _comand.Parameters.Add(new SqlParameter("@LUGAR", pEn.LUGAR));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public int Del_Proyecto(Proyecto pEn)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("DEL_PROYECTO", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@CODIGO", pEn.CODIGO));
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
    }
}
