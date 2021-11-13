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
    public class EstadosDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoTipo(Estados user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADOS1 ");
                sql.Append(" VALUES (@SinResolver,@EnEspera, @Abierto, @Cerrado); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@SinResolver", SqlDbType.Bit).Value = user.SinResolver;
                comando.Parameters.Add("@EnEspera", SqlDbType.Bit).Value = user.Espera;
                comando.Parameters.Add("@Abierto", SqlDbType.Bit).Value = user.Abierto;
                comando.Parameters.Add("@Cerrado", SqlDbType.Bit).Value = user.Cerrado;
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

        public DataTable GetUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADOS1 ");

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

        public bool ActualizarUsuario(Estados user)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADOS1 ");
                sql.Append(" SET SOPORTE = @SinResolver, @Abierto, @Cerrado");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@SinResolver", SqlDbType.Bit).Value = user.SinResolver;
                comando.Parameters.Add("@EnEspera", SqlDbType.Bit).Value = user.Espera;
                comando.Parameters.Add("@Abierto", SqlDbType.Bit).Value = user.Abierto;
                comando.Parameters.Add("@Cerrado", SqlDbType.Bit).Value = user.Cerrado;
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

        public bool EliminarUsuario(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADOS1 ");
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
