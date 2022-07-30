using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MesesDAL
    {
        public DataTable MostrarMeses()
        {
            IDbConnection _conn = DBConnetion.Conexion();
            DataTable _tabla = new DataTable();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("SELECT MES FROM MESES", _conn as SqlConnection);
            _comand.CommandType = CommandType.Text;
            IDataReader _reader = _comand.ExecuteReader();
            _tabla.Load(_reader);
            _conn.Close();
            return _tabla;
        }
    }
}
