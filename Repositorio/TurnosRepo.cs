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
    public class TurnosRepo
    {
        Cliente paciente = new Cliente();

        string datosConexion = "Data Source = LEIA; Initial Catalog = tp1; Integrated Security = True;";
        SqlConnection conexion = new SqlConnection();

        public DataTable LlenarCampos(int index)
        {
            DataTable dt = new DataTable();
            conexion.ConnectionString = datosConexion;
            conexion.Open();

            string query = "select * from pacientes where idPacientes='" + index + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

        public DataTable CargarDropdown()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select idPacientes, CONVERT(varchar(10), idPacientes) + ' - ' + nombre + ' ' + apellido + ' - ' + direccion as datos from pacientes where activo=1";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

        public void AsignarTurnos(Turno turno, int index)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();


            string qy = "insert into turnosMedicos values(getdate(), '" + turno.FechaTurno + "','" + turno.Motivo + "','" + turno.Tareas + "', '" + index + "')";

            SqlCommand cmd = new SqlCommand(qy, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }

        public DataTable listaTurnos()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from pacientes inner join turnosMedicos on turnosMedicos.personaId = pacientes.idPacientes";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
    }
}
