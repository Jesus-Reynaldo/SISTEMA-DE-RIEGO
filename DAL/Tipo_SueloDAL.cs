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
    public class Tipo_SueloDAL
    {
        public DataTable Mostrar_Textura()
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("SELECT TEXTURA FROM TIPO_SUELO", _conn as SqlConnection);
            _comand.CommandType = CommandType.Text;
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
    }
}
