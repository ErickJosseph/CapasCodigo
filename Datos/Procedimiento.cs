using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Procedimiento
    {
        public void RegistrarRegion(string NombreRegion, bool EstadoRegion)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_CrearRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                parameter.Value = NombreRegion;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = EstadoRegion;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();

            }

        }

        public List<RegionDto> ListarRegion(int RegionId)
        {
            List<RegionDto> Lista = new List<RegionDto>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {

                SqlCommand command = new SqlCommand("SP_ListarRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int, 50);
                parameter.Value = RegionId;
                command.Parameters.Add(parameter);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int nRegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                    string cNombreRegion = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";
                    bool bEstadoRegion = reader["Enabled"] != DBNull.Value ? Convert.ToBoolean(reader["Enabled"]) : false;


                    Lista.Add(new RegionDto { RegionId = nRegionId, NombreRegion = cNombreRegion, EstadoRegion = bEstadoRegion });
                }
                reader.Close();
            }

            return Lista;
        }

        public void ActualizarRegion(int nRegionId, string cNombreRegion, bool bEstadoRegion)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_ActualizarRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value = nRegionId;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@RegionName", SqlDbType.NVarChar,200);
                parameter2.Value = cNombreRegion;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter3.Value = bEstadoRegion;
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();

            }

        }

        public void EliminarRegion(int nRegionId)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_EliminarRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value = nRegionId;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

            }

        }


    }
}
