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
    public partial class AltaPersona1 : System.Web.UI.Page
    {
        PacienteNego pacienteNego = new PacienteNego();
        Cliente paciente = new Cliente();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            gdvPacientes.DataSource = pacienteNego.listaPacientes(); //ESTO CARGA LA GRILLA
            gdvPacientes.DataBind(); //ESTO CARGA LA GRILLA
        }


        protected void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
            CargarGrilla();
        }

        private void GuardarPaciente()
        {
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.Telefono = int.Parse(txtTelefono.Text);
            paciente.Direccion = txtDireccion.Text;

            pacienteNego.GuardarPaciente(paciente);
            
        }

        protected void borrar(object sender, ImageClickEventArgs e)
        {
            //txtApellido.Text = e.ToString;
        }

        protected void gdvPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Response.Redirect("ModificarPaciente.aspx?idPacientes=" + index, true);
            }
        }
    }
}