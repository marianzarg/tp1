using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class PacienteRepo
    {
        Cliente paciente = new Cliente();
        string datosConexion = "Data Source = LEIA; Initial Catalog = tp1; Integrated Security = True;";
        SqlConnection conexion = new SqlConnection();

        public void ModificarPaciente(Cliente paciente, int index)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();
            string qy = "update pacientes set nombre='" + paciente.Nombre + "',apellido='" + paciente.Apellido + "',direccion='" + paciente.Direccion + "',telefono='" + paciente.Telefono+ "' where idPacientes='" + index + "'";

            SqlCommand cmd = new SqlCommand(qy, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }

        public void GuardarPaciente(Cliente paciente)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();


            string qy = "insert into pacientes values('" + paciente.Nombre + "','" + paciente.Apellido + "','" + paciente.Direccion + "'," + paciente.Telefono + ", '1')";

            SqlCommand cmd = new SqlCommand(qy, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }

        public DataTable listaPacientes()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from pacientes where activo = 1";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
    }
}
