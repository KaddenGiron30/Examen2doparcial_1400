using Examen2doparcial_1400.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial_1400.Modelos.DAO
{
    public class TicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();


        public bool InsertarNuevoTicket(Ticket user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Nombre, @Identidad, @Telefono, @Fecha); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 50).Value = user.Identidad;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = user.Telefono;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = user.Fecha;
                comando.ExecuteNonQuery();
                MiConexion.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public bool ActualizarUsuario(Ticket user)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TICKET ");
                sql.Append(" SET NOMBRE = @Nombre, IDENTIDAD = @Identidad, TELEFONO = @Telefono, FECHA = @Fecha");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 50).Value = user.Identidad;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = user.Telefono;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = user.Fecha;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }

        public bool EliminarTicket(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TICKET ");

                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }
    }
}
