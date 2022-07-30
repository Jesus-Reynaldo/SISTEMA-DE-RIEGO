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
    public class Copia_de_seguridadDAL
    {
        public int Generar_Copia(Copia_SeguridadEN Ecs)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            string _database = _conn.Database.ToString();
            string _cmd = "BACKUP DATABASE [" + _database + "] TO DISK='" + Ecs.generar + "\\" + "Copia" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
            SqlCommand _comand = new SqlCommand(_cmd, _conn as SqlConnection);
            int reultado = _comand.ExecuteNonQuery();
            _conn.Close();
            return reultado;
        }
        public void restaurar_copia(Copia_SeguridadEN eN)
        {
            IDbConnection _conn = DBConnetion.Conexion();
            _conn.Open();
            string _database = _conn.Database.ToString();

            string sqlStmt2 = string.Format("ALTER DATABASE [" + _database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            SqlCommand bu2 = new SqlCommand(sqlStmt2, _conn as SqlConnection);
            bu2.ExecuteNonQuery();

            string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + _database + "] FROM DISK='" + eN.copia + "'WITH REPLACE;";
            SqlCommand bu3 = new SqlCommand(sqlStmt3, _conn as SqlConnection);
            bu3.ExecuteNonQuery();

            string sqlStmt4 = string.Format("ALTER DATABASE [" + _database + "] SET MULTI_USER");
            SqlCommand bu4 = new SqlCommand(sqlStmt4, _conn as SqlConnection);
            bu4.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
