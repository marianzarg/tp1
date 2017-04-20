using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ModificarPaciente : System.Web.UI.Page
    {

        
        PacienteNego pacienteNego = new PacienteNego();
        TurnosNego turnoNego = new TurnosNego();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCampos();
        }

        protected void CargarCampos()
        {
            int index = Int16.Parse(Request["idPacientes"]);
            txtNombre.Text = turnoNego.LlenarCampos(index).Rows[0]["nombre"].ToString();
            txtApellido.Text = turnoNego.LlenarCampos(index).Rows[0]["apellido"].ToString();
            txtDireccion.Text = turnoNego.LlenarCampos(index).Rows[0]["direccion"].ToString();
            txtTelefono.Text = turnoNego.LlenarCampos(index).Rows[0]["telefono"].ToString();
        }

        protected void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            Cliente paciente = new Cliente();
            int index = Int16.Parse(Request["idPacientes"]);
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.Telefono = int.Parse(txtTelefono.Text);
            paciente.Direccion = txtDireccion.Text;


            pacienteNego.ModificarPaciente(paciente, index);
        }
    }
}