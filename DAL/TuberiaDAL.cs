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
    public class TuberiaDAL
    {
        public List<Tuberia> Mostrar_Tuberia(Tuberia _en)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            SqlCommand _comand = new SqlCommand("MOS_TUBERIA", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            _comand.Parameters.Add(new SqlParameter("@TIPO", _en.TIPO));
            IDataReader _reader = _comand.ExecuteReader();
            List<Tuberia> Lista = new List<Tuberia>();
            while (_reader.Read())
            {
                Tuberia _tuberia = new Tuberia();

                _tuberia.ID = _reader.GetInt32(0);
                _tuberia.TIPO = _reader.GetString(1);
                _tuberia.DIAMETRO_NOMINAL = Convert.ToSingle(_reader[2]);
                _tuberia.ESPESOR_MINIMO = Convert.ToSingle(_reader[3]);
                _tuberia.PRESION = Convert.ToSingle(_reader[4]);

                Lista.Add(_tuberia);
              
            }
            _conn.Close();
            return Lista;
        }

        public DataTable Mostrar_Tipo()
        {
                IDbConnection _conn = DBConnetion.Conexion();
                DataTable _tabla = new DataTable();
                _conn.Open();
                SqlCommand _comand = new SqlCommand("SELECT TIPO FROM TUBERIA GROUP BY (TIPO)", _conn as SqlConnection);
                _comand.CommandType = CommandType.Text;
                IDataReader _reader = _comand.ExecuteReader();
                _tabla.Load(_reader);
                _conn.Close();
                return _tabla;
        }

    }
}
