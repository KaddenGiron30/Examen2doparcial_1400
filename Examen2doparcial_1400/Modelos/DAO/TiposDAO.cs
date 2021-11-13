using Examen2doparcial_1400.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Examen2doparcial_1400.Modelos.DAO
{
    public class TiposDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoTipo(Tipos user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPOS ");
                sql.Append(" VALUES (@Soporte); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 80).Value = user.TipoSoporte;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetTipos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPOS ");

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

        public bool ActualizarTipos(Tipos user)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPOS ");
                sql.Append(" SET SOPORTE = @Soporte");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 80).Value = user.TipoSoporte;
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
        public bool EliminarTipos(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TIPOS ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
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
